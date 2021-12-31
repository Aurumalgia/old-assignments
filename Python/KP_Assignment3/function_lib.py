import csv
import math
import random

import image
import urllib.request
from PIL import Image





def imageProcessing():
    print("Welcome to the Image Processing Application!")
    rgbFunction = askProcessingType()
    im = findImage()
    print("Processing...")
    newIm = pixelMapper(im, rgbFunction)
    newWin = image.ImageWin(newIm.getWidth(), newIm.getHeight(), "Processed Photo")
    newIm.draw(newWin)
    print("Complete! Click on the photo to close the tab.")
    newWin.exitOnClick()
    if askForRestart():
        return imageProcessing()
    return 0


def clusterAnalyzer():
    print("Welcome to the Cluster Analyzer Application! (Specifically for several select marathons...)")
    col1 = askForColumn1()
    col2 = askForColumn2()
    k = int(askForClusters())
    repeat = int(askForRepeat())
    fullDataDict = readFile("avg_marathon_times_[seconds].csv")
    userDataDict = {}
    key = 0
    for a in fullDataDict:
        key += 1
        userDataDict[key] = [[fullDataDict[a][col1]][0], [fullDataDict[a][col2]][0]]
    createClusters(k, createCentroids(k, userDataDict), userDataDict, repeat)
    if askForRestart():
        return clusterAnalyzer()
    return 0


def askForRestart(prompt="Would you like to start the app from the beginning?\n"):
    userIn = input(prompt).strip().lower()
    if userIn == "yes":
        return True
    elif userIn == "no":
        return False
    return checkImage(
        prompt="Invalid input. Would you like to restart the app? Please enter 'Yes' or 'No'.\n")


def askForRepeat(prompt="How many times would you like us to repeat the analysis for greater accuracy?\n"):
    userIn = input(prompt).strip()
    if userIn.isnumeric():
        return userIn
    return askForRepeat(
        prompt="Invalid input - please enter an integer of how many times you'd like us to repeat it.\n")


def askForClusters(prompt="How many clusters would you like there to be?\n"):
    userIn = input(prompt).strip()
    if userIn.isnumeric():
        return userIn
    return askForClusters(prompt="Invalid input - please enter an integer of how many clusters you want there to "
                                 "be.\n")


def printColumns():
    print("A: Average Time between All Participants\nB: Male to Female Participant Ratio\nC:Temperature in F"
          "\nD: Dew Point in F\nE: Humidity in %\nF: Air Pressure at Sea Level in in.\nG: Visibility in mi\nH: Wind "
          "Speed "
          "in mph\nI: Precipitation in in.")


def askForColumn1(prompt="What is the first column you would like to compare?\n"):
    printColumns()
    validInputs = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'}
    userIn = input(prompt).strip().upper()
    if userIn in validInputs:
        return userIn
    return askForColumn1(prompt="Invalid input. Please enter the letter of the first column you would like to "
                                "compare.\n")


def askForColumn2(prompt="What is the second column you would like to compare?\n"):
    printColumns()
    validInputs = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'}
    userIn = input(prompt).strip().upper()
    if userIn in validInputs:
        return userIn
    return askForColumn1(prompt="Invalid input. Please enter the letter of the second column you would like to "
                                "compare.\n")


def createClusters(k, centroids, dataDict, repeats):
    for aPass in range(repeats):
        print("****PASS", aPass + 1, "****")
        clusters = []
        for i in range(k):
            clusters.append([])

        for key in dataDict:
            distances = []
            for clusterIndex in range(k):
                dToC = euclidDistance(dataDict[key], centroids[clusterIndex])
                distances.append(dToC)

            minDist = min(distances)
            index = distances.index(minDist)

            clusters[index].append(key)

        dimensions = len(dataDict[1])
        for clusterIndex in range(k):
            sums = [0] * dimensions
            for aKey in clusters[clusterIndex]:
                dataPoints = dataDict[aKey]
                for ind in range(len(dataPoints) - 1):
                    sums[ind] += dataPoints[ind]
            for ind in range(len(sums)):
                clusterLen = len(clusters[clusterIndex])
                if clusterLen != 0:
                    sums[ind] /= clusterLen

            centroids[clusterIndex] = sums

        for c in clusters:
            print("CLUSTER")
            for key in c:
                print(dataDict[key], end=" ")
            print()


def createCentroids(k, dataDict):
    centroids = []
    centroidCount = 0
    centroidKeys = []

    while centroidCount < k:
        rKey = random.randint(1, len(dataDict))
        if rKey not in centroidKeys:
            centroids.append(dataDict[rKey])
            centroidKeys.append(rKey)
            centroidCount += 1

    return centroids


def euclidDistance(point1, point2):
    total = 0
    for index in range(len(point1)):
        diff = (point1[index] - point2[index]) ** 2
        total = total + diff
    euclidD = math.sqrt(total)
    return euclidD


def readFile(filename):
    columnList = {}
    with open(filename, "r") as dataFile:
        dataDict = {}
        firstLine = True
        csvReader = csv.reader(dataFile)
        keyList = next(csvReader)
        for line in csvReader:
            dataDict[line[0]] = {}
            for x in range(1, len(line)):
                dataDict[line[0]][keyList[x]] = float(line[x])
    return dataDict





def findImage(prompt="This file must be on this device. With that in mind, what is the file path to the image?\n"):
    userIn = input(prompt)
    userIn.strip()
    while True:
        try:
            im = image.FileImage(userIn)
            break
        except FileNotFoundError:
            return findImage(prompt="There doesn't seem to be an image at this location. Please enter the file "
                                    "path to the image, and check your spelling.\n")
        except PermissionError:
            return findImage(prompt="It seems we don't have access to this image. Please enter a different file path.")

    win = image.ImageWin(im.width, im.height, "Original Picture")
    im.draw(win)
    if checkImage() == 0:
        win.exitOnClick()
        return im
    else:
        win.exitOnClick()
        findImage(prompt="Let's try that again. What is the file path to the image?")


def checkImage(prompt="Is this the correct photo? Respond with 'Yes' or 'No'.\nAfterwards, please "
                      "click on the photo to close the photo. \n"):
    userIn = input(prompt).strip().lower()
    if userIn == "yes":
        return 0
    elif userIn == "no":
        return 1
    return checkImage(
        prompt="Invalid input. Is this the correct photo? Please enter 'Yes' or 'No'.\nAfterwards, please "
               "click on the photo to close the photo. \n")


def pixelMapper(imageFile, rgbFunction):
    width = imageFile.getWidth()
    height = imageFile.getHeight()
    newImage = image.EmptyImage(width, height)

    print(height, width)
    for row in range(height):
        for col in range(width):
            oldPixel = imageFile.getPixel(col, row)
            newPixel = rgbFunction(oldPixel)
            newImage.setPixel(col, row, newPixel)
    return newImage


def grayPixel(oldPixel):
    intensitySum = oldPixel.getRed() + oldPixel.getGreen() + oldPixel.getBlue()
    averageRGB = int(intensitySum / 3)
    newPixel = image.Pixel(averageRGB, averageRGB, averageRGB)
    return newPixel


def negativePixel(oldPixel):
    newRed = 255 - oldPixel.getRed()
    newGreen = 255 - oldPixel.getGreen()
    newBlue = 255 - oldPixel.getBlue()
    newPixel = image.Pixel(newRed, newGreen, newBlue)
    return newPixel

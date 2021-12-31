from prompts import *
import math
import random
import csv


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
    with open(filename, "r") as dataFile:
        dataDict = {}
        csvReader = csv.reader(dataFile)
        keyList = next(csvReader)
        for line in csvReader:
            dataDict[line[0]] = {}
            for x in range(1, len(line)):
                dataDict[line[0]][keyList[x]] = float(line[x])
    return dataDict

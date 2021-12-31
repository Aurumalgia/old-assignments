import image
from prompts import *


def imageProcessing():
    print("Welcome to the Image Processing Application!")
    if askProcessingType() == 1:
        rgbFunction = grayPixel
    else:
        rgbFunction = negativePixel
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

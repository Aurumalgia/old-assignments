from planetClass import *
from prompts import *


def startPlanets():
    planetList = []
    print("Welcome to the Planet Application! \nTo start, let's make a Planet.")
    planetList.append(makePlanet())
    printPlanets(planetList)
    running = True
    while running:
        nextAction = askNextAction()
        if nextAction == 0:
            running = False
        else:
            if nextAction == 1:
                planetList.append(makePlanet())
            elif nextAction == 2:
                if not planetList:
                    print("There are no planets to destroy!")
                else:
                    planetList = destroyPlanet(planetList)
            else:
                findInformation(planetList)
            printPlanets(planetList)
    print("Thank you for using the Planets app!")




def makePlanet():
    return Planet(askForName(), askForRadius(), askForMass(), askForDistance())


def destroyPlanet(planetList):
    planetList.pop(askForNumber(planetList) - 1)
    return planetList


def findInformation(planetList):
    planetNumber = askForNumber(planetList) - 1
    infoType = askForInfoType(planetList[planetNumber])
    if infoType == 1:
        v = str(planetList[planetNumber].getVolume())
        print("The Volume is: " + v)
    elif infoType == 2:
        sa = str(planetList[planetNumber].getSurfaceArea())
        print("The Surface Area is: " + sa)
    elif infoType == 3:
        d = str(planetList[planetNumber].getDensity())
        print("The Surface Area is: " + d)


def printPlanets(planetList):
    for n in range(len(planetList)):
        print(planetList[n].toString())

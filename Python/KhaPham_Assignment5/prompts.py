from imageProcessing import *


def askForRestart(prompt="Would you like to start the app from the beginning?\n"):
    userIn = input(prompt).strip().lower()
    if userIn == "yes":
        return True
    elif userIn == "no":
        return False
    return askForRestart(
        prompt="Invalid input. Would you like to restart the app? Please enter 'Yes' or 'No'.\n")


def askProcessingType(prompt="What type of image processing would you like to do? \n1. Turn to Grayscale\n2. Turn to "
                             "Negative\n"):
    userIn = input(prompt).strip().lower()
    if userIn == "1":
        return 1
    elif userIn == "2":
        return 2
    return askProcessingType(prompt="Invalid input. What type of image processing would you like to do? \n1. Turn to "
                                    "Grayscale\n2. Turn to Negative\n")


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


def askForType(prompt="Would you like the regular or the random recursive trees?\n1: Regular\n2: Random\n"):
    userIn = input(prompt)
    if userIn == '1':
        return 0
    elif userIn == '2':
        return 1
    else:
        return askForType(
            prompt="Invalid response, please try again. Would you like the regular or the random recursive trees?\n1: "
                   "Regular\n2: Random\n")


def askForName():
    userIn = input("What would you like to name the planet?\n")
    userIn = userIn.strip()
    if askIfCorrect(userIn, True):
        return userIn.strip()
    else:
        return askForName()


def askForRadius():
    userIn = input("What would you like the radius to be?\n")
    userIn = userIn.strip()

    while not checkValidNumber(userIn):
        return askForRadius()

    if askIfCorrect(userIn, True):
        return float(userIn)
    else:
        return askForRadius()


def askForMass():
    userIn = input("What would you like the mass to be?\n")
    userIn = userIn.strip()

    while not checkValidNumber(userIn):
        return askForMass()
    if askIfCorrect(userIn, True):
        return float(userIn)
    else:
        return askForMass()


def askForDistance():
    userIn = input("What would you like the distance from the sun to be?\n")
    userIn = userIn.strip()

    while not checkValidNumber(userIn):
        return askForMass()
    if askIfCorrect(userIn, True):
        return float(userIn)
    else:
        return askForDistance()


def checkValidNumber(value):
    try:
        float(value)
    except ValueError:
        print("Invalid input, please enter a positive number.")
        return False

    if float(value) <= 0:
        print("Invalid input, please enter a positive number.")
        return False
    else:
        return True


def askIfCorrect(checkVal, first):
    if not first:
        print("Invalid input. Please enter either Yes or No.")
    userIn = input("Is '" + checkVal + "' correct?\n")
    userIn = userIn.strip().lower()
    if userIn == "yes":
        return True
    elif userIn == "no":
        return False
    else:
        return askIfCorrect(checkVal, False)


def askNextAction():
    userIn = input("What would you like to do next?\n1: Add a Planet\n2: Remove a Planet\n3: Find Information on a "
                   "Planet.\n4: Quit the App\n").strip()
    if userIn == '1':
        return 1
    elif userIn == '2':
        return 2
    elif userIn == '3':
        return 3
    elif userIn == '4':
        return 0
    else:
        print("Invalid input.")
        return askNextAction()


def askForNumber(planetList):
    import planetClass
    print("Which Planet?")
    x = 0
    for n in planetList:
        x = x + 1
        print(str(x) + ". " + n.getName())
    userIn = input()
    if int(userIn.strip()) > len(planetList) or int(userIn) <= 0:
        print("Invalid number.")
        return askForNumber(planetList)
    else:
        return int(userIn)


def askForInfoType(planet):
    userIn = input("What do you want to find out about " + planet.getName() + "?\n1: Volume \n2: Surface Area\n3: "
                                                                              "Density\n").strip()
    if 3 >= int(userIn) >= 1:
        return int(userIn)
    else:
        print("Invalid Input.")
        return askForInfoType()


def askForNumRails():
    userIn = input("How many rails?\n").strip()

    try:
        int(userIn)
    except ValueError:
        print("Invalid input, please enter a positive Integer.")
        return False

    if int(userIn) <= 0:
        print("Invalid input, please enter a positive Integer.")
        askForNumRails()
    else:
        return int(userIn)


def askForPhrase():
    userIn = input("What do you want to encrypt?\n")
    if askIfCorrect(userIn, True):
        return userIn
    else:
        return askForPhrase()

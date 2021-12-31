##Kha Pham
##Assignment 5
##08152020

import deviceInfo
import imageProcessing
import fractalTrees
import clusterAnalyzer
import planets
import railDecrypt


def main():
    print("This is Kha Pham's Final Assignment (Assignment 5).")
    quitApp = True
    while quitApp:
        app = askForApp()
        # Each of these apps should each apply concepts from a different chapter
        if app == 1:
            imageProcessing.imageProcessing()
        elif app == 2:
            clusterAnalyzer.clusterAnalyzer()
        elif app == 3:
            fractalTrees.startTree()
        elif app == 4:
            railDecrypt.railBreak()
        elif app == 5:
            deviceInfo.printDeviceInfo()
        elif app == 6:
            planets.startPlanets()
        elif app == 0:
            quitApp = False

    print("Thank you for using this Application! Enjoy your day!")


def askForApp(prompt="Which Application would you like to use today?\n1: Image Processsor\n2: Cluster "
                     "Analyzer\n3: Fractal Trees\n4: Rail Ciphers\n5: Find your IP\n6: Make Planets\nOtherwise, type 'Quit' to quit.\n"):
    userIn = input(prompt)
    userIn.strip().lower()
    if userIn == "quit":
        return 0
    elif 5 >= int(userIn) > 0:
        return int(userIn)
    return askForApp(
        prompt="Invalid input - Please enter '1' for the Image Processor or '2' for the Cluster Analyzer\n")


main()

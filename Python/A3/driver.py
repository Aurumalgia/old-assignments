##Name: Kha Pham
##Project: Asssignment 3
##Date: 08/04/2020




from function_lib import *
from image import *
from PIL import Image

def main():
    print("Welcome to Kha's Assignment 4 Application! (I apologize for the tardiness, there were many bugs to squash.")
    quitApp = True
    while quitApp:
        app = askForApp()
        if app == 1:
            imageProcessing()
        elif app == 2:
            clusterAnalyzer()
        elif app == 0:
            quitApp = False
    print("Thank you for using this Application! Enjoy your day!")


def askForApp(prompt="Which Application would you like to use today?\n1: Image Processsor\n2: Cluster Analyzer\n\nOtherwise, type 'Quit' to quit.\n"):
    userIn = input(prompt)
    userIn.strip().lower()
    if userIn == '1':
        return 1
    elif userIn == '2':
        return 2
    elif userIn == "quit":
        return 0
    return askProcessingType(
        prompt="Invalid input - Please enter '1' for the Image Processor or '2' for the Cluster Analyzer\n")


main()
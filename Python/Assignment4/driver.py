##Kha Pham
## August 8th
## Assignment 4
from function_lib import *


def main():
    print("Welcome to Kha's Assignment 5 Application!")
    quitApp = True
    while quitApp:
        app = askForApp()
        if app == 1:
            print(railBreak("HrraKpsf  eyyeo,mhetehnso!lf ea a,aitu lem .yy vc r osyi o aeeo   s sHusn  fd Pon o adar a \n\n"))
        elif app == 2:
            startTree()
        elif app == 0:
            quitApp = False
    print("Thank you for using this Application! Enjoy your day!")


def askForApp(prompt="Which Application would you like to use today?\n1: Rail Decoder\n2: Recursive "
                     "trees\n\nOtherwise, type 'Quit' to quit.\n"):
    userIn = input(prompt)
    userIn.strip().lower()
    if userIn == '1':
        return 1
    elif userIn == '2':
        return 2
    elif userIn == "quit":
        return 0
    return askForApp(
        prompt="Invalid input - Please enter '1' for Rail Decoder or '2' for Recursive Trees\n")

main()
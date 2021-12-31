def checkInBoundary(num, upperBoundary, lowerBoundary):
    index = 0
    contain = False
    while index <= 26 and not contain:
        if lowerBoundary[index] <= num < upperBoundary[index]:
            return index
        else:
            index += 1
    return index


def lPrimePrompt():
    while True:
        try:
            lPrime = float(input("What is the number to decode?\n"))
            if 0 < lPrime < 1:
                break
            else:
                print("Oops! That was not a valid number. It must be a decimal between 0 and 1.")
        except ValueError:
            print("Oops! That was not a valid number. It must be a decimal between 0 and 1.")
    return lPrime


def charLimPrompt():
    while True:
        try:
            characterLimit = int(input("What is the amount of characters?\n"))
            break
        except ValueError:
            print("Oops! That was not a valid number. Please Try again.")
    return characterLimit


def decode(lPrime, characterLimit):
    lowerBoundary = []
    upperBoundary = []
    characters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                  'u',
                  'v', 'w', 'x', 'y', 'z', ' ']

    count = 0

    while count <= 27:
        lowerBoundary.append(count / 27)
        upperBoundary.append((count + 1) / 27)
        count += 1

    count = 1
    print(characters[checkInBoundary(lPrime, upperBoundary, lowerBoundary)], end='')
    lastCharacter = checkInBoundary(lPrime, upperBoundary, lowerBoundary)

    while count < characterLimit:
        lPrime = (lPrime - lowerBoundary[lastCharacter]) / (upperBoundary[lastCharacter] - lowerBoundary[lastCharacter])
        lastCharacter = checkInBoundary(lPrime, upperBoundary, lowerBoundary)
        print(characters[lastCharacter], end='')
        count += 1


def continueProgramPrompt():
    while True:
        try:
            userin = input("Would you like to do it again? Y/n \n")
            if userin.strip().lower() == 'y':
                return True
            elif userin.strip().lower() == 'n':
                return False
            else:
                print("Oops!  That was not a valid answer.")
        except ValueError:
            print("Oops!  That was not a valid answer.")


def main():
    continueProgram = True
    while continueProgram:
        lPrime = lPrimePrompt()
        characterLimit = charLimPrompt()
        decode(lPrime, characterLimit)
        print("\n")
        continueProgram = continueProgramPrompt()


main()
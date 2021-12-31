import string


def continuePrompt():
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


continueRun = True
while continueRun:
    lowerBoundary = []
    upperBoundary = []
    characters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
                  'u',
                  'v', 'w', 'x', 'y', 'z', ' ']

    phrase = input("Please enter in a phrase. Punctuation, not including spaces, will be removed.\n")
    phrase = phrase.translate(str.maketrans('', '', string.punctuation))
    phrase = phrase.lower()

    print(phrase)

    count = 0

    while count <= 27:
        lowerBoundary.append(count / 27)
        upperBoundary.append((count + 1) / 27)
        count += 1

    high = 1
    low = 0
    currentHigh = 0
    currentLow = 0
    for x in phrase:
        count = 0
        found = False
        while count < 27 and not found:
            if x == characters[count]:
                found = True
            else:
                count += 1

        currentHigh = low + (high - low) * upperBoundary[count]
        currentLow = low + (high - low) * lowerBoundary[count]
        print(x + ", " + str(currentLow) + ", " + str(currentHigh))
        high = currentHigh
        low = currentLow
    print("\nLow: " + str(low))
    continueRun = continuePrompt()

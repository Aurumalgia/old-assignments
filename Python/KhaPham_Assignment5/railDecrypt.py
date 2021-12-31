from prompts import *


def createWordDict(dName):
    myDict = {}
    with open(dName, 'r') as myFile:
        for line in myFile:
            myDict[line[:-1]] = True
        return myDict


def railBreak():
    cipherText = makeRailCipher()
    wordDict = createWordDict("wordlist.10000.txt")
    print("Now decoding this text: \n" + cipherText + " using Rail Decrypt and a Dictionary\n")
    cipherLen = len(cipherText)
    maxGoodSoFar = 0
    bestGuess = "No words found in dictionary"
    for i in range(2, cipherLen + 1):
        words = railDecrypt(cipherText, i)
        goodCount = 0
        for w in words:
            if w in wordDict:
                goodCount += 1
        if goodCount > maxGoodSoFar:
            maxGoodSoFar = goodCount
            bestGuess = " ".join(words)
    return bestGuess


def railDecrypt(cipherText, numRails):
    railLen = len(cipherText) // numRails
    solution = ''
    for col in range(railLen):
        for rail in range(numRails):
            nextLetter = col + (rail * railLen)
            solution = solution + cipherText[nextLetter]
    return solution.split()


def makeRailCipher():
    numRails = askForNumRails()
    phrase = askForPhrase()
    counter = 0
    stringArray = []
    for x in range(numRails):
        stringArray.append("")
    while len(phrase) > 0:
        stringArray[counter] += phrase[0]
        if len(phrase) > 1:
            phrase = phrase[1:]
        else:
            phrase = ''
        counter += 1
        if counter >= numRails:
            counter = 0
    for s in range(len(stringArray)):
        while len(stringArray[0]) > len(stringArray[s]):
            stringArray[2] += " "
    encrypted = ''
    for s in stringArray:
        encrypted += s
    print(encrypted)
    return encrypted

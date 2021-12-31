import random


def startTree():
    import turtle as t
    if askForType() == 0:
        execute = tree
    else:
        execute = ranTree
    wn = t.Screen()
    t.speed("fastest")
    t.up()
    t.goto(0, -255)
    t.down()
    t.color("green", "green")
    t.left(90)
    execute(t, 115)
    input("Press enter to continue")
    wn.clear()



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


def tree(t, trunkLength):
    if trunkLength < 10:
        t.color("green", "green")
    else:
        t.color("red", "red")  ##just to show pathing
    if trunkLength >= 5:
        t.forward(trunkLength)
        t.right(30)
        tree(t, trunkLength - 15)
        t.left(60)
        tree(t, trunkLength - 15)
        t.right(30)
        t.backward(trunkLength)

    return


def ranTree(t, trunkLength):
    r = random.randrange(15, 45)
    r2 = random.randrange(5, 25)
    if trunkLength < 10:
        t.color("green", "green")
    else:
        t.color("red", "red")  ##just to show pathing
    if trunkLength >= 5:
        t.forward(trunkLength)
        t.right(r)
        ranTree(t, trunkLength - r2)
        t.left(r * 2)
        ranTree(t, trunkLength - r2)
        t.right(r)
        t.backward(trunkLength)

    return


def createWordDict(dName):
    myDict = {}
    with open(dName, 'r') as myFile:
        for line in myFile:
            myDict[line[:-1]] = True
        return myDict


def railBreak(cipherText):
    wordDict = createWordDict("wordlist.10000.txt")
    print("Now decoding this text: \n" + cipherText + "\n")
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

import random
from prompts import *


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

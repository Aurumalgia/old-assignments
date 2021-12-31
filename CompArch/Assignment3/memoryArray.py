class memoryArray:
    def __init__(self, initialLength):
        self.memory = {}
        self.initialLength = initialLength
        self.lastLoc = initialLength - 1
        for x in range(initialLength):
            memLoc = 33554432 + x
            self.memory[memLoc] = 0

    def printArray(self):
        txt = "{0:#010x}: {1:#010b}"
        for y in self.memory:
            print(txt.format(y, self.memory[y]))

    def addMemoryLocs(self, amount):
        for y in range(amount+1):
            memLoc = 33554432+self.lastLoc+y
            self.memory[memLoc] = 0
        self.lastLoc = self.lastLoc + amount

    def changeMem(self, loc, binNum):
        self.memory[33554432+loc] = binNum



x = memoryArray(10)
x.addMemoryLocs(1)
x.changeMem(10, 5)
print(x.printArray())

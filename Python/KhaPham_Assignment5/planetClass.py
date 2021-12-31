class Planet:
    def __init__(self, iName, iRad, iM, iDist):
        self.__name = iName
        self.__radius = iRad
        self.__mass = iM
        self.__distance = iDist

    def getName(self):
        return self.__name

    def getRadius(self):
        return self.__radius

    def getMass(self):
        return self.__mass

    def getDistance(self):
        return self.__distance

    def getVolume(self):
        import math
        v = 4 / 3 * math.pi * self.__radius ** 3
        return v

    def getSurfaceArea(self):
        import math
        sa = 4 * math.pi * self.__radius ** 2
        return sa

    def getDensity(self):
        d = self.__mass / self.getVolume
        return d

    def setName(self, name):
        self.__name = name

    def setRadius(self, r):
        self.__radius = r

    def setMass(self, m):
        self.__mass = m

    def setDistance(self, d):
        self.__distance = d

    def toString(self):
        return ("Name: " + self.__name + "\n\tRadius: " + str(self.__radius) + "\n\tMass: " + str(self.__mass) + "\n\tDistance: "
                + str(self.__distance))

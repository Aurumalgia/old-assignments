class IEEE:
    def __init__(self, sign: int, exponent: int, mantissas: int):
        self.sign = sign
        self.exponent = exponent
        self.mantissas = mantissas


    def getSign(self):
        return self.sign

    def getExponent(self):
        return self.exponent

    def getMantissas(self):
        return self.mantissas

    def setSign(self, sign):
        self.sign = sign

    def setExponent(self, exponent):
        self.exponent = exponent

    def setMantissas(self, mantissas):
        self.mantissas = mantissas

    def __str__(self):
        s = str(self.sign)
        s += " " + format(self.exponent, '08b')
        s += " " + format(self.mantissas, '023b')
        return s
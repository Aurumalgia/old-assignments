import sys
import math
import IEEENumber


def encoder(decimalNumber):
    sign = [0]
    exponent = []
    IEEE754 = [0] * 32
    expCounter = 0

    fullBin = decimalToBinary(decimalNumber, 24)
    wholeBin = fullBin[0]
    if len(fullBin) == 2:
        fractBin = fullBin[1]

    noLead0 = False
    while not noLead0:
        if len(wholeBin) > 1:
            if wholeBin[0] == 0:
                wholeBin.pop(0)
            else:
                noLead0 = True
        else:
            noLead0 = True


    wholeDigits = len(wholeBin)
    while len(wholeBin) != 1:
        if len(wholeBin) > 1:
            fractBin.insert(0, wholeBin.pop(len(wholeBin) - 1))
            expCounter += 1
        else:
            wholeBin.insert(fractBin.pop(0), 0)

    while len(fractBin) > 23:
        fractBin.pop(len(fractBin)-1)
    binRep = fractBin

    exponentDec = wholeDigits + 127 - 1
    for i in range(8):
        exponent.append(exponentDec % 2)
        exponentDec = int(exponentDec / 2)
    exponent.reverse()
    if exponentDec > 0:
        sys.exit("Number out of bounds")

    IEEE754[0] = sign[0]
    for i in range(8):
        IEEE754[i + 1] = exponent[i]
    for i in range(len(binRep) - 1):
        IEEE754[i + 9] = binRep[i]

    return IEEENumber.IEEE(sign[0], wholeDigits + 126, binaryToDecimal(binRep))


def decimalToBinary(num, k_prec):
    binary = []
    fract = []
    # Fetch the integral part of
    # decimal number
    Integral = int(num)

    # Fetch the fractional part
    # decimal number
    fractional = num - Integral

    # Conversion of integral part to
    # binary equivalent
    while Integral:
        rem = Integral % 2

        # Append 0 in binary
        binary.append(rem)

        Integral //= 2
        k_prec -= 1

    # Reverse string to get original
    # binary equivalent
    binary.reverse()

    # Conversion of fractional part
    # to binary equivalent
    while k_prec:

        # Find next bit in fraction
        fractional *= 2
        fract_bit = int(fractional)

        if fract_bit == 1:
            fractional -= fract_bit
            fract.append(1)

        else:
            fract.append(0)

        k_prec -= 1

    return [binary, fract]


def binaryToDecimal(x):
    d = 0
    i = 1
    for n in range(len(x) - 1, 0, -1):
        d += (x[n] * (2 ** i))
        i += 1
    return d
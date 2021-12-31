import encoder
import IEEENumber


def division(a: IEEENumber.IEEE, b: IEEENumber.IEEE):
    aIs0 = True
    bIs0 = True
    if a.mantissas != 0:
        aIs0 = False

    if b.mantissas != 0:
        bIs0 = False

    if bIs0:
        print("Can't divide by 0")
    elif aIs0:
        return encoder.encoder(0)
    else:
        return divide(a, b)


def divide(a: IEEENumber.IEEE, b: IEEENumber.IEEE):
    result = IEEENumber.IEEE(0, 0, 0)
    if a.getSign() + b.getSign() == 1:
        result.setSign([1])

    exponent = (a.getExponent() - b.getExponent() + 127) % 0b100000000

    q = 0
    r = 0
    for i in range(a.getMantissas().bit_length() - 1, 0, -1):
        r = r << 1
        modifyBit(r, r.bit_length(), returnBit(a.getMantissas(), i))
        if r >= b.getMantissas():
            r = r - b.getMantissas()
            modifyBit(q, i, 1)
    print(q, r)


def modifyBit(n, p, b):
    mask = 1 << p
    return (n & ~mask) | ((b << p) & mask)


def returnBit(n, p):
    m = n >> p
    m = m % 0b10
    return m


value = 0b00010001

print(returnBit(value, 4))

print(format(value, '08b'))

print(division(encoder.encoder(0), encoder.encoder(2)))
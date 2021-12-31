import encoder

def main():
    names = ['Kha', 'Nathan', 'Mohammed', 'Jonathan', 'John']
    print(names)
    for n in range(len(names)):
        word = names[n]
        wordlist = [ch for ch in word]
        names[n] = wordlist
    print(names)
    print("Names in IEEE, before encoding")
    for n in names:
        for s in n:
            print(s+": ")
            print(encoder.encoder(ord(s)))

main()
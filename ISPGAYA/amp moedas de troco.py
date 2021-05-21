
def main():
    preco = float(input("Insira o preço do produto (em euros): "))

    preco = int(preco*100)
    troco = 200 - preco

    print("Troco: ", troco )

    moedas = [100, 50, 20, 10, 5, 2, 1 ]

    i = 0
    while troco > 0:
        n = troco // moedas[i]
        if n>0:
            print( n, " moedas de ", moedas[i]/100, " €" )
        troco = troco % moedas[i]
        i = i + 1


if __name__ == '__main__':
    main()
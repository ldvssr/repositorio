def main():
    lista = [ 1, 2, 9, 4, 5, 6 ]
    contador = 0
    soma = 0
    maior = lista[0]

    for i in lista:
        contador = contador + 1
        soma = soma + i
        if i > maior:
            maior = i

    print( "Soma      = ", soma )
    print( "Elementos = ", contador )

    print( "Media     = {0:6.2f}".format(soma/contador) )
    print( "Maior     = ", maior )

    for n in lista:
        print( n )

if __name__ == '__main__':
    main()

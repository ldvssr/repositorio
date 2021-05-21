#media 10 numeros

def main():

    soma = 0
    contador = 0
    while True:
        n = int(input("Insira um número: " ))
        soma = soma + n
        contador = contador + 1
        if(contador == 10):
            break

    print("Média: {0:.2".format(soma/contador ))

    
if __name__ == '__main__':
    main()

    
def main():

    maior = 0
    while True:
        n = int(input("Insira um número: " ))
        if n <= 0:
            break
        if n > maior:
            maior = n

    print("Maior: {0}".format(maior) )
    
if __name__ == '__main__':
    main()

#maior numero

def main():

    maior = 0
    while True:
        n = int(input("Insira um número: " ))
        if n <= 0:
            break
        if n > maior:
            maior = n

    print("Maior: {0}".format(maior) )
    
if __name__ == '__main__':
    main()

#while e do while

def main():

    # ciclo while - equivale a "enquanto..."
    n = int(input("Insira um número: " ))
    c = 1
    while n > 0:
        n = int(input("Insira um número: " ))
        c = c + 1
    print("Total: ", c )

    # ciclo while com break - equivale a "faca...enquanto"
    c = 0
    while True:
        n = int(input("Insira um número: " ))
        c = c + 1
        if(n < 0):
            break
    print("Total: ", c )

    
if __name__ == '__main__':
    main()

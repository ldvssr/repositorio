
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
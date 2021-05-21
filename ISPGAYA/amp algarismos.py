def main():

    numero = int(input("Insira um número positivo: " ))
    
    if numero > 0:
        soma = 0
        contador = 0
        while numero > 0:
            algarismo = numero % 10
            contador = contador + 1
            soma = soma + algarismo
            numero = numero // 10
         
        print( "Soma: ", soma, "Algarismos: ", contador )
    else:
        print("Número inválido!")

if __name__ == '__main__':
    main()
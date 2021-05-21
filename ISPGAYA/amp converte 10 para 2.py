def main():

    decimal = int(input("Insira um número decimal positivo: " ))
    
    if decimal > 0:
        binario = ""
        while decimal > 0:
            digito = decimal % 2
            binario = str(digito) + binario
            decimal = decimal // 2
         
        print( "Binário: ", binario )
    else:
        print("Número inválido!")

if __name__ == '__main__':
    main()
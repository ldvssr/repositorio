def main():
    mensagem = input("Insira a mensagem: ")
    n = int(input("Insira o número de repetições: " ))

    i = 1
    while i <= n:
        print( "{0:1}. {1}".format( i, mensagem ))
        i = i + 1

if __name__ == '__main__':
    main()
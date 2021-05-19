

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

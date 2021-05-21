

def main():

    soma = 0
    i = 0
    while True:
        n = int(input("Insira um número: " ))
        if n < 0:
            break
        soma = soma + n
        i = i + 1
    media = soma / i
    
    print("Mádia: {0:.2}".format(media) )
    
if __name__ == '__main__':
    main()
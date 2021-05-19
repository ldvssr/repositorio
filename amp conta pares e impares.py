def main():
    pares = 0
    impares = 0
    
    x = int(input("insira um numero: "))

    while x >= 0:
        if x==0:
            print("zero")
        else:
            if x%2==0:
                print("par")
                pares++
            else:
                print("impar")
                impares = impares + 1
            
        x = int(input("insira um numero: "))

    print( "Pares = ", pares, "Impares = ", impares )

if __name__ == '__main__':
    main()
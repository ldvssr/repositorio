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
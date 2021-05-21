# primeiro programa em Python

def main():
    n = int(input( "insira um numero: " ))

    if n == 0:
        print("Zero")
    else:
        if n%2 == 0:
            print("Par")
        else:
            print("Impar")
        
if __name__ == '__main__':
    main()
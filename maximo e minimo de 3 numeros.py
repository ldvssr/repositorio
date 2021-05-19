def main():
    a = int(input( "insira o primeiro numero: " ))
    b = int(input( "insira o segundo  numero: " ))
    c = int(input( "insira o terceiro numero: " ))
    
    if a>b and a>c:
        maior = a
    else:
        if b>c:
            maior = b
        else:
            maior = c
    if a<b and a<c:
        menor = a
    else:
        if b<c:
            menor = b
        else:
            menor = c

    print( "O maior número é ", maior )
    print( "O menor número é ", menor )
    
if __name__ == '__main__':
    main()

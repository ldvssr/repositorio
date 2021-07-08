n = int(input('Quantos termos?'))
n1, n2 = 0, 1
cont = 0
if n <= 0:
    print('Introduza um inteiro positivo')
elif n == 1:
    print('Sequência de fibonacci ate',n,':')
    print(n1)
else:
    print('Sequência de fibonacci:')
    while cont < n:
        print (n1)
        pt = n1 + n2
        n1 = n2
        n2 = pt
        cont += 1

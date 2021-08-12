'''

Nome: Concurso do Euromilhões
Data: 12/08/2021
Autor: Licínio Daniel Ventura dos Santos silva do Rosário
Descrição: Ficha de avaliação de Programação avançada com Python
Observações:

    Queremos criar uma simulação do concurso Euromilhões.
    1.	Deverá ser pedido ao utilizador que introduza 5 e apenas 5 números entre 1 e 50.
    2.	Não deverá aceitar números repetidos.
    3.	Deverá ser pedido ao utilizador que introduza 2 e apenas 2 números para as estrelas entre 1 e 12.
    4.	Não deverá aceitar números repetidos para as estrelas.
    5.	Deverá ser gerada uma chave aleatória com 5 números não repetidos, entre 1 e 50.
    6.	Deverá ser gerada uma chave aleatória para as estrelas com 2 números não repetidos, entre 1 e 12.
    7.	No final, deverão ser encontrados os números comuns na aposta do utilizador e na chave gerada, assim como os números para as estrelas.
    8.	Deverá ser apresentado o resultado ordenado com o seguinte formato:
    a.	Acertou em x números e y estrelas
    b.	Devendo o x ser substituído pelo número de números certos e o y pelo número de estrelas certas.

    Nota: Pode fazer o exercício num único ficheiro se assim o desejar. Acrescente o seu nome no nome do ficheiro.
    Boa sorte!

'''

import random

numeros = []

numeros_introduzidos = []

estrelas = []

estrelas_introduzidas = []

numeros_total = 5

estrelas_total = 2

print('-'*50)

print('\nEste programa serve para simular um sorteio do Euromilhões.\n')

print('-'*50)

print('\nIntroduza os números (Entre 1 e 50).\n')


def ler_numeros (n1):
    
    controlo = 0
    contador = 5
    nova_lista = []

    while controlo == 0:
        n1=int(input("insira um numero: "))
        if n1 >= 1 and n1 <= 50:
            nova_lista.append(n1)
            contador -= 1
            if contador == controlo:
                controlo = 1
        else:
            while n1 < 1 and n1 > 50:
                n1=int(input("insira um numero: "))

    return nova_lista

numeros_introduzidos = ler_numeros(numeros_total)

print('\nOs números introduzidos foram:\n')

for i in range (numeros_total):
    numeros_introduzidos.sort()
    print(numeros_introduzidos[i])

#print(numeros_introduzidos)
print('')
print('-'*50)

print('\nIntroduza as estrelas (Entre 1 e 12).\n')

def ler_estrelas (n1):
    controlo = 0
    contador = 2
    nova_lista = []
        
    while controlo == 0:
        n1=int(input("insira um numero: "))
        if n1 >= 1 and n1 <= 12:
            nova_lista.append(n1)
            contador -= 1
            if contador == controlo:
                controlo = 1
        else:
            while n1 < 1 and n1 > 12:
                n1=int(input("insira um numero: "))

    return nova_lista

estrelas_introduzidas = ler_estrelas(estrelas_total)

print('\nAs estrelas introduzidas foram:\n')

for j in range (estrelas_total):
    estrelas_introduzidas.sort()
    print(estrelas_introduzidas[j])

#print(estrelas_introduzidas)

print('-'*50)

print('\nSorteio:\n')

print('-'*50)

for i in range(numeros_total):
    numeros.append(random.randint(1,50)) 

for j in range(estrelas_total):
    estrelas.append(random.randint(1,12)) 

print('\nOs números sorteados são:\n')

for i in range (numeros_total):
    numeros.sort()
    print(numeros[i])

#print(numeros)
print('')
print('-'*50)

print('\nAs estrelas sorteadas são:\n')

for j in range (estrelas_total):
    estrelas.sort()
    print(estrelas[j])

#print(estrelas)
print('')
print('-'*50)

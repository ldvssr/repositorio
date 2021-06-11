def soma(a,b):
    return a + b
def subtracao(a,b):
    return a - b
def multiplicacao(a,b):
    return a * b
def divisao(a,b):
    return a / b
repetir = True
while (repetir == True):
    a = input("insira o valor 1: ")
    b = input("insira o valor 2: ")
    num1 = float(a)
    num2 = float(b)
    c = int(input("1 - soma / 2 - subtracao / 3 - multiplicacao / 4 - divisao "))
    if (c == 1):
        print(soma(num1,num2))
    elif (c == 2):
        print(subtracao(num1,num2))
    elif (c == 3):
        print(multiplicacao(num1,num2))
    elif (c == 4):
        if (num2 == 0):
            print("Impossível dividir por zero! ")
        else:
            print(divisao(num1,num2))
    continuar = input("Deseja continuar? (S/N) ")
    if (continuar == "N" or continuar == "n"):
        repetir = False


def somar(a, b):
    return a + b
def subtrair(a, b):
    return a - b
def multiplicar(a, b):
    return a * b
def dividir(a, b):
    return a / b
operacoes = {"+": somar,"-": subtrair,"*": multiplicar,"/": dividir}
n1 = input("Insira o valor 1: ")
for op in operacoes:
    print(op)
    oper = input("Escolha uma operação acima...")
    flag = False
    for op in operacoes:
        if(op == oper):
            flag = True
        if(flag == True):
            print("Operação existe")
        if(oper == '+' or oper == '-' or oper == '*' or oper == '/'):
            n2 = input("Insira o valor 2: ")
            calc = operacoes[oper]
            print(f"Resultado: {n1} {oper} {n2} = {round(calc(float(n1), float(n2)), 2)}")
        else:print("Operação inválida")
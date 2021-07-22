def menu():
    print('1: Guardar')
    print('2: Eliminar')
    print('3: Atualizar')
    print('4: Criar')
    print('0: Sair')
op = 1
while op != 0:
    menu()
    op = int(input('Escreva uma opção: '))
    if op == 1: print('Guardar selecionado')
    elif op == 2: print('Eliminar selecionado')
    elif op == 3: print('Atualizar selecionado')
    elif op == 4: print('Criar selecionado')
    else:
        op = 0

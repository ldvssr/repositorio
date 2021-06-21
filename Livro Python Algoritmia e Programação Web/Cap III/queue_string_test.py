def main():
    queue2 = ["António", "Ana", "Miguel", "Daniela"]
    nome = input("Inserir novo valor na retaguarda da fila: ")
    queue2.append(nome)
    print(queue2)
    # fazer enquanto existem elementos na fila
    while queue2:
        print (queue2.pop(0))
    print(queue2)
    print('fila vazia')
main()

    











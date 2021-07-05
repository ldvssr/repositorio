def ler_valores (vezes):
    lista = []
    for n in range(0, vezes):
        n1=int(input("insira um numero: "))
        lista.append(n1)
    return lista

def media3 (lista):
    media = sum(lista) / len(lista)
    return media


vezes = int(input("insira o numero de valores a definir: "))
lista = ler_valores(vezes)
print()
media = media3(lista)
print(media)
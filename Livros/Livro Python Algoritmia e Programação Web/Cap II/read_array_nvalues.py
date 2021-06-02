# ler variavel com o numero de elementos do array
n = int(input ("Inserir o número de elementos do array a ler: "))
# criar array de inteiros (com base numa lista)
nums = []
# para todos os elementos do array
for i in range(n):
    # ler elemento
    val = int(input("Inserir valor: "))
    # inserir (adicionar)
    nums.append(val)
# imprimir array (lista)    
print(nums)

# criar array e inserir valores alfanumericos
sval = []
pal = input("Inserir palavra/texto (enter para terminar): ")
# ciclo enquanto a palavra é diferente de 'vazio'
while (pal != ""):
    sval.append(pal)
    pal = input("Inserir valor (enter para terminar): ")
print(sval)
print (len(sval), "palavras inseridas")



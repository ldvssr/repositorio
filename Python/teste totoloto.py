# biblioteca random para a geracao de numeros aleatorios
import random
# cria matriz atraves de uma lista
mat = []
# dimensao da matriz
lin = 10
col = 5
# percorrer as linhas e as colunas da matriz
for i in range(lin):
    linha = []
    for j in range(col):
        # insere novo elemento numa linha da matriz
        # linha = linha + [random.randint(-100,100)]
        linha.append(random.randint(1,49)) 
    # insere linha na matriz mat (m = m + [linha])
    mat.append(linha)
# imprime (valores) matriz
print(mat)
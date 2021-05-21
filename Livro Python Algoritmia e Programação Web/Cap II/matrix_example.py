import random
# cria matriz de 9 linhas e 7 colunas (inicializa a 0 todos os valores) 
mat = [[ 0 for i in range(7)] for j in range(9)]
# variável (string) com o alfabeto
alfa = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
# percorre todos os elementos da matriz
for lin in range(9):
    for col in range(7):
        # gera valor aleatorio entre 0 e 25
        pos = random.randrange(0, 25)
        # atribui valor aleatorio (letra do alfabeto)
        mat[lin][col]= alfa[pos]
print (mat)



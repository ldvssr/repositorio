# criar arrays (listas)
# vazio
arrlist1 = []
# array de strings
arrlist2 = ['aBc', 'António Manuel', 'Manuela Maria', 'OOD/OOP']
# array de inteiros
arrlist3 = [5,10,15,20,25,30,35]
# lista com diferentes tipos de dados (valores inteiros, float e strings) 
list4 = ['João','Antónia',27,'X12Y7',23.57,'4050-321', 1024, 2048]
print(arrlist1)
# inserir (e alterar) valores dos arrays
num = 150
for i in range (5):
    arrlist1.append((i+1)*150)
print(arrlist1)
for i in range (5):
    arrlist1[i] = (i*1)*150
print(arrlist1)
for i in range (len(arrlist3)):
    print(i,arrlist3[i],arrlist3[i]*3)
print(list4)

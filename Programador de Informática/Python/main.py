# isto é um comentário
'''isto é um comentario em bloco'''
#ciclo for
'''
for n in range(10):
    print(n, "Daniel")
#lista com 5 elementos
a = [5,23,"Daniel", 47,"Ventura"]
print(a)
#
a.append("Manuela")
print(a)
#
a.remove("Daniel")
#
a.pop(2)
print(a)
#
t=[15,"ab","Maria"]
a.append(t)
print(a)
print(a[4])
print(a[4][2])
x=["brilha","no","escuro"]
t.append(x)
print(a)
#dicionarios
notas={"nome":"antonio","matematica":13,"Portugues":15,"ingles":16}
print(notas['nome'])
print(notas['matematica'])
notas.pop("ingles")
for k, v in notas.items():
    print(k,": ",v)
notas2={"quimica":12}
notas.update(notas2)
for k, v in notas.items():
    print(k,": ",v)
'''
def soma (a=10,b=5):
    return a+b

print(soma())

'''comentario bloco'''
#comentario linha
a = ["manuel", "python", "2021"]
a.append('Joaquim')
a.append(56)
#idade = input("qual a sua idade?")
#a.append(idade)
a.append("dia de sol")
print(a)#imprimir lista
print(a[0])#imprimir primeiro elemento da lista
f = len(a)#verificar o tamanho da lista
print(f)#imprimir o tamanho da lista
print(a[len(a)-1])#imprimir o ultimo elemento da lista
print(a[0])
b = ["conta", "saldo", "350"]
print(b)
a.append(b)
print(a)
print(a[6][2])
a[1] = 'antonio'
print(a)
print('*'*25)
for n in range(0,len(a)):
    print(n, a[n])
a.pop(0)
print(a)
a.remove('antonio')
print(a)
print('*'*25)
c = []
for n in range(0,len(a)):
    c.append(a[n])    
print(c)
movimento = {"descricao":"bilhete para a bola","data":"01-07-2021","valor":100}
d = []
d.append(movimento)
print(d)
print("data",movimento["descricao"])
movimento["data"] = '02-07-2121'
m2 = {"tempo": "5 horas"}
movimento.update(m2)
for k, v in movimento.items():
    print (k, v)
movimento = {"descricao":"gasolina","data":"01-07-2021","valor":10,"saldo":450}
print(movimento)
z = ["helena"]
z = {0:"joaquim"}
print(z)
t=56
t="margarido"
print(t)
e = []
for n in range (2000,3201):
    if n % 7 == 0 and not n % 5 == 0:
        e.append(str(n))
#print(e)
print(", ".join(e))
f = {}
for n in range(1,11):
    f[n] = n*n
f['nome']='margarido'    
print(f)
for k, v in f.items():
    print(k, v)
g = [10, 99, 98, 85, 45, 59, 65, 66, 76, 12, 35, 13, 100, 80, 95]
contador = 0
while contador < len(g):
    if g[contador] > 20 and g[contador] < 60:
        print(g[contador])
    contador += 1
for n in range(0, len(g)):
    if g[n] > 20 and g[n] < 60:
        print(g[n])
print('*'*25)
def quadrado(valor):
    resultado = valor * valor
    return resultado
h=quadrado(5)
print(a)

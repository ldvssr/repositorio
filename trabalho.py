def escreveMedia (soma, numero):
print ("Média = ", soma/numero))
def main():
x = int(input("Insira um número inteiro: "))
s = m
n = 1
m = x
while n < 10 and x > 0:
x = int(input("Insira um número inteiro: "))
if x > m:
m = x
s = s + x
n = n + 1
if n < 10:
print ("Valores lidos: ", (n-1), ", Maior valor: ", m)
else:
escreveMedia (s, n)
if __name__ == '__main__':
main()
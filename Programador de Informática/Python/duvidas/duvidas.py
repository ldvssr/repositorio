'''
for n in range (2, 11, 2):
    print(n, 'X 7 =', 9*n)
print('terminou')

a = 'margarido'
for n in range (len(a)):
    print(n)
print('terminou')

a = 'margarido'
b = 'maria'
for n in range (len(b),len(a)):
    print(n)
print('terminou')

for n in range (10, 0, -1):
    print(n)
print('-'*20)
'''
a = 65
if a < 13:
    print('Criança')
elif a >= 13 and a <= 19:
    print('Adolescente')
elif a > 19 and a <  65:
    print('Adulto')
else:
    print('Idoso')
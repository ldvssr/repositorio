from calculadora import *

c = Calculadora()

print(c.somar(5, 10, 10, 13, 25, 12, 16))

try:
    print(c.dividir(10, 0))
except:
    print("Divisão impossível!")
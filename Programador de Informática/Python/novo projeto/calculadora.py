class Calculadora():

    def somar(self, *a):
        total = 0
        for v in a:
            total += v

        return total

    def subtrair(self, a, b):
        return a - b

    def multiplicar(self, a, b):
        return a * b

    def dividir(self, a, b):
        return a / b
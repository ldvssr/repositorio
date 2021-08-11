class Empregado:
    
    aumento = 1.04

    def __init__(self, nome, ordenado):
        self.nome = nome
        self.ordenado = ordenado

    def get_nome(self):
        return self.nome

    def set_aumento(self):
        self.ordenado *= self.aumento

    def get_ordenado(self):
        return self.ordenado

class Programador(Empregado):

    aumento = 1.1

    def __init__ (self, nome, ordenado, linguagem):
        # Empregado.__init__ (self, nome, ordenado)
        super().__init__(nome, ordenado)
        self.linguagem = linguagem

    def get_linguagem(self):
        return self.linguagem

class Gerente(Empregado):

    aumento = 1.5

    def __init__(self, nome, ordenado, empregados=None):
        super().__init__(nome, ordenado)
        if empregados == None:
            self.empregados = []
        else:
            self.empregados = empregados

    def adicionar_empregado(self, empregado):
        if empregado not in self.empregados:
            self.empregados.append(empregado)
    
    def remover_empregado(self, empregado):
        if empregado in self.empregados:
            self.empregados.remove(empregado)
    
    def listar_empregados(self):
        for empregado in self.empregados:
            print(empregado.get_nome())

    def devolver_empregados (self):
        return self.empregados

emp = Empregado('António', 650)

emp.set_aumento()
print(emp.get_ordenado())

prog1 = Programador('José', 750, 'Python')
print(prog1.get_ordenado())
print(prog1.get_linguagem())

prog2 = Programador('Mariana', 800, 'C++')

ger = Gerente('Cristiana', 1000, [prog1, prog2])
print(ger.get_ordenado())

# ger.adicionar_empregado(prog2)

ger.listar_empregados()

empregados = ger.devolver_empregados()

print('/'*25)

for emp in empregados:
    print(emp.get_nome(), '----', emp)

print(prog1.get_ordenado())
print(prog1.get_ordenado())

prog1.set_aumento()

print(prog1.get_ordenado())

print('*'*25)

print(ger.get_ordenado())
print(ger.get_ordenado())
ger.set_aumento()
print(ger.get_ordenado())

emp3 = Empregado('Marcelo', 700)
emp4 = Empregado('Joaquim', 750)
print(emp3, emp4)


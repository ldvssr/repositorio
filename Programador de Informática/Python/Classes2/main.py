from empregados import *
emp = empregados('Daniel Ventura')
print(emp.get_nome())
emp.set_ordenado(700)
print(emp.get_ordenado())
emp2 = empregados('Licínio Rosário')
print(emp2.get_nome())
emp2.set_ordenado(850)
print(emp2.get_ordenado())

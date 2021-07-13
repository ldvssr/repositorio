from estudante import *
est = estudante('daniel', 1, 'EI')
est.adicionar_cadeiras('matematica')
cadeiras = est.consultar_cadeiras()
print(cadeiras)
est.eliminar_cadeiras('matematica')
print(cadeiras)
estudantes = est.consultar_estudante()
print(estudantes)

#importar as classes do documento conta.py (* = importar tudo)
from estudante import *
#instanciar a classe/construtor criada no ficheiro conta.py com o nome conta
ct = estudante ("Daniel Ventura", 1500, "25-06-2021", "Abertura de Conta", "0001")
#chamadas
ct.movimento ("Compra de Botas", -50, "25-06-2021")

print(ct.get_saldo())

print(ct.get_movimentos())

ct.set_plafond(100)

print(ct.get_plafond())

movimentos = ct.get_movimentos()

for n in range (0, len(movimentos)):
    for k, v in movimentos[n].items():
        print(k, ":", v)
    print ("-"*20)

#ct = conta("Daniel Ventura")
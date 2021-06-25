#importar as classes do documento conta.py (* = importar tudo)
from conta import *
#instanciar a classe/construtor criada no ficheiro conta.py com o nome conta
ct = conta ("Daniel Ventura", 1500, "25-06-2021", "Abertura de Conta", "0001")
#chamadas
ct.movimento ("Compra de Botas", -50, "25-06-2021")
ct.movimento ("Gasolina", -10.34, "26-06-2021")

print(ct.get_saldo())

print(ct.get_movimentos())

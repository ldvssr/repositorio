'''
Criar uma classe conta
- Nome do titular
- Numero da conta
- Valor abertura
- get_titular
- get num_conta
- get_saldo

criar uma classe conta_poupanca
- deposito
- juros

criar uma classe conta_ordem
- depositos
- levantamentos
'''

class Conta:

    def __init__(self, nome_titular, numero_conta, valor_abertura):
        self.nome_titular = nome_titular
        self.numero_conta = numero_conta
        self.valor_abertura = valor_abertura
    
    def get_titular(self):
        return self.nome_titular

    def get_num_conta(self):
        return self.numero_conta

    def get_saldo(self):
        return self.valor_abertura

class ContaPoupanca(Conta):
    def __init__(self, nome_titular, numero_conta, valor_abertura, deposito, juros):
        super().__init__(nome_titular, numero_conta, valor_abertura)
        self.deposito = deposito
        self.juros = juros

class ContaOrdem(Conta):
    def __init__(self, nome_titular, numero_conta, valor_abertura, depositos, levantamentos):
        super().__init__(nome_titular, numero_conta, valor_abertura)
        self.depositos = depositos
        self.levantamentos = levantamentos

cnt = Conta('Daniel', 1, 1500)
cntp = ContaPoupanca
cnto = ContaOrdem

print(cnt.get_titular())
print(cnt.get_num_conta())
print(cnt.get_saldo())


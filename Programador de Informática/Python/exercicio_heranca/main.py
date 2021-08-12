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

class conta:
    def __init__(self, nome, num_conta):
        self.nome = nome
        self.num_conta = num_conta

    def get_num_conta(self):
        return self.num_conta

    def get_titular(self):
        return self.nome

class conta_ordem(conta):
    def __init__(self, nome, num_conta, saldo_ordem):
        super().__init__(nome, num_conta)
        self.saldo = saldo_ordem

    def deposito(self, valor):
        self.saldo += valor

    def levantamento(self, valor):
        if valor <= self.saldo:
            self.saldo -= valor
        else:
            valor = 0

        return valor

    def get_saldo_ordem(self):
        return self.saldo

class conta_poupanca(conta_ordem):
    juros = 0.01

    def __init__(self, nome, num_conta, saldo_ordem, saldo_poupanca):
        super().__init__(nome, num_conta, saldo_ordem)
        self.saldo_poupanca = super().levantamento(saldo_poupanca)

    def get_saldo(self):
        return self.saldo_poupanca

    def transferencia(self, valor):
        self.saldo_poupanca += super().levantamento(valor)

    def calc_juros(self):
        self.saldo_poupanca *= self.juros 

cp = conta_poupanca('Josefina', 12345678, 1000, 100)
print(cp.get_titular())
print('Saldo a prazo: ', cp.get_saldo())
print('Saldo à ordem: ', cp.get_saldo_ordem())
print('-'*25)
cp.transferencia(200)
cp.deposito(150)
print('Saldo a prazo: ', cp.get_saldo())
print('Saldo à ordem: ', cp.get_saldo_ordem())


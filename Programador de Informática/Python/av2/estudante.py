#classes (para cada classe devemos ter um ficheiro)
class estudante:
    #pass (serve para iniciar a classe vazia)
    #construtor __init__
    def __init__(self, nome, saldo, data, descricao, num_conta):        
        #variáveis de classe
        self.nome = nome
        self.saldo = saldo
        self.data_abertura = data
        self.descricao = descricao
        self.num_conta = num_conta
        #criar uma lista vazia
        self.extrato = []
        #criar um dicionário
        movimento = {"Nome do Aluno": descricao, "Movimento": saldo, "Data": data, "Saldo": saldo}
        #juntar o dicionario à lista
        self.extrato.append (movimento)
    #métodos/atributos      
    def movimento (self, descricao, valor, data):
        saldo = self.extrato [len (self.extrato) - 1] ["Saldo"] + valor
        movimento = {"Nome do Aluno": descricao, "Movimento": valor, "Data": data, "Saldo": saldo}
        self.extrato.append (movimento)
    #o self é uma referência à instância da classe/atributo
    def get_movimentos (self):
        return self.extrato
    #o def serve para definir metodos ou funcoes (getters e setters servem para os metodos)
    def get_saldo (self):
        return self.extrato [len (self.extrato) - 1] ["Saldo"]
    #getter e setter
    def set_plafond(self, plafond):
        self.plafond = plafond
    def get_plafond(self):
        return self.plafond
#•	Criar um construtor que recebe o nome, saldo de abertura, data, Nome do Aluno. Criar um nº para a conta.
#•	Criar métodos para inserir movimentos (data, Nome do Aluno valor) e consultar os movimentos e o saldo.
    def movivento(self, descricao, valor, data):
        saldo = self.extrato[len(self.extrato)-1]["saldo"]+valor
        movimento = {"Nome do Aluno":descricao, "movimento":valor, "data":data, "saldo":saldo}
        self.extrato.append(movimento)
        #escrever o cabeçalho no ficheiro caso seja a primeira vez
        

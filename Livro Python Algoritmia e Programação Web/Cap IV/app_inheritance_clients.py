class Cliente:
    # variaveis de classe
    allContacts = []
    cliCount = 0
    volume = 0

    # construtor (inicializador)
    def __init__(self, name, email):
        self.name = name
        self.email = email
        Cliente.cliCount += 1

    def addContact(self, contact):
        Cliente.allContacts.append(contact)

    def displayCount(self):
        print ('Clientes %d' % Cliente.cliCount)

    def displayVolume(self):
        print ('Volume de vendas %d' % self.volume)

    def displayClient(self):
        print ('Nome : ', self.name,  ', email: ', self.email)

class Fornecedor(Cliente):
    # lista de contatos para os fornecedores
    SupplierContacts = []
    
    def encomenda(self, ref, product, qtd, value):
        self.ref = ref
        self.product = product
        self.qtd = qtd
        self.value = value
        Fornecedor.volume += value
        
    def addContact(self, contact):
        Fornecedor.SupplierContacts.append(contact)
        Cliente.allContacts.append(contact)
       
class Parceiro(Cliente):
    pass

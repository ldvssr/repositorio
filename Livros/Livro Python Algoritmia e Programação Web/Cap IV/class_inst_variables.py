class contador:
    # atributos (membro) de classe  
    cont = 0
    soma = 0
    # método construtor (inicializador)
    def __init__(self):
        self.__class__.cont += 1 # aplica atributo __class___

# programa principal (main)

# variaveis (atributos) pre-definidos da classe 
print (contador.__doc__)
print (contador.__name__)
print (contador.__module__)

# atributos da classe
print (contador.cont)
print (contador.soma)

# instancias
c1 = contador()
print(c1.cont)
c1.soma = 25
print(c1.soma)



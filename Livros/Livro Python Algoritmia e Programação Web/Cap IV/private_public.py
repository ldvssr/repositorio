class MyClass:
    """ membros privados vs. publicos """
    __cont = 0 # var privada
    nome = "var de classe publica"

    def myPublicMethod(self):
        print ('... metodo publico')
        
    def __myPrivateMethod(self):
        print ('... metodo privado')
        
    def icount(self):
        self.__cont += 1
        print (self.__cont)

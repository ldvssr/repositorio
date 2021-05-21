# definicao das classes
# student class object
class Student:
    # class methods

    #self sinaliza uma determinada instancia da classe
    def setNameCourse(self, nvalue, cvalue):
        self.name = nvalue
        self.course = cvalue 
        
    #imprime os dados de una determinada instancia    
    def displayNameCourse(self):
        print (self.name)
        print (self.course)

# main program
# criar instancias (instance objects)
i1 = Student()
i2 = Student()

# adicionar dados aos atributos
i1.setNameCourse('Joana Maria', 'Sistemas de Informação')
i2.setNameCourse('Maria Augusta', 'Gestão de Empresas')

# visualizar os dados
i1.displayNameCourse()
i2.displayNameCourse()






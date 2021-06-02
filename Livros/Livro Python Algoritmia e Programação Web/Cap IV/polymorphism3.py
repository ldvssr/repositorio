# super class
class Pessoa:
    def nome(self):
        pass
    def sleep(self):
        print('... everyone needs to sleep, but not everyone ')
        print('needs to sleep the same amount of time')
    def pfunction(self):
        pass

# subclasse aluno
class Aluno(Pessoa):
    # overriding (reescrita dos metodos)
    def nome(self):
        print('I am a student')
    def pfunction(self):
        print('... my main function is to learn')

# subclasse professor
class Professor(Pessoa):
    def nome(self):
        print('I am a lecturer')
    def pfunction(self):
        print('... my main function is to teach')

# class testing
class testStudentLecturer:
    def write_name(self,pes):
        pes.nome()
    def pfunction(self,pes):
        pes.pfunction()
    def sleeping(self,pes):
        pes.sleep()

# main program
# instancias
testPerson = testStudentLecturer()
student = Aluno()
lecturer = Professor()
print ('== Student details ==')
testPerson.write_name(student)
testPerson.pfunction(student)
testPerson.sleeping(student)
print ('== Lecturer details ==')
testPerson.write_name(lecturer)
testPerson.pfunction(lecturer)
testPerson.sleeping(lecturer)














              
              

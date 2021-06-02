# define classe (superclasse)
class superClass1:        
   def sMeth(self):
      print ('... superclass method')

# define classe derivada (subclasse)
class subClass1(superClass1): 
   def sMeth(self):
      print ('... subclass (overriding) method')

# programa principal (instancias)
sup = superClass1()
sub = subClass1() 
# evoca metodo
sup.sMeth()         
# subclasse evoca metodo reescrito
sub.sMeth()         

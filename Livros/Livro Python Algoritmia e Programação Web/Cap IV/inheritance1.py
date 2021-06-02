# definir superclasse
class SuperCl:       
   superAtt1 = 250 # class attribute
   superAtt2 = 750
   def __init__(self):
      print ('Superclass (parent) constructor')

   def superMethod(self):
      print ('Superclass method')

   def setAttr(self, attr1, attr2):
      SuperCl.superAtt3 = attr1
      SuperCl.superAtt4 = attr2

   def getAttr(self):
      print ('Superclass first attribute :', SuperCl.superAtt3)
      print ('Superclass second attribute :', SuperCl.superAtt4)

# definir subclasse
class SubCl(SuperCl):
   def __init__(self):
      print ('Subclass (child) constructor')

   def childMethod(self):
      print ('Child method')

# programa principal (instancias)
# instance of subclass
c = SubCl()          
c.childMethod()
c.superMethod()      
c.setAttr(100,200)   
c.getAttr()         
print (SubCl.superAtt1)
print (SubCl.superAtt2)


# Abrir ficheiro em modo de "append" 
dfile1 = open("notas.txt", "a")
print ("Nome do ficheiro: ", dfile1.name)

str = "Nova linha de texto"
# Escrever a nova linha no final do focheiro
dfile1.seek(0, 2)
line = dfile1.write( "\n" + str )
# fechar ficheiro
dfile1.close()

# Ler o ficheiro desde a primeira linha
dfile1 = open("notas.txt", "r")
dfile1.seek(0,0)

line = dfile1.readline()
index = 1
while line != "":
   print ("Linha %d - %s" % (index, line))
   line = dfile1.readline()
   index = index + 1
   
# Fechar ficheiro
dfile1.close()

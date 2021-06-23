class ficheiros:

    def save (self, *v):
        file = open(r"C:\repositorio\Programador de Informática\Python\ficheiros\myFile", "a")
        texto = ""

        for n in range (0, len(v)):
            texto += v [n]
            if n < len (v) -1:
                texto += ', '
        print(texto)
        file.writelines (texto + '\n')
        file.close ()
    def read (self):
        file = open (r"C:\repositorio\Programador de Informática\Python\ficheiros\myFile", "r")
        for x in file:
            print (x, end = '')
        file.close ()
        print("*"*25)
        with open(r"C:\repositorio\Programador de Informática\Python\ficheiros\myFile") as f:
            for x in f:
                print (x, end='')
    def remove_line (self):
        file = open (r"C:\repositorio\Programador de Informática\Python\ficheiros\myFile", 'r')
        lines = file.readlines()
        
        file.close ()

        del lines[0]

        file = open (r"C:\repositorio\Programador de Informática\Python\ficheiros\myFile", "w+")
        for l in lines:
            file.writelines(l)

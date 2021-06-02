
__author__= "José Braga de Vasconcelos"
__data__=   "May 2014"



import list_functions
def main():
    lklist = []
    x = input("Introduza novo valor: ")
    while (x != ""):
        list_functions.insort(lklist, x)
        x = input("Introduza novo valor: ")
    print (lklist)
main()

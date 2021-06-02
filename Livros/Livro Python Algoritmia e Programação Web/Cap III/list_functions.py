
__author__= "José Braga de Vasconcelos"
__data__=   "May 2014"

def insort(lklist,x):
    #lista vazia
    if not lklist:
        lklist.append(x)
        return

    #primeiro elemento
    if (x <= lklist[0]):
        lklist.insert(0,x)
        return

    # insercao ordenada
    i = 1
    while (i < len(lklist) and lklist[i] <= x):
        i = i + 1
    lklist.insert(i,x)
    return


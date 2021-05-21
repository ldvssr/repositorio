import sys
# leitura da expressao e cria lista / stack vazia
exp = input("Inserir expressao: ")
spar = []
par_abre = "[("
par_fecha = "])"
# para todos os caracteres da expressao
for car in (exp):
    # empilha parentesis abertos
    if (par_abre.find(car) != -1):
        spar.append(car)
    # verifica parentesis fechados
    if (par_fecha.find(car) != -1):
        if spar:
            par = spar.pop()
            # verificar compatibilidade entre parentesis
            if (par_fecha.find(car) != par_abre.find(par)):
                print ("Expressao invalida: parentesis fechado de diferente tipo do parentesis aberto")
                sys.exit(0)
        else:
            print ("Expressao invalida: parentesis fechado sem correspondente parentesis aberto")
            sys.exit(0)
print(spar)
if spar:
    print ("Expressao invalida: parentesis aberto sem correspondente parentesis fechado")
else:
    print ("Expressao valida")

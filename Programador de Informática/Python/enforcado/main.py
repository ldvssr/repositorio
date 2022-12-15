import random



def desenha_topo():
    print('___')

def desenha_cabeca():
    print('|  O')

def desenha_corpo():
    print('| /|\\')

def desenha_pernas():
    print('| / \\')

def forca(tentativas):
    if tentativas == 3:
        desenha_topo()
    elif tentativas == 2:
        desenha_topo()
        desenha_cabeca()
    elif tentativas == 1:
        desenha_topo()
        desenha_cabeca()
        desenha_corpo()
    else:
        desenha_topo()
        desenha_cabeca()
        desenha_corpo()
        desenha_pernas()


palavras = ["autocarro", "automovel", "aviao", "camiao", "motociclo", "ciclomotor", "velocipede", "triciclo"]

palavra = random.choice (palavras)

# print (palavra)

adivinha = []
for n in range(0, len(palavra)):
    adivinha.append("_")

print (adivinha)

corretos = 0

tentativas = 4

while corretos < len (palavra) and tentativas > 0:
    print("correto:", corretos, " ", "tamanho da palavra:", len (palavra))
    letra = input ("escreva uma letra:").lower()
    
    if letra == palavra:
        print (palavra)
        break

    letra = letra [0]
    
    # print (letra)

    existe = False

    for n in range (len (palavra)):
        if palavra[n] == letra and adivinha [n] == '_':
            corretos += 1
            adivinha [n] = letra
            existe = True

    if not existe:
        tentativas -= 1
        forca (tentativas)
    
    print (" ".join(adivinha))

    print ("numero de tentativas restantes:", tentativas)

if (tentativas == 0):
    print ("ultrapassou o numero de tentativas e nao conseguiu adivinhar a palavra")
else:
    print ("ganhou! parabens!")

print ("terminou")

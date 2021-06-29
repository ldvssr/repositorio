import random
palavras = ["autocarro", "automovel", "aviao", "camiao", "motociclo", "ciclomotor", "velocipede", "triciclo"]
palavra = random.choice(palavras)

#print (palavra)

corretos = 0

tentativas = 9

print ("tentativas:",tentativas)

letra = ' '

adivinha = []
	
for n in range(0, len(palavra)):
	adivinha.append("_")

print("a palavra secreta:",adivinha,"tem",len(palavra),"letras.")

adivinha = []


while corretos < len(palavra) and tentativas > 0:

	adivinha = []
	
	#aqui fica o código para o jogador inserir as letras, uma de cada vez.
	
	letra = input( "insira uma letra: " )	

	for n in range(0, len(palavra)):
		
		if palavra[n] == letra:					
			adivinha.append(palavra[n])
			corretos = corretos +1
		elif palavra[n] != letra:
			adivinha.append("_")
	
			
	if palavra[n] != letra:			
		tentativas = tentativas - 1

	print("verifique se a letra introduzida se encontra na lista: ",adivinha)
	
	print("letras corretas: ",corretos)

	print("tentativas restantes: ",tentativas)

print ("parabens a palavra secreta era:",palavra)

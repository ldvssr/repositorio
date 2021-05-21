texto = input("inserir texto: ")
# cria array (lista)
pals = []
# separa palavras do texto e coloca-as no array
pals = texto.split()
print(pals)
# trata cada elemento (palavra) do array
for pal in pals:
    # imprime as palavras com mais do que 5 caracteres
    if len(pal) > 5:
        print(pal)
              

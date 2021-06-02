# ler variavel (alfanumerica)
email = input("Inserir o seu email: ")
# verificar a posicao de '@' na string email
pos_at = email.find("@")
# se existir imprime nome (primeira parte da string email)
if (pos_at != -1):
    nome = email[0:pos_at]
    print ("Olá ",nome, " bem-vindo à linguagem de programação Python")
else:
    print("email incorreto")


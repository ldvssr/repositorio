class metodos:
    def __init__(self):
        self.texto = ''
    def get_string(self):
        self.texto = input('Escreva um texto:')
    def print_string(self):
        print (self.texto.upper())

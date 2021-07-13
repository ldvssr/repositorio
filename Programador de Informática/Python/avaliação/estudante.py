class estudante:
    def __init__ (self, nome_estudante, numero_estudante, nome_curso):
        self.nome_estudante = nome_estudante
        self.numero_estudante = numero_estudante
        self.nome_curso = nome_curso
        self.cadeiras = []
    def adicionar_cadeiras (self, cadeira):
        self.cadeiras.append(cadeira)
    def consultar_cadeiras (self):
        return self.cadeiras
    def eliminar_cadeiras (self,cadeira):
        self.cadeiras.remove(cadeira)
    def consultar_estudante (self):
        return self.nome_estudante, self.numero_estudante, self.nome_curso
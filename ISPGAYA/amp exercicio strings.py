# verificar se a string (palavra) e um palindromo
# com exemplo de docstring
def palindromo( string ):
    '''
        (string) -> boolean
        retorna True se string for um palindromo e
        retorna False em caso contrario
        >>> palindromo( radar )
        True
        >>> palindromo( rodar )
        False
    '''
    string = string.lower()
    if string == string[::-1]:
        return True
    else:
        return False
    
# verificar se e um palindromo - frases completas com
# caracteres de pontuacao: p.e. "Was it a rat I saw?", "Step on no pets"
def palindromoFrase( string ):
    

# contar o numero de ocorrencias de um caracter
def contaOcorrencias( string, c ):
    '''
        (string, char) -> int
        retorna o numero de ocorrencias de um caracter numa string
        >>> contaOcorrencias( "palavra", 'a' )
        3
        >>> contaOcorrencias( "palavra", 'e' )
        0
    '''
    

# indicar a primeira posicao onde ocorre um caracter
def primeiraPosicaoCaracter( string, c ):
    
            
# contar o  numero de espaços
def contaEspacos( string ):
    

# remover espacos da string
def removeEspacos( string ):
    

# remover caracteres nao alfabeticos
def removeNaoAlfabeticos( string ):
    

# escrever a string considerando apenas os caracteres de ordem par (começa em 0)
def ordemPar( string ):
    print( string[::2])

# substituir na string um caracter por outro
def substitui( string, inicial, final ):
    

# escrever os códigos ascii dos caracteres da string
def to_ascii( string ):
    
       
# contar o numero de vogais da string
def contaVogais( string ):
   

# funcao principal
def main():

    
if __name__ == '__main__':
     main()
 
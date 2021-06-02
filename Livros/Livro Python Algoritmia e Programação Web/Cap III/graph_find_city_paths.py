graph1 = {'Porto': ['Aveiro','Amarante','Viseu'],
          'Amarante': ['Porto','Vila Real'],
          'Aveiro': ['Viseu','Coimbra','Porto'],
          'Viseu': ['Porto','Aveiro','Coimbra','Vila Real','Bragança'],
          'Vila Real': ['Amarante','Viseu','Bragança'],
          'Bragança':['Vila Real','Viseu'],
          'Coimbra': ['Aveiro','Leiria','Viseu'],
          'Leiria': ['Coimbra']}

# encontra um caminho entre duas cidades
def find_path(graph1, start, end, path=[]):
        # define caminho (adiciona localidade)
        path = path + [start]
        # partida = destino
        if start == end:
            return path
        # não existe o localidade de partida no grafo (dicionário)
        if not start in graph1:
            return None
        # encontra (recursivamente) um caminho entre a partida e o destino
        for node in graph1[start]:
            if node not in path:
                newpath = find_path(graph1, node, end, path)
                if newpath: return newpath
        return None

# indica todos os caminhos
def find_all_paths(graph1, start, end, path=[]):
        # define caminho
        path = path + [start]
        # partida = destino
        if start == end:
            return [path]
        # não existe o localidade de partida no grafo
        if not start in graph1:
            return []
        # define caminhos de modo recursivo
        paths = []
        for node in graph1[start]:
            if node not in path:
                newpaths = find_all_paths(graph1, node, end, path)
                for newpath in newpaths:
                    paths.append(newpath)
        # devolve a lista de caminhos ao programa principal            
        return paths

# caminho mais curto (shortest path)
def find_shortest_path(graph1, start, end, path=[]):
        path = path + [start]
        if start == end:
            return path
        if not start in graph1:
            return None
        # define (recursivamente) o caminho mais curto
        shortest = None
        for node in graph1[start]:
            if node not in path:
                newpath = find_shortest_path(graph1, node, end, path)
                if newpath:
                    if not shortest or len(newpath) < len(shortest):
                        shortest = newpath
        # devolve o caminho mais curto                
        return shortest

print ("Encontrar um caminho entre Porto e Bragança")
print (find_path(graph1, 'Porto', 'Bragança'))
print ()
print ("Encontrar todos os caminhos entre Porto e Bragança")
print (find_all_paths(graph1, 'Porto', 'Bragança'))
print ()
print ("Encontrar o caminho-mais-curto entre Porto e Bragança")
print (find_shortest_path(graph1, 'Porto', 'Bragança'))



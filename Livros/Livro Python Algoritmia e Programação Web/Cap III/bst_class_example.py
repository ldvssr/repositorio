# definição da classe 'binary tree'
class Tree:  
    def __init__(self, info, left=None, right=None):
        self.info = info
        self.left = left
        self.right = right

    def __str__(self):
        return str(self.info)

# função para a travessia da btree em in-ordem
def print_In_Tree(tree):
    if tree == None:
        return
    print_In_Tree(tree.left)
    print (tree.info),
    print_In_Tree(tree.right)

# inserção ordenada - árvore binária de pesquisa - BST
def bst_insort(tree,y):
    # novo nodo
    new = Tree(y)
    # arvore vazia
    if tree == None:
        return (new)
    
    # insercao ordenada    
    p = tree
    while True:
        # processa subarvore esquerda
        if y <= p.info:
            if p.left == None:
                p.left = new
                return(tree)
            else: p = p.left
        # processa subarvore direita
        elif p.right == None:
            p.right = new
            return(tree)
        else: p = p.right
               
# cria arvore binaria
tree = None

# inserir valores
y = input("Inserir novo valor: (enter para terminar): ")
while (y != ""):
    tree = bst_insort(tree,y)
    y = input("Inserir novo valor: (enter para terminar): ")         
   
# imprinir árvore ordenada (BST)
print ("Travessia em in-ordem: ")
print_In_Tree(tree)






    

    
    
    







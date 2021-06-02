class Tree:  
    def __init__(self, info, left=None, right=None):
        self.info = info
        self.left = left
        self.right = right

    def __str__(self):
        return str(self.info)

def print_Pre_Tree(tree):
    if tree == None:
        return
    print (tree.info),
    print_Pre_Tree(tree.left)
    print_Pre_Tree(tree.right)

def print_In_Tree(tree):
    if tree == None:
        return
    print_In_Tree(tree.left)
    print (tree.info),
    print_In_Tree(tree.right)

def total(tree):
    if tree == None:
       return 0
    return total(tree.left) + total(tree.right) + tree.info

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
               

def bst_insort_wdup(tree,y):

    # arvore vazia
    if tree == None:
        new = Tree(y)
        return (new)
    
    # insercao ordenada    
    p = tree
    q = tree
    while (p != None and y != q.info):
        q = p
        if (y < q.info):
            p = p.left
        else:
            p = p.right
    # insere sem repetidos
    if (y != q.info):
        new = Tree(y)
        if (y < q.info):
            q.left = new
        else:
            q.right = new
    return (tree)
                
    

left = Tree(7)
right = Tree(18)
tree = Tree(5, left, right);

print ("Travessia em pre-ordem: ")
print_Pre_Tree(tree)

print ("Total: ")
x = total(tree)
print (x)


tree = Tree(1, Tree(2, Tree(10),Tree(20)), Tree(3))
print ("Travessia em pre-ordem: ")
print_Pre_Tree(tree)
print
print ("Travessia em in-ordem: ")
print_In_Tree(tree)
print
print ("Total: ")
print (total(tree))

tree = Tree("+", Tree("/", Tree(5), Tree(9)), Tree("*", Tree(2), Tree(3)))
print
print ("Travessia em pre-ordem: ")
print_Pre_Tree(tree)
print

print ("Travessia em in-ordem: ")
print_In_Tree(tree)
print


# cria arvore binaria
tree = None

# inserir valores
y = raw_input("Inserir novo valor: (enter para terminar): ")
while (y != ""):
    tree = bst_insort_wdup(tree,y)
    y = raw_input("Inserir novo valor: (enter para terminar): ")
    
# imprime arvore ordenada
print
print_In_Tree(tree)

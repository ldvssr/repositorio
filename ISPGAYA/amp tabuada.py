def main():

    n = int(input("Insira um número (entre 1 e 10): "))
    while n < 1 and n > 10:
        n = int(input("Insira um número (entre 1 e 10):"))
            
    for m in range( 1, 11 ):
        print( "{0:2} x {1:2} = {2:3}".format( n, m, n*m ))

if __name__ == '__main__':
         main()
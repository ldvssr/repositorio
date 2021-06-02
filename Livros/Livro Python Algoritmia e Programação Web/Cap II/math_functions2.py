import math
# maximo divisor comum
def mdc(n,m):
    if (n < m):
        min = n
    else:
        min = m
    maxdiv = min
    flag = 1
    while (flag == 1):
        r1 = n % maxdiv
        r2 = m % maxdiv
        if (r1 == 0 and r2 == 0):
            flag = 0
        else:
            maxdiv = maxdiv - 1
    return(maxdiv)

# factorial (método recursivo)
def factorial_r(n):
    if n==0: return 1
    return n * factorial_r(n-1)

# factorial (método iterativo)
def factorial_i(n):
    fact = 1 
    for i in range(1,n+1):
        fact = fact * i
    return fact

# numero primo
def primo(n):
    if (n == 1): return (0)
    if (n == 2): return (1)
    i = 2
    while (n%i != 0 and i <= math.sqrt(n)):
        i = i + 1
    if (n%i != 0):
        return (1)
    else:
        return (0)

#
a = "joaquim"
b = ""
for n in range (len(a)-1,-1,-1):
    b += a [n]
print (b)
#
c = "margarido" [::-1]
print (c)
#
d = 0
e = 0
valores = [23, 47, 82, 65, 98, 31, 92, 56]
for n in range (0, len(valores)):
    e += valores [n]
    d = d + 1
print (d)
print (e)
print (e/d)
#
print (sum(valores)/len(valores))
#
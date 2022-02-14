'''
a = ""
input(a)
print(a)
'''

def ax():
	a = input("\nQual o seu genero(F/M)? ")
	while (a != 'F' and a != 'f' and a != 'M' and a != 'm'):
		a = input("\nQual o seu genero(F/M)? ")
		print("\n")
	return a

def bx():
	x = float(input("\nQual o seu peso? "))
	while (x < 40.0 and x > 300.0):
		x = float(input("\nQual o seu peso? "))		
	return x

def cx():
	y = float(input("\nQual a sua altura? "))
	while (y < 0.9 and y > 2.3):
		y = float(input("\nQual a sua altura? "))
	return y

def ay(a, z):

	if (a == 'M' or a == 'm'):
		if (z < 20):
			print("\nAbaixo do peso!\n")
		elif (z < 25):
			print("\nPeso Normal\n")
		elif (z < 30):
			print("\nAcima do Peso!\n")
		else:
			print("\nObesidade!\n")
	


def by(a, z):

	if (a == 'F' or a == 'f'):
	
		if (z < 19):
			print("\nAbaixo do peso!\n")
		elif (z < 24):
			print("\nPeso Normal\n")
		elif (z < 30):
			print("\nAcima do Peso!\n")
		else:
			print("\nObesidade!\n")
	



a = ''
x = 0.0
y = 0.0
z = 0.0


a = ax()
y = bx()
y = cx()

z = x / (y * y)

if (a == 'M' or a == 'm'):
	ay(a, z)
else:
	by(a, z)
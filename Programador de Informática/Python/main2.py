def getDay(dia):
        if (dia == 0):
            return "DOM"
        elif (dia == 1):
            return "SEG"
        elif (dia == 2):
            return "TER"
        elif (dia == 3):
            return "QUA"
        elif (dia == 4):
            return "QUI"
        elif (dia == 5):
            return "SEX"
        elif (dia == 6):
            return "SAB"
        else:
            return ""

dia = getDay(3)
print(dia)

for n in range(1,11,2):
    print(n)

carros = ["renault","opel","lancia","citroen"]
for carro in carros:
    print(carro)

i = 1
while i < 10:
    print(i)
    i+=1


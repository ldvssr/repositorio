# frequencia absoluta de letras e digitos
# cria arrays (listas) e inicializa elementos a zero
freq = []
freq_n = []
for i in range(26):
    freq.append(0)
for i in range(10):
    freq_n.append(0)
text = input("Insert text: ")
text = text.lower()
print("\n",text)
alfa = "abcdefghijklmnopqrstuvwxyz"
digit = "0123456789"
# trata caracter a caracter do texto
for c in (text):
    pos = alfa.find(c)
    if (pos != -1):
        freq[pos] = freq[pos] + 1
    pos_n = digit.find(c)
    if (pos_n != -1):
        freq_n[pos_n] = freq_n[pos_n] + 1
# resultados (letras e digitos)
for i in range (len(alfa)):
    print (alfa[i], freq[i])    
for i in range (len(digit)):
    print (digit[i], freq_n[i])

1.1	(Duas possíveis soluções)
#define Val_Iva(Ordenado)  (((Ordenado) <10000) ? \
				   ((Ordenado)*TAXA_IVA1/100.0) : \
				   ((Ordenado)*TAXA_IVA2/100.0))

#define Val_Iva(Ordenado)  \
  ((Ordenado)*(((Ordenado) <10000) ? TAXA_IVA1 : TAXA_IVA2)/100.0)



1.2 
main()
{
int x,y=2;
printf("\nOrdenado=%f", (((x+y) <10000) ? ((x+y)*5/100.0) : ((x+y)*17/100.0)));


3. a)
#define ZAP(x,v1,v2) (((x)<=0) ? (x)*(v1) : (x)*(-(v2)))

b)
main()
{
int i,j = (int) 'a';
i = (((i+j)<=0) ? (i+j)*(43-1) : (i+j)*(-(-1-1)));
}

4.2
#define toupper(ch) ((ch)>='a' && (ch)<='z' ? (ch) + 'A' - 'a' : (ch))

4.3 
main()
{
int ch=65; 
printf("%c %c", (('A'+2)>='a' && ('A'+2)<='z' ? ('A'+2) + 'A' - 'a' : ('A'+2)),(('Z'+'a'-ch)>='a' && ('Z'+'a'-ch)<='z' ? ('Z'+'a'-ch) + 'A' - 'a' : ('Z'+'a'-ch)));
}

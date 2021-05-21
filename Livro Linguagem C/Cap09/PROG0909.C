#include <stdio.h>


unsigned fact(int n)
{
	if (n==0)  /* Critério de Paragem */
   return 1;
	else
   return n*fact(n-1); /* Chamada Recursiva */

}

main()
{
int k;
while (scanf("%d",&k)) /* Enquanto ler números */
  printf("%d! = %u\n",k,fact(k));
}

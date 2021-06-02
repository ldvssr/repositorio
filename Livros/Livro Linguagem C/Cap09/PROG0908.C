#include <stdio.h>


unsigned fact(int n)
{
	unsigned i,
	res=1; /* Pois vamos realizar multiplicações */
	for (i=1;i<=n;i++)
		res*=i;    /* res = res * i */
	return res;
}

main()
{
int k;
while (scanf("%d",&k))   /* Enquanto Introduzir números */
  printf("%d! = %u\n",k,fact(k));
}

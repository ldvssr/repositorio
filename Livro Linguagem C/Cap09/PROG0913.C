#include <stdio.h>

long int Fib_Rec(int n)
{
	if (n<0) return -1L; /* Parâmetro Inválido */
	if (n<=1)
		return 1L;
	else
		return Fib_Rec(n-1)+Fib_Rec(n-2);
}

long int Fib_Ite(int n)
{
	int i;
	long n1,n2,tmp;
	if (n<0) return -1L; /* Parâmetro Inválido */
	if (n<=1)	return 1L;
	for (i=2,n1=n2=1 ; i<n ; i++)
		{ tmp = n1;
			n1 = n2;
			n2 = n1+tmp;
		}
	return n1+n2;
}
main()
{
int n;
	do
		{
			printf("Introd. um inteiro: ");
			scanf("%d",&n);
			printf("Fib_Ite(%d) = %ld\n",n, Fib_Ite(n));
			printf("Fib_Rec(%d) = %ld\n",n, Fib_Rec(n));
		}
  while (n>0);
}

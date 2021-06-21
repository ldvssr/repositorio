#include <stdio.h>

void inic(int s[])
{
	int i;
	for(i=0;i<10;i++)
		s[i]=0;
}

main()
{
	int v[10], i;

	inic(v);

	for(i=0;i<10;i++)
		v[i]=i;

	for(i=10-1;i>=0;i--)
	  printf("%d\n",v[i]); 
}


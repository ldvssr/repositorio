#include <stdio.h>

const int num = 10;

void inic(int s[])
{
	int i;
	for(i=0;i<num;i++)
		s[i]=0;
}

main()
{
	int v[num], i;

	inic(v);

	for(i=0;i<num;i++)
		v[i]=i;

	for(i=num-1;i>=0;i--)
	  printf("%d\n",v[i]); 
}

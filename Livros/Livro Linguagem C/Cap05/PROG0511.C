#include <stdio.h>

float Pot(float x, int n)
{
	float res;
	int i;

	for (i=1,res=1.0 ; i<=n ; i++)
	  res*=x; 			/* res = res * x; */

	return res;
}

main()
{
  printf("%f %f %f", Pot(2.0,4), Pot(1.234,3), Pot(3.0,0));
}

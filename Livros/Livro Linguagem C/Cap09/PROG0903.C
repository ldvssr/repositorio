#include <stdio.h>


void Calc(float *v , int num ,float * xmin , float *xmax)
{
  int i;
  *xmin = *xmax = *v; 	/* Ficam com o valor de v[0] */
  for (i=0 ; i<num ; i++)
    {
		if (v[i]<*xmin) *xmin=v[i];
		if (v[i]>*xmax) *xmax=v[i];
	}
}

main()
{
  float Vector[] = {10,20,30,40,50,11,12,5,-33};
  float Maior, Menor;

  Calc(Vector, 9, &Menor, &Maior);

  printf("Maior Elemento %f\n Menor Elemento %f\n",Maior,Menor); 
}

#include <stdio.h>
/* iFile.c */

static void Troca(int *a,int *b)
{
  int tmp=*a;
  *a=*b;
  *b=tmp;
}

static void Ordena(int *v)
{
  int alterou,i;
  do
	 {
	  for (alterou=i=0;v[i]!=0;i++)
		 if (v[i]>v[i+1] && v[i+1]!=0)
			{
			  Troca(&v[i],&v[i+1]);
			  alterou=1;
			}
	 }
  while (alterou);
                             
}
void iImprime_ordenado(int *v)
{ int i;
  Ordena(v);
  puts("Imprimir Inteiros");
  puts("-----------------");

  for (i=0;v[i]!=0;i++)
	 printf("%d\n",v[i]);
}

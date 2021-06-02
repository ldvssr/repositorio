#include <stdio.h> 		/* Por causa do NULL */
/* princ.c */

void  iImprime_ordenado(int *);
void  sImprime_ordenado(char **);
main()
{
  int inteiros[]={2,5,7,3,0};
  char *strings[]={"odio","felicidade","amor","choro",NULL};
  iImprime_ordenado(inteiros);
  sImprime_ordenado(strings);
}

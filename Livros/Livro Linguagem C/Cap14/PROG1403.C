 #include <stdio.h>

struct Est
{
  char   c;
  int    n;
  float  x;
};

union Uni
{
  char   c;
  int    n;
  float  x;
};


main(void)
 {
 printf("Dimensao da Estrutura: %d\n",sizeof(struct Est));
 printf("Dimensao da Uniao: %d\n",sizeof(union Uni));

 }

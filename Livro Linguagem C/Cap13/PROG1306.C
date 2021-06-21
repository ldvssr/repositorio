#include <stdio.h>

main()
{
  printf("Estou na Linha %d\n",__LINE__);
  printf("Estou na Linha %d\n",__LINE__);

#line 8000
  printf("Estou na Linha %d\n",__LINE__);
  printf("Estou na Linha %d\n",__LINE__);
}


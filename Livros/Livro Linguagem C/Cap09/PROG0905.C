#include <stdio.h>

main(int argc, char *argv[])
{
int i;
for (i=0;i<argc;i++)
  printf("%d- Parâmetro = \"%s\"\n",i+1,argv[i]);

}

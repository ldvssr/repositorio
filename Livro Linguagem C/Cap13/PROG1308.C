#include <stdio.h>

main()
{

printf("Ficheiro: %s\n",__FILE__);
printf("Data    : %s\n",__DATE__);
printf("Hora    : %s\n",__TIME__);
printf("Linha   : %d\n",__LINE__);
#line 1234
printf("Linha   : %d\n",__LINE__);

}

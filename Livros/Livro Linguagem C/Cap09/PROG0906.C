#include <stdio.h>
#include <stdlib.h>

main(int argc, char **argv)
{
int i,total;
for (i=1, total=0 ; i<argc  ; i++) /* Todos excepto o argv[0] */
	 total+=atoi(argv[i]);		  /* Acumular os Valores     */
printf("%d\n",total);
}

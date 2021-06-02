#include <stdio.h>

main()
{
float  quilos = 1.0E3; /* Uma tonelada sao 1000 quilos */
double gramas = 1.0e6; /* Uma tonelada sao 1,000,000 gramas */
float n_toneladas;

printf("Quantas toneladas comprou: "); scanf("%f", &n_toneladas);
printf("Nº de Quilos = %f  = %e\n",n_toneladas * quilos, 
					n_toneladas * quilos);
printf("Nº de gramas = %f  = %E\n", n_toneladas * gramas, 
					 n_toneladas * gramas);
}

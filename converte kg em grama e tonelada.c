#include <stdio.h>

main()

{

float quilo = 1.0E3; /* Uma tonelada sao 1000 quilo */
double grama = 1.0e6; /* Uma tonelada sao 1000000 grama */

float n_tonelada;

printf (" Quantas tonelada comprou? \n");
scanf ("%f",&n_tonelada);
printf (" Nº de quilo = %f = %e\n",n_tonelada * quilo,n_tonelada * quilo);
printf (" Nº de grama = %f = %E\n",n_tonelada * grama,n_tonelada * grama);

}
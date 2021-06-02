#include <stdio.h>

main()
{
int x = 5;
int * ptr_x;				/* Apontador para x */
int ** ptr_ptr_x;		/* Apontador para o Apontador de x */

/* Inicialização dos apontadores */

ptr_x = &x;
ptr_ptr_x = &ptr_x;

printf("x = %d - &x = %ld\n",x, &x);
printf("x = %d - &x = %ld\n",*ptr_x, ptr_x);
printf("x = %d - &x = %ld\n",**ptr_ptr_x, *ptr_ptr_x);

}

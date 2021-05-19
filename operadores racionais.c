/**********************************************
* Operadores Racionais:  operadores racionais *
* Autor:                       Daniel Ventura *
* Data:                            17/06/2019 *
**********************************************/

#include <stdio.h>

main()

{
int x, y;
printf("introduza dois valores: \n");
scanf("%d%d",&x,&y);
printf("o resultado de %d == %d : %d \n",x ,y, x == y);
printf("o resultado de %d >  %d : %d \n",x ,y, x >  y);
printf("o resultado de %d >= %d : %d \n",x ,y, x >= y);
printf("o resultado de %d <  %d : %d \n",x ,y, x <  y);
printf("o resultado de %d <= %d : %d \n",x ,y, x <= y);
printf("o resultado de %d != %d : %d \n",x ,y, x != y);
}
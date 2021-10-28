/**********************************************
* Imposto:  Calcula o imposto sobre o salario *
* Autor:                       Daniel Ventura *
* Data:                            14/06/2019 *
**********************************************/

#include <stdio.h>

main()

{

float salario;
printf ("qual o salario: ");
scanf ("%f",&salario);
if (salario<=0)
	printf ("salario: valor invalido introduzido\n");
else
	if (salario>=700)
		printf ("imposto de 20 %% = %.2f\n", salario*0.20);
	else
		if (salario<500)
			printf ("imposto de 10 %% = %.2f\n", salario*0.10);
		else
			printf ("imposto de 15 %% = %.2f\n", salario*0.15);

}
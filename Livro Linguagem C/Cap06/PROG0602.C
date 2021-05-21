#include <stdio.h>

main()
{
	float sal[13];  /* índice 0 + 12 meses */
	float total;
	int i;

	for (i=1; i<=12 ; i++)
		{
			printf("Introd. o salário do mes %d:",i);
			scanf("%f",&sal[i]);
		}

 /* Mostrar os valores Mensais e calcular o total */
	puts(" Mes       Valor ");
	for (i=1, total=0.0 ; i<=12 ; i++)
		{
			printf(" %3d     %9.2f\n",i,sal[i]);
			total+=sal[i];
		}

	printf("Total Anual: %9.2f\n",total);
}


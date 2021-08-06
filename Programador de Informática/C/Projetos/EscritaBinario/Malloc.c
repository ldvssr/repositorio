/*
Nome: Aloca��o de mem�ria
Autor: Daniel Ventura
Data: 06/08/2021
Descri��o: Perceber o porqu� de aloca��o de mem�ria com malloc.
*/
#include <stdio.h>
#include <stdlib.h>
#pragma warning(disable:4996)
int main3()
{
	int* ptr;
	int array[9];
	int n, i;
	printf("\nIntroduza o n�mero de elementos ");
	scanf("%d", &n);
	printf("\nN�mero de elementos: %d", n);
	ptr = (int*)malloc(n * sizeof(int));
	if (ptr == NULL)
	{
		printf("\nMem�ria n�o alocada");
	}
	else
	{
		printf("\nMem�ria alocada corretamente com a fun��o malloc");
		for(i=0;i<n;i++)
		{
			ptr[i] = i + 1;
		}
		printf("\nOs elementos do array s�o: ");
		for (i = 0; i < n; i++)
		{
			printf("%d", ptr[i]);
		}
	}
	getche();
	return 0;
}
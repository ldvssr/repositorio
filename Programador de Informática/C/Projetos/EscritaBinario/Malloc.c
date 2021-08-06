/*
Nome: Alocação de memória
Autor: Daniel Ventura
Data: 06/08/2021
Descrição: Perceber o porquê de alocação de memória com malloc.
*/
#include <stdio.h>
#include <stdlib.h>
#pragma warning(disable:4996)
int main3()
{
	int* ptr;
	int array[9];
	int n, i;
	printf("\nIntroduza o número de elementos ");
	scanf("%d", &n);
	printf("\nNúmero de elementos: %d", n);
	ptr = (int*)malloc(n * sizeof(int));
	if (ptr == NULL)
	{
		printf("\nMemória não alocada");
	}
	else
	{
		printf("\nMemória alocada corretamente com a função malloc");
		for(i=0;i<n;i++)
		{
			ptr[i] = i + 1;
		}
		printf("\nOs elementos do array são: ");
		for (i = 0; i < n; i++)
		{
			printf("%d", ptr[i]);
		}
	}
	getche();
	return 0;
}
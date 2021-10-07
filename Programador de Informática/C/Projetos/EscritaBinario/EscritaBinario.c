/*
Nome:
Autor: Daniel Ventura
Data: 06/08/2021
Descrição:
*/
#include <stdio.h>
#pragma warning(disable:4996)
int main2()
{
	FILE* af;
	char* nomeFicheiro = "temperaturas.dat";
	int nescritos, i;
	double temperaturas[7];
	for (i = 0; i < 7; i++)
	{
		printf("\nTemperatura do dia %d", i + 1);
		scanf("%lf", &temperaturas[i]);
	}
	af = fopen(nomeFicheiro, "w");
	if (af == NULL)
	{
		printf("Ocorreu um erro meu caro");
	}
	else
	{
		nescritos = fwrite(&temperaturas[0], sizeof(double), 7, af);
		if (nescritos == 0) printf("Não foi escrito nenhum elemento");
		else
		{
			if (nescritos < 7)
			{
				printf("Faltam %d temperaturas gravadas", 7 - nescritos);
			}
		}
	}
	fclose(af);
	getche();
	return 0;
}
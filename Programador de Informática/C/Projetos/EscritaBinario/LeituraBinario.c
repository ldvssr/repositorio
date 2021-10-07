/*
Nome: 
Autor: Daniel Ventura
Data: 06/08/2021
Descrição: 
*/
#include <stdio.h>
#pragma warning(disable:4996)
int main()
{
	FILE* af;
	char* nomeFicheiro = "temperaturas.dat";
	int nLidos, i;
	double temperaturas[7];
	af = fopen(nomeFicheiro, "rb");
	if (af == NULL)
	{
		printf("Erro a abrir o ficheiro %s", nomeFicheiro);
	}
	else
	{
		nLidos = fread(&temperaturas[0], sizeof(double), 7, af);
		if (nLidos < 7)
		{
			printf("\nLidos apenas %d elementos", nLidos);
		}
		for (i = 0; i < nLidos; i++)
		{
			printf("\ntemperaturas[%d] = %.3f\n", i, temperaturas[i]);
		}	
		fclose(af);
	}
	getche();
	return 0;
}
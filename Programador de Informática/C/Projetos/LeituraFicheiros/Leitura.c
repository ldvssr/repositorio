/*
Autor: Daniel Ventura
Data: 04/08/2021
Email: ldvssr@icloud.com
Descrição: Programa para leitura
Obs: Programa que permite a leitura de ficheiro caracter a caracter.
*/
#include <stdio.h>
#pragma warning (disable:4996)
int main ()
{
	FILE* af;//apontador para descritor de ficheiro
	char c;
	int nLinhas = 1;
	//abrir ficheiro em modo leitura (r)
	af = fopen("a.txt", "r");
	//testar se ocorreu um erro ao abrir o ficheiro
	if (af == NULL)
	{
		printf("Ocorreu um erro meu caro");
	}
	else
	{
		printf("Sucesso na abertura de ficheiro a.txt\n");
		//leitura de ficheiro caracter a caracter
		c = fgetc(af);
		printf("%d: ", nLinhas);
		nLinhas++;
		while (c != EOF)
		{
			printf("%c", c);
			if (c == '\n')
			{
				printf("%d: ", nLinhas);
				nLinhas++;
			}
			//como é apontador ele faz track do último caracter que foi lido e lê o próximo
			c = fgetc(af);			
		}
		fclose(af);
	}
	getche();
	return 0;
}
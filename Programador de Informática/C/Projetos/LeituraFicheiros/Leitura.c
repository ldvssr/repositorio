/*
Autor: Daniel Ventura
Data: 04/08/2021
Email: ldvssr@icloud.com
Descri��o: Programa para leitura
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
			//como � apontador ele faz track do �ltimo caracter que foi lido e l� o pr�ximo
			c = fgetc(af);			
		}
		fclose(af);
	}
	getche();
	return 0;
}
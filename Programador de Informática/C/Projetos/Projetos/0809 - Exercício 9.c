/*
autor: Daniel
data: 13-07-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 9 - 
obs:
*/
//Inclusão de bibliotecas.
#include <stdio.h>
#include <time.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Região main.
#pragma region Main
//Programa principal.
int main9()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Utilizar apenas uma vez.
	srand(time(NULL));
	//Declaração de Variáveis.
	int i = 0, j = 0;
	int matriz[4][6];
	//Introdução ao programa.
	printf("Este programa .\n");
	//Estrutura do programa.
	for (i = 0; i < 4; i++)
	{
		for (j = 0; j < 3; j++)
		{
			printf("matriz [%d] [%d] = %d\n", i, j, matriz[i][j]=rand()%55);
		}
	}
	//Para parar no final.
	getchar();
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Fim da região main.
#pragma endregion
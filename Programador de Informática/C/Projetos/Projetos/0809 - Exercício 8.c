/*
autor: Daniel
data: 09-07-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 8 - Vetores
obs:
*/
//Defenição de constante.
#define TAMANHO_DO_VETOR 8
//Inclusão de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Região main.
#pragma region Main
//Programa principal.
int main()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Declaração de Variáveis.
	int vetor[TAMANHO_DO_VETOR];
	int vetor2[50];
	int vetor3[50];
	int vetor4[50];
	int i = 0;
	int j = 0;
	int controlo = 0;
	////Introdução ao programa.
	//printf("Este programa pede para introduzir oito valores inteiros.\n");
	////
	//for (i = 0; i < TAMANHO_DO_VETOR; i++)
	//{
	//	printf("\nIntroduza um valor inteiro: ");
	//	scanf(" %d", &vetor[i]);
	//}
	//printf("\nOs valores inteiros introduzidos foram:");
	//for (i = 0; i < TAMANHO_DO_VETOR; i++)
	//{
	//	printf(" %d", vetor[i]);
	//}
	//printf("\n");
	//printf("\n");
	////Introdução ao programa.
	//printf("Este programa pede para introduzir n valores inteiros.\n");
	////
	//printf("\nIntroduza a quantidade de vezes a introduzir valores: ");
	//scanf(" %d", &controlo);
	//for (j = 0; j < controlo; j++)
	//{
	//	printf("\nIntroduza um valor inteiro: ");
	//	scanf(" %d", &vetor2[j]);
	//}
	//printf("\nOs valores inteiros introduzidos na ordem inversa foram:");
	//for (j = controlo-1; j >= 0; j--)
	//{
	//	printf(" %d", vetor2[j]);
	//}
	//printf("\n");
	//Introdução ao programa.
	printf("Este programa pede para introduzir n valores inteiros.\n");
	//
	printf("\nIntroduza a quantidade de vezes a introduzir valores: ");
	scanf(" %d", &controlo);
	for (j = 0; j < controlo; j++)
	{
		printf("\nIntroduza um valor inteiro: ");
		scanf(" %d", &vetor3[j]);
	}
	printf("\nOs valores inteiros introduzidos foram:");
	for (j = 0; j < controlo; j++)
		{
			vetor4[j] = vetor3[j];			
		}
	printf("\n");
	for (j = 0; j < controlo; j++)
	{
		printf(" %d", vetor3[j]);
	}
	printf("\n");
	for (j = 0; j < controlo; j++)
	{
		printf(" %d", vetor4[j]);
	}	
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Fim da região main.
#pragma endregion
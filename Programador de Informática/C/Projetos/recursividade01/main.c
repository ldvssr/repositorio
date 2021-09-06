/*
* Autor: Daniel Ventura
* Data: 03/09/2021
* Observa��es: Cria��o de uma fun��o recursiva
* Descri��o: Ficheiro .c em que iremos testar o fatorial
*/
#include<stdio.h>
#pragma warning(disable: 4996)
//Assinatura da fun��o fatorial/recursiva
int fatorial(int numero);
//Fun��o main que ir� conter chamada � fun��o recursiva
int main1()
{
	int num, fact;
	printf("Programa de fatorial");
	printf("\nInsira um numero ");
	scanf("%d", &num);
	fact = fatorial(num);
	printf("\nO fatorial do numero: %d = %d", num, fact);
	return 0;
}
int fatorial(int numero)
{
	if (numero == 1) return 1;
	else return(numero * fatorial(numero - 1));
}
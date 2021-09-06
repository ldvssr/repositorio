/*
* Autor: Daniel Ventura
* Data: 03/09/2021
* Observações: Criação de uma função recursiva
* Descrição: Ficheiro .c em que iremos testar o fatorial
*/
#include<stdio.h>
#pragma warning(disable: 4996)
//Assinatura da função fatorial/recursiva
int fatorial(int numero);
//Função main que irá conter chamada à função recursiva
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
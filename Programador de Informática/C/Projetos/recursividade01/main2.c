/*
* Autor: Daniel Ventura
* Data: 03/09/2021
* Observações: Criação de uma função recursiva
* Descrição: Ficheiro .c em que iremos testar o somatório de numeros
* Fazer uma função recursiva que calcula a soma de tosos os numero de 1 a N
* Por exemplo se N é igual a 5 então a soma dos numero será = 5+4+3+2+1=15;
*/
#include<stdio.h>
#pragma warning(disable: 4996)
//Assinatura da função
int somatorio(int num);

int main2()
{
	int num, soma;
	printf("\nInsira um numero ");
	scanf("%d", &num);
	soma = somatorio(num);
	printf("\nO somatorio do numero: %d = %d", num, soma);
}
int somatorio(int num)
{
	//Variavel que armazena valor final do resultado
	int resultado = 0;
	if (num == 1) return 1;
	else
	{
		resultado = num + somatorio(num - 1);
	}
	return resultado;
}
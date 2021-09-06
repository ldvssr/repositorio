/*
* Autor: Daniel Ventura
* Data: 03/09/2021
* Observa��es: Cria��o de uma fun��o recursiva
* Descri��o: Ficheiro .c em que iremos testar o somat�rio de numeros
* Fazer uma fun��o recursiva que calcula a soma de tosos os numero de 1 a N
* Por exemplo se N � igual a 5 ent�o a soma dos numero ser� = 5+4+3+2+1=15;
*/
#include<stdio.h>
#pragma warning(disable: 4996)
//Assinatura da fun��o
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
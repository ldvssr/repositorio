/*
* Autor: Daniel Ventura
* Data: 03/09/2021
* Observações: Criação de uma função recursiva
* Descrição: Ficheiro .c em que iremos testar as potencias de numeros
* sendo que uma potencia é definida por uma base e um expoente.
* 
* a base sendo A e o expoente sendo B sendo que por exemplo 2 ^ 3 = 8;
*/
#include<stdio.h>

#pragma warning(disable: 4996)

//Assinatura da função recursiva
float potencia(float base, float expoente);

int main()
{
	float a, b, resultado;
	printf("\nIntroduza a base da potencia: ");
	scanf("%f", &a);
	printf("\nIntroduza o expoente da potencia: ");
	scanf("%f", &b);
	//chama função
	resultado = potencia(a, b);
	//imprimir resultado de função e os valores de base e expoente
	printf("\nO valor de a: %f o valor de b: %f e o valor total: %f ", a, b, resultado);
	return 0;
}
float potencia(float base, float expoente)
{
	//condição de paragem sendo que qualquer valor elevado a 0 é igual a 1
	if (expoente == 0) return 1;
	if (expoente > 0)
	{
		return (base * potencia(base, expoente - 1));
	}
	if (expoente < 0)
	{
		return (1 / potencia(base, -expoente));
	}

}
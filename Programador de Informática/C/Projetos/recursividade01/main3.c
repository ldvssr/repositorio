/*
* Autor: Daniel Ventura
* Data: 03/09/2021
* Observa��es: Cria��o de uma fun��o recursiva
* Descri��o: Ficheiro .c em que iremos testar as potencias de numeros
* sendo que uma potencia � definida por uma base e um expoente.
* 
* a base sendo A e o expoente sendo B sendo que por exemplo 2 ^ 3 = 8;
*/
#include<stdio.h>

#pragma warning(disable: 4996)

//Assinatura da fun��o recursiva
float potencia(float base, float expoente);

int main()
{
	float a, b, resultado;
	printf("\nIntroduza a base da potencia: ");
	scanf("%f", &a);
	printf("\nIntroduza o expoente da potencia: ");
	scanf("%f", &b);
	//chama fun��o
	resultado = potencia(a, b);
	//imprimir resultado de fun��o e os valores de base e expoente
	printf("\nO valor de a: %f o valor de b: %f e o valor total: %f ", a, b, resultado);
	return 0;
}
float potencia(float base, float expoente)
{
	//condi��o de paragem sendo que qualquer valor elevado a 0 � igual a 1
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
/*
Nome: Apontadores para apontadores
Autor: Daniel Ventura
Data: 06/08/2021
Descri��o: Verificar o que s�o apontadores para apontadores
*/
#include <stdio.h>
#include <stdlib.h>
#pragma warning(disable:4996)
int main4()
{
	int var;//inteiro
	int* ptr;//apontador para um inteiro
	int** pptr;//apontador para um apontador de um inteiro
	var = 5000;
	ptr = &var;
	pptr = &ptr;
	printf("\nO valor de var: %d", var);
	printf("\nO valor dispon�vel em ptr: %d", *ptr);
	printf("\nO valor dispon�vel em pptr: %d", **pptr);
	getche();
	return 0;
}
/*
* Autor: Licínio Daniel 
* Data: 06 de setembro de 2021
* Versão: 1.0
* E-mail: ldvssr@icloud.com
* Descrição: Trabalho Cartão Matriz
* Observações: 
*/
#include "header.h"
#pragma warning (disable: 4996)
#pragma region Main
int main()
{
	setlocale(LC_ALL, "Portuguese");
	int a, b;
	printf("\n\tEste programa realiza a soma entre dois números. ");
	printf("\n");
	printf("\n\tNúmero a: ");
	scanf("%d", &a);
	printf("\n\tNúmero b: ");
	scanf("%d", &b);
	printf("\n\tA soma de %d com %d é igual a: %d ", a, b, soma(a,b));
	printf("\n");
}
#pragma endregion

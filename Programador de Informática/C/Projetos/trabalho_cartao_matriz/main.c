/*
* Autor: Lic�nio Daniel 
* Data: 06 de setembro de 2021
* Vers�o: 1.0
* E-mail: ldvssr@icloud.com
* Descri��o: Trabalho Cart�o Matriz
* Observa��es: 
*/
#include "header.h"
#pragma warning (disable: 4996)
#pragma region Main
int main()
{
	setlocale(LC_ALL, "Portuguese");
	int a, b;
	printf("\n\tEste programa realiza a soma entre dois n�meros. ");
	printf("\n");
	printf("\n\tN�mero a: ");
	scanf("%d", &a);
	printf("\n\tN�mero b: ");
	scanf("%d", &b);
	printf("\n\tA soma de %d com %d � igual a: %d ", a, b, soma(a,b));
	printf("\n");
}
#pragma endregion

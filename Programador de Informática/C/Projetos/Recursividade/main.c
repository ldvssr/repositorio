/*



*/
#include<stdio.h>
#pragma warning(disable: 4996)
int fatorial(int numero);
int main()
{
	int num, fact;
	printf("Programa de fatorial");
	printf("\nInsira um numero");
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
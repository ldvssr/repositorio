/*
autor: Daniel
data: 30-06-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 3
obs:
	-	Exercicio 3: Peça ao utilizador um numero, se o numero for maior que 10 o programa deve apitar e imprimir a seguinte mensagem de errro, caso seja inferior, deve mostrar o numero inserido multiplicado por PI, deverá definir este valor como constante.
*/
//Inclusão de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Constante (Variável global)
#define PI 3.14
//Região Main.
#pragma region Main
//Programa principal.
int main3()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Declaração de variáveis.
	float a = 0;
	//Input e output.
	printf("\n\tEste programa verifica se um número é maior ou menor que 10.\n");
	printf("\n\tIntroduza um número: ");
	scanf("%f", &a);
	//Operação.//Resposta.
	if (a >= 10)
	{
		printf("\n\t\7ERRO!\n\n\t");
	}
	else
	{
		printf("\n\tO número introduzido múltiplicado por PI é igual a: %f\n\n\t", a*PI);
	}	
	//Para o programa não fechar automáticamente solicitamos um input ao utilizador.
	getche();
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
#pragma endregion
/*
autor: Daniel
data: 30-06-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 2
obs:
	-	Exercicio 2: Peça ao tulizador 2 numeros, e faça a sua divisão, utilize os procedimentos	correctos para que o resultado apareça o mais correcto possivel, como desafio faça com que apenas apareçam 3 casas decimais.
*/
//Inclusão de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Região Main.
#pragma region Main
//Programa principal.
int main2()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Declaração de variáveis.
	float a = 0;
	float b = 0;
	float c = 0;
	//Input e output.
	printf("\n\tEste programa realiza a divisão de dois números.\n");
	printf("\n\tIntroduza o primeiro número: ");
	scanf("%f", &a);
	printf("\n\tIntroduza o segundo número: ");
	scanf("%f", &b);
	//Operação.
	c = a / b;
	//Resposta.
	printf("\n\tO resultado da divisão de %.3f com %.3f é igual a: %.3f\n\n\t", a, b, c);	
	//Para o programa não fechar automáticamente solicitamos um input ao utilizador.
	getche();
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
#pragma endregion
/*
autor: Daniel
data: 30-06-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 5
obs:
	-	Exercicio 5: Neste exercicio por favor crie um programa para verificar se um numero inserido � numero primo,
e mostre uma mensagem a dizer" o numero inserido � primo", caso n�o seja, imprima a mensagem "o numero inserido N�O � primo"
Tamb�m verifique se o numero inserido � superior a 10 e mostre uma mensagem caso o seja- "o numero inserido � superior a 10"
Tamb�m ter� de fazer valida��o de inputs, sendo que o programa deve poder detectar que o utilizador carregou numa tecla que não � um numero
e avisar de tal erro atrav�s de uma mensagem.
*/
//Inclus�o de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Constante.
#define PI 3.14
//Região Main.
#pragma region Main
//Programa principal.
int main()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Introdu��o do programa.
	printf("\n\tEste programa verifica se um número é primo.\n\n\t");
	//Declara��o de vari�veis.
	//Ciclo para repetir.
	int repetir = 0;
	do
	{
		//Output.		
		printf("Introduza um número: ");
		//Input.
		//Para limpar o buffer de mem�ria do teclado na segunda leitura adiciona-se um espa�o antes de %c.
		//scanf(" %c", &a);		
		//Opera��o.//Resposta.		 
		int ciclo, numero;
		int primo = 1;		
		scanf(" %d", &numero);
		for(ciclo = 2; ciclo < numero; ciclo++) {
			if((numero % ciclo) == 0) {
				primo = 0;
			}
		}
		if (primo == 1)
			printf("\n\t%d é um número primo.", numero);
		else
			printf("\n\t%d não é um número primo.", numero);
		//printf("Foi introduzido %d cujo caracter = %c\n", b, (char) b);
		/*printf("%c", a);
		a = b;
		if (a >= 48 && a <= 57)
		{
			printf("\n\tIntroduziu um n�mero.\n\t");
		}
		else if (a >= 65 && a <= 90 || a >= 97 && a <= 122)
		{
			printf("\n\tIntroduziu uma letra.\n\t");
		}
		else
		{
			printf("\n\tIntroduza um n�mero ou uma letra.\n\t");
		}*/
		printf("\n\tDeseja continuar? 0 - Sim / 1 - Não: ");
		scanf(" %d", &repetir);
		printf("\n\t");
	} while (repetir == 0);
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Fim da Regi�o Main
#pragma endregion

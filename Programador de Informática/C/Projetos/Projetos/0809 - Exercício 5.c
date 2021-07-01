/*
autor: Daniel
data: 30-06-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 5
obs:
	-	Exercicio 5: Neste exercicio por favor crie um programa para verificar se um numero inserido é numero primo,
e mostre uma mensagem a dizer" o numero inserido é primo", caso não seja, imprima a mensagem "o numero inserido NÃO é primo"
Também verifique se o numero inserido é superior a 10 e mostre uma mensagem caso o seja- "o numero inserido é superior a 10"
Também terá de fazer validação de inputs, sendo que o programa deve poder detectar que o utilizador carregou numa tecla que não é um numero
e avisar de tal erro através de uma mensagem.
*/
//Inclusão de bibliotecas.
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
	//Introdução do programa.
	printf("\n\tEste programa verifica se é um número primo.\n\n\t");
	//Declaração de variáveis.
	char a = ' ';
	int b = 0;
	//Ciclo para repetir.
	int repetir = 1;
	do
	{
		//Output.		
		printf("Introduza um número: ");
		//Input.
		//Para limpar o buffer de memória do teclado na segunda leitura adiciona-se um espaço antes de %c.
		//scanf(" %c", &a);
		scanf(" %d", &b);
		//Operação.//Resposta.
				
		//printf("Foi introduzido %d cujo caracter = %c\n", b, (char) b);
		/*printf("%c", a);
		a = b;
		if (a >= 48 && a <= 57)
		{
			printf("\n\tIntroduziu um número.\n\t");
		}
		else if (a >= 65 && a <= 90 || a >= 97 && a <= 122)
		{
			printf("\n\tIntroduziu uma letra.\n\t");
		}
		else
		{
			printf("\n\tIntroduza um número ou uma letra.\n\t");
		}*/
		printf("\n\tDeseja continuar? 1 - Sim / 0 - Não: ");
		scanf(" %d", &repetir);
		printf("\n\t");
	} while (repetir == 1);
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Fim da Região Main
#pragma endregion
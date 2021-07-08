/*
autor: Daniel
data: 30-06-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 6 - For Loop
obs:
	-	Exercicio 6:

Escreva um programa em C para imprimir os primeiros 10 números naturais.
Resultado Esperado :
1 2 3 4 5 6 7 8 9 10

ESTES IREMOS FAZER NA PRÓXIMA AULA
____________________________________

2. Escreva um programa C para encontrar a soma dos primeiros 10 números naturais.
Resultado Esperado :
Os primeiros 10 números naturais são :
1 2 3 4 5 6 7 8 9 10
A Soma é : 55

3. Escreva um programa em C para exibir n termos de número natural e sua soma.
Dados de teste : 7
Resultado esperado :
O primeiro 7 número natural é :
1 2 3 4 5 6 7
A soma do número natural até 7 termos : 28

4. Escreva um programa em C para ler 10 números do teclado e encontrar sua soma e média.

5. Escreva um programa em C para exibir o cubo do número até dado um inteiro.
Dados de teste:
Insira o número de termos: 5
Resultado esperado :
O número é: 1 e o cubo do 1 é: 1
O número é: 2 e o cubo dos 2 é: 8
O número é: 3 e o cubo dos 3 é : 27
O número é: 4 e o cubo dos 4 é: 64
O número é: 5 e o cubo dos 5 é: 125
*/
//Inclusão de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Região main.
#pragma region Main
//Programa principal.
int main6()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Introdução do programa.
	printf("\n\tEste programa serve para responder aos exercícios propostos.\n\t");
	//Declaração de variáveis.
	int numero = 0;		
	//Ciclo para repetir.
	int repetir = 0;
	do
	{
		//Menu do programa.
		int menu = 0;
		printf("\n\t1 - Exercício N.º 1 - Imprimir os primeiros 10 números naturais.\n\t2 - Exercício N.º 2 - Encontrar a soma dos primeiros 10 números naturais.\n\t3 - Exercício N.º 3 - Exibir n termos de número natural e sua soma.\n\t4 - Exercício N.º 4 - Ler 10 números do teclado e encontrar sua soma e média.\n\t5 - Exercício N.º 5 - Exibir o cubo do número até dado um inteiro.\n\t6 - Sair");
		printf("\n\n\tEscolha a opção:\t");
		scanf(" %d", &menu);		
		switch (menu)
		{
		case 1:
			printf("\n\tExercício N.º 1 - Imprimir os primeiros 10 números naturais.");
			printf("\n\n\t");
			for (numero = 1; numero <= 10; numero++)
			{
				printf("%d ", numero);
			}
			printf("\n");
			break;
		case 2:			
			printf("\n\tExercício N.º 2 - Encontrar a soma dos primeiros 10 números naturais.");
			printf("\n\t");
			break;
		case 3:			
			printf("\n\tExercício N.º 3 - Exibir n termos de número natural e sua soma.");
			printf("\n\t");
			break;
		case 4:			
			printf("\n\tExercício N.º 4 - Ler 10 números do teclado e encontrar sua soma e média.");
			printf("\n\t");
			break;
		case 5:			
			printf("\n\tExercício N.º 5 - Exibir o cubo do número até dado um inteiro.");
			printf("\n\t");
			break;
		case 6:				
				printf("\n\tDeseja mesmo sair? 1 - Sim / 0 - Não: \t");
				scanf(" %d", &repetir);				
			break;
		}
	} while (repetir == 0);
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Fim da região main.
#pragma endregion
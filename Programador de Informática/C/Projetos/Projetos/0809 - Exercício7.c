/*
autor: Daniel
data: 08-07-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 7 - Ciclos
obs:

1. Escreva um programa em C para encontrar a soma dos primeiros 10 números naturais.
Resultado esperado:
Os primeiros 10 números naturais são:
1 2 3 4 5 6 7 8 9 10
A soma é : 55

2. Escreva um programa em C para exibir n termos de número naturais e a sua soma.
Dados de teste : 7
Resultado esperado :
os primeiros números naturais são:
1 2 3 4 5 6 7
A soma do número natural até 7 termos : 28

3. Escreva um programa em C para ler 10 números do teclado e encontrar sua soma e média.

4. Escreva um programa em C para exibir o cubo do números até dado um inteiro.
Dados do teste :
Insira o número de termos : 5
Resultado esperado :
o número é : 1 e o cubo do 1 é : 1
o número é : 2 e o cubo dos 2 é : 8
o número é : 3 e o cubo dos 3 é : 27
o número é : 4 e o cubo dos 4 é : 64
o número é : 5 e o cubo dos 5 é : 125

5. escreva um programa em C para exibir a tabuada de um determinado número inteiro.
dados do teste :
insira o número (tabela a ser calculada): 15
resultado esperado :

15 X 1 = 15
...
...
15 X 10= 150

6. crie um loop infinito de duas maneiras diferentes.


7. escreva um programa c para calcula o fatorial de um determinado número.
Dados do teste:
Insira o número: 5
Resultado esperado:
O fatorial de 5 é 120


8. Escreva um programa C para exibir N termos de números naturais impares e a sua soma.
Dados do teste:
Número de entrada de termos: 10
resultado esperado:
Os números impares são: 1 3 5 7 9 11 13 15 17 19


9. Escreva um programa em C para exibir o padrao abaixo usando um asterisco.
O padrao sendo o seguinte:
*

*
**
***
****

*/
//Inclusão de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Região main.
#pragma region Main
//Programa principal.
int main()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Introdução do programa.
	printf("\n\tEste programa serve para responder aos exercícios propostos.\n\t");
	//Declaração de variáveis.
	int numero = 0;
	int soma = 0;
	int controlo = 0;
	int media = 0;
	int padrao = 42;
	int vetor_padrao[4];
	vetor_padrao[0] = padrao;
	int fatorial = 0;
	//Ciclo para repetir.
	int repetir = 0;
	do
	{
		//Menu do programa.
		int menu = 0;
		printf("\n\t1 - Exercício N.º 1 - Encontrar a soma dos primeiros 10 números naturais.\n");
		printf("\n\t2 - Exercício N.º 2 - Exibir n termos de número natural e sua soma.\n");
		printf("\n\t3 - Exercício N.º 3 - Ler 10 números do teclado e encontrar sua soma e média.\n");
		printf("\n\t4 - Exercício N.º 4 - Exibir o cubo do número até dado um inteiro.\n");
		printf("\n\t5 - Exercício N.º 5 - Tabuada de um número inteiro.\n");
		printf("\n\t6 - Exercício N.º 6 - Loop infinito de duas maneiras diferentes.\n");
		printf("\n\t7 - Exercício N.º 7 - Fatorial de um número.\n");
		printf("\n\t8 - Exercício N.º 8 - Exibir N termos de números naturais impares e a sua soma.\n");
		printf("\n\t9 - Exercício N.º 9 - Número 9 desenho usando asterisco.\n");
		printf("\n\t10 - Sair.");
		printf("\n\n\tEscolha a opção: ");
		scanf(" %d", &menu);
		switch (menu)
		{
		case 1:
			printf("\n\tExercício N.º 1 - Encontrar a soma dos primeiros 10 números naturais.\n\t");
			printf("\n\t");
			printf("Os primeiros 10 números naturais são : ");
			for (numero = 1; numero <= 10; numero++)
			{
				printf("%d ", numero);
				soma = soma + numero;
			}
			printf("\n\t");
			printf("\n\tA soma é: %d\n\t", soma);
			soma = 0;
			numero = 0;
			break;
		case 2:
			printf("\n\tExercício N.º 2 - Exibir n termos de um número natural e sua soma.\n\t");
			printf("\n\tIntroduza um número: ");
			scanf(" %d", &controlo);
			printf("\n\t");
			printf("Os primeiros %d números naturais são: ", controlo);
			for (numero = 1; numero <= controlo; numero++)
			{
				printf("%d ", numero);
				soma = soma + numero;
			}
			printf("\n\t");
			printf("\n\tA soma do número natural até %d termos é: %d", controlo, soma);
			printf("\n\t");
			soma = 0;
			numero = 0;
			controlo = 0;
			break;
		case 3:
			printf("\n\tExercício N.º 3 - Ler 10 números do teclado e encontrar sua soma e média.\n\t");
			for (numero = 1; numero <= 10; numero++)
			{
				printf("\n\tIntroduza um número inteiro: ");
				scanf(" %d", &controlo);
				soma = soma + controlo;
			}
			media = soma / 10;
			printf("\n\tA soma dos números introduzidos é: %d\n\t", soma);
			printf("\n\tA media dos números introduzidos é: %d\n\t", media);
			soma = 0;
			numero = 0;
			media = 0;
			controlo = 0;
			break;
		case 4:
			printf("\n\tExercício N.º 4 - Exibir o cubo do número até dado um inteiro.\n\t");
			printf("\n\tIntroduza um número inteiro: ");
			scanf(" %d", &controlo);
			for (numero = 1; numero <= controlo; numero++)
			{
				if (numero == 1)
				{
					printf("\n\tO número é: %d e o cubo do %d é: %d", numero, numero, numero * numero * numero);
				}
				else
				{
					printf("\n\tO número é: %d e o cubo dos %d é: %d", numero, numero, numero * numero * numero);
				}
				printf("\n\t");
			}
			soma = 0;
			numero = 0;
			media = 0;
			controlo = 0;
			break;
		case 5:
			printf("\n\tExercício N.º 5 - Tabuada de um número inteiro.\n\t");
			printf("\n\tIntroduza um número inteiro: ");
			scanf(" %d", &controlo);
			for (numero = 1; numero <= 10; numero++)
			{
				printf("\n\t%d X %d = %d", numero, controlo, numero * controlo);
				printf("\n\t");
			}
			soma = 0;
			numero = 0;
			media = 0;
			controlo = 0;
			break;
		case 6:
		{
			int repetir_loop = 0;
			do
			{
				printf("\n\tExercício N.º 6 - Loop infinito de duas maneiras diferentes.\n\t");
				int menu_loop = 0;
				printf("\n\tATENÇÃO - Qualquer opção seguinte resultará num ciclo infinito sem possibilidade de retornar ao estado atual, para parar o ciclo infinito use: CTRL + C.\n");
				printf("\n\t1 - Loop Do while infinito.\n");
				printf("\n\t2 - Loop For infinito.\n");
				printf("\n\t3 - Voltar.");
				printf("\n\n\tEscolha a opção: ");
				scanf(" %d", &menu_loop);
				if (menu_loop == 1)
				{
					do
					{
						printf("Do while infinito. ");
					}
					while (controlo == 0);
				}
				else if (menu_loop == 2)
				{
					for (numero = 1;; numero++)
					{
						printf("For infinito. ", numero);
					}
				}
				else if (menu_loop == 3)
				{
					printf("\n\tDeseja mesmo voltar? 1 - Sim / 0 - Não: ");
					scanf(" %d", &repetir_loop);
				}
			} while (repetir_loop == 0); 
		}
			break;
		case 7:
			printf("\n\tExercício N.º 7 - Fatorial de um número.\n\t");
			printf("\n\tIntroduza um número inteiro: ");
			scanf(" %d", &controlo);
			numero = controlo;
			for (fatorial = 1; numero > 1; numero--)
			{
				fatorial = fatorial * numero;
			}
			printf("\n\tfatorial de %d é: %d\n\t", controlo, fatorial);
			printf("\n\t");
			numero = 0;
			fatorial = 0;
			controlo = 0;
			break;
		case 8:
			printf("\n\tExercício N.º 8 - Exibir N termos de números naturais impares e a sua soma.\n\t");
			printf("\n\tIntroduza um número: ");
			scanf(" %d", &controlo);
			printf("\n\t");
			printf("Os primeiros %d números impares naturais são: ", controlo);
			for (numero = 1; numero < controlo*2; numero+=2)
			{
				printf("%d ", numero);
				soma = soma + numero;
			}
			printf("\n\t");
			printf("\n\tA soma dos números naturais impares até %d termos é: %d", controlo, soma);
			printf("\n\t");
			soma = 0;
			numero = 0;
			controlo = 0;
			break;
		case 9:
			printf("\n\tExercício N.º 9 - Desenho usando asterisco.\n\t");
			printf("\n");
			for (numero = 1; numero <= 1; numero++)
			{			
				printf("%c", padrao);
				printf("\n");								
				printf("%c", padrao);
				printf("%c", padrao);
				printf("\n");
				printf("%c", padrao);
				printf("%c", padrao);
				printf("%c", padrao);
				printf("\n");	
				printf("%c", padrao);
				printf("%c", padrao);
				printf("%c", padrao);
				printf("%c", padrao);
				printf("\n");				
			}
			printf("\n\t");
			numero = 0;
			break;
		case 10:
			printf("\n\tDeseja mesmo sair? 1 - Sim / 0 - Não: ");
			scanf(" %d", &repetir);
			break;
		}
	} while (repetir == 0);
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Fim da região main.
#pragma endregion
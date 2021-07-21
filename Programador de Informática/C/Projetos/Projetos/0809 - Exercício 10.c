/*
autor: Daniel
data: 16-07-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 10 - Funções e Procedimentos.
obs:

1. Escreva um método C para encontrar o menor número entre três números.
Dados de teste:
Insira o primeiro número: 25
Insira o segundo número: 37
Insira o terceiro número: 29
Resultado esperado:
O menor valor é 25
2. Escreva um método em C para calcular a média de três números inteiros
Dados de teste:
Insira o primeiro número: 25
Insira o segundo número: 45
Insira o terceiro número: 65
Resultado esperado:
O valor médio é 45,0
3. Escreva um método em C para calcular o valor do investimento futuro a uma determinada taxa de juros por um determinado número de anos.
Dados de amostra:
Insira o valor do investimento: 1000
Insira a taxa de juros: 10
Insira o número de anos: 5
4. Escreva um programa em C para imprimir todos os números perfeitos em um determinado intervalo usando a função.
Dados de teste:
Insira o limite mínimo de pesquisa de números perfeitos: 1
Insira o limite máximo de pesquisa de números perfeitos: 100
Resultado esperado :
Os números perfeitos entre 1 a 100 são:
6 28

*/
//Inclusão de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Região main.
#pragma region Main
//Assinatura/Protótipo das Funções e Procedimentos.
void menor_de_tres_numeros(int num1, int num2, int num3);
float media_de_tres_inteiros(int num1, int num2, int num3);
float investimento_futuro(float valor, int anos, float taxa);
//Programa principal.
int main()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Introdução do programa.
	printf("\n\tEste programa serve para responder aos exercícios propostos.\n\t");
	//Declaração de variáveis.
	int num1 = 0, num2 = 0, num3 = 0, anos = 0;
	float valor = 0.0, resultado = 0.0, taxa = 0.0, retorno = 0.0;
	//Ciclo para repetir.
	int repetir = 0;
	do
	{
		//Menu do programa.
		int menu = 0;
		printf("\n\t1 - Exercício N.º 1 - Encontrar o menor número entre três números.\n");
		printf("\n\t2 - Exercício N.º 2 - Calcular a média de três números inteiros.\n");
		printf("\n\t3 - Exercício N.º 3 - Calcular o valor do investimento futuro a uma determinada taxa de juros por um determinado número de anos.\n");
		printf("\n\t4 - Exercício N.º 4 - Imprimir todos os números perfeitos em um determinado intervalo usando a função.\n");
		printf("\n\t10 - Sair.");
		printf("\n\n\tEscolha a opção: ");
		scanf(" %d", &menu);
		switch(menu)
		{
		case 1:
			printf("\n\tExercício N.º 1 - Encontrar o menor número entre três números.\n\t");
			printf("\n\tIntroduza o primeiro número: ");
			scanf(" %d", &num1);
			printf("\n\tIntroduza o segundo número: ");
			scanf(" %d", &num2);
			printf("\n\tIntroduza o terceiro número: ");
			scanf(" %d", &num3);
			menor_de_tres_numeros(num1, num2, num3);
			break;
		case 2:
			printf("\n\tExercício N.º 2 - Calcular a média de três números inteiros.\n\t");
			printf("\n\tIntroduza o primeiro número: ");
			scanf(" %d", &num1);
			printf("\n\tIntroduza o segundo número: ");
			scanf(" %d", &num2);
			printf("\n\tIntroduza o terceiro número: ");
			scanf(" %d", &num3);
			resultado = media_de_tres_inteiros(num1, num2, num3);
			printf("\n\tA média entre %d, %d e %d é %.2f.\n", num1, num2, num3, resultado);
			break;
		case 3:
			printf("\n\tExercício N.º 3 - Calcular o valor do investimento futuro a uma determinada taxa de juros por um determinado número de anos.\n\t");
			printf("\n\tIntroduza o valor: ");
			scanf(" %f", &valor);
			printf("\n\tIntroduza o numero de anos: ");
			scanf(" %d", &anos);
			printf("\n\tIntroduza a taxa: ");
			scanf(" %f", &taxa);
			taxa = taxa / 100;
			retorno = investimento_futuro(valor, anos, taxa);
			taxa = taxa * 100;
			printf("\n\tO retorno do investimento de %.2f em %d anos à taxa de %.2f %% é de %.2f.\n", valor, anos, taxa, retorno);
			break;
		case 4:
			printf("\n\tExercício N.º 4 - Imprimir todos os números perfeitos em um determinado intervalo usando a função.\n\t");
						
			break;
		case 10:
			printf("\n\tDeseja mesmo sair? 1 - Sim / 0 - Não: ");
			scanf(" %d", &repetir);
			break;
		}
	} while(repetir == 0);
	//Pedir ao utilizador um caracter para sair.
	printf("\n\tPressione ENTER para sair.\n");
	//Para parar no final.
	getchar();
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Funções e Procedimentos.
void menor_de_tres_numeros(int num1, int num2, int num3)
{
	if(num1 < num2 && num1 < num3)
	{
		printf("\n\tO número %d é o menor número.\n", num1);		
	}
	else if(num2 < num1 && num2 < num3)
	{
		printf("\n\tO número %d é o menor número.\n", num2);		
	}
	else
	{
		printf("\n\tO número %d é o menor número.\n", num3);		
	}
}
float media_de_tres_inteiros(int num1, int num2, int num3)
{
	float resultado;
	resultado = (num1 + num2 + num3)/3;
	return resultado;
}
float investimento_futuro(float valor, int anos, float taxa)
{
	float retorno;
	retorno = valor * anos * taxa;
	return retorno;
}
//Fim da região main.
#pragma endregion
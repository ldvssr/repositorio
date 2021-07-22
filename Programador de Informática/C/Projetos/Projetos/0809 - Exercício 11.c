/*
autor: Daniel
data: 16-07-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 11 - Funções e Procedimentos.
obs:

1. Escreva um programa em C para encontrar o quadrado de qualquer número usando uma função.
Dados de teste:
Insira qualquer número para o quadrado: 20
Resultado esperado :
O quadrado de 20 é: 400,00

2. Escreva um programa em C para encontrar o resultado desta expressão: 1! / 1 + 2! / 2 + 3! / 3 + 4! / 4 + 5! / 5
usando a função:
(3! = 3 X 2 X 1 = 6) (factorial do numero 3)
Resultado esperado:
A soma da série é: 34
void main() //deverá fazer apenas a função responsavel pelo fact e inseri-la num programa.
{
int sum;
sum=fact(1)/1+fact(2)/2+fact(3)/3+fact(4)/4+fact(5)/5;
printf("\n\n Function : find the sum of 1!/1+2!/2+3!/3+4!/4+5!/5 :\n");
printf("----------------------------------------------------------\n");
printf("The sum of the series is : %d\n\n",sum);
}

3. Escreva um programa em C para verificar se um número é primo ou não usando a função.

4. Copie o código abaixo para o seu projecto e explique o seu funcionamento linha a linha(+-) e
explique o objectivo do código.

R: O objetivo do código é transformar um número décimal em binário.

R: incluir a biblioteca de entrada/saida
#include<stdio.h>
R: desabilitar o aviso de segurança 4996
#pragma warning(disable: 4996)
R: prótotipo da função toB
long toB(int);
R: função main
int main()
{
	R: declaração das variáveis long e int, bno e dno.
	long bno;
	int dno;
	R: escrita no ecrã a pedir para introduzir um numero décimal
	printf("Input any decimal number: ");
	R: leitura do teclado do número décimal e atribuir à variàvel dno
	scanf("%d", &dno);
	R: atribuição do retorno da função tob aplicada à variável dno na variável bno
	bno = toB(dno);
	R: imprimir o resultado com o valor da variável bno
	printf("\nThe value is: %ld\n\n", bno);
	R: para o programa retornar 0 = sem erros
	return 0;
	R: fim do main
}
R: função toB que recebe um valor decimal e retorna um valor binário
long toB(int dno)
{
	R: declaração de variàveis locais e inicialização de algumas
	long bno = 0, remainder, f = 1;
	R: ciclo while diferente de 0
	while (dno != 0)
	{
	a variavel remainder recebe ao resto da divisao de dno por 2
	remainder = dno % 2;
	a variável bno recebe bno mais o resto da divisão anterior e multiplica por 1
	bno = bno + remainder * f;
	a variável f recebe f vezes 10
	f = f * 10;
	a variável dno  recebe dno a dividir por 2
	dno = dno / 2;
	}
	R: retorno da função
	return bno;
	R: fim da função
}

*/
//Inclusão de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Assinatura/Protótipo das Funções e Procedimentos.
#pragma region Prototipos
float quadrado(int);
void primo(int);
int fact(int fact);
long toB(int);
#pragma endregion
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
	int num1 = 0;
	float num2 = 0;
	//Ciclo para repetir.
	int repetir = 0;
	do
	{
		//Menu do programa.
		int menu = 0;
		printf("\n\t1 - Exercício N.º 1 - Encontrar o quadrado de qualquer número usando uma função.\n");
		printf("\n\t2 - Exercício N.º 2 - Encontrar o resultado desta expressão: 1! / 1 + 2! / 2 + 3! / 3 + 4! / 4 + 5! / 5.\n");
		printf("\n\t3 - Exercício N.º 3 - Verificar se um número é primo ou não usando a função.\n");
		printf("\n\t4 - Exercício N.º 4 - Transformar um número décimal em binário.\n");
		printf("\n\t5 - Sair.");
		printf("\n\n\tEscolha a opção: ");
		scanf(" %d", &menu);
		switch (menu)
		{
		case 1:
			printf("\n\tExercício N.º 1 - Encontrar o quadrado de qualquer número usando uma função.\n\t");
			printf("\n\tIntroduza um número: ");
			scanf(" %d", &num1);
			num2 = quadrado(num1);
			printf("\n\tO quadrado de %d é: %.2f\n\t", num1, num2);
			num1, num2 = 0;
			break;
		case 2:
			printf("\n\tExercício N.º 2 - Encontrar o resultado desta expressão: 1! / 1 + 2! / 2 + 3! / 3 + 4! / 4 + 5! / 5.\n\t");
			int sum;
			sum = fact(1) / 1 + fact(2) / 2 + fact(3) / 3 + fact(4) / 4 + fact(5) / 5;
			printf("\n\n Function : find the sum of 1!/1+2!/2+3!/3+4!/4+5!/5 :\n");
			printf("----------------------------------------------------------\n");
			printf("The sum of the series is : %d\n\n", sum);
			break;
		case 3:
			printf("\n\tExercício N.º 3 - Verificar se um número é primo ou não usando a função.\n\t");
			printf("\n\tIntroduza um número: ");
			scanf(" %d", &num1);
			primo(num1);
			num1 = 0;
			break;
		case 4:
			printf("\n\tExercício N.º 4 - Transformar um número décimal em binário.\n\t");
			long bno;
			int dno;
			printf("\n\tIntroduza qualquer número décimal: ");
			scanf("%d", &dno);
			bno = toB(dno);
			printf("\n\tO valor em binário é: %ld\n\t", bno);
			break;
		case 5:
			printf("\n\tDeseja mesmo sair? 1 - Sim / 0 - Não: ");
			scanf(" %d", &repetir);
			break;
		}
	} while (repetir == 0);
	//Pedir ao utilizador um caracter para sair.
	printf("\n\tPressione ENTER para sair.\n");
	//Para parar no final.
	getchar();
	//Para devolver 0 caso o programa seja executado corretamente.
	return 0;
}
//Fim da região main.
#pragma endregion
//Funções e Procedimentos.
#pragma region Funcoes
float quadrado(int num)
{
	float quadrado;
	quadrado = num * num;
	return quadrado;
}
void primo(int numero)
{
	int ciclo = 0, primo = 0;
	for (ciclo = 2; ciclo < numero; ciclo++) {
		if ((numero % ciclo) == 0) {
			primo = 0;
		}
	}
	if (primo == 1)
		printf("\n\t%d é um número primo.\n", numero);
	else
		printf("\n\t%d não é um número primo.\n", numero);
}
int fact(int fact)
{
	int n = fact;
	for (fact = 1; n > 1; n -= 1)
	{
		fact = fact * n;
	}
	return fact;
}
long toB(int dno)
{
	long bno = 0, remainder, f = 1;
	while (dno != 0)
	{
		remainder = dno % 2;
		bno = bno + remainder * f;
		f = f * 10;
		dno = dno / 2;
	}
	return bno;
}
#pragma endregion
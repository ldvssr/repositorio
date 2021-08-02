/*
autor: Daniel
data: 22-07-2021
vers: 1.0
email: ldvssr@icloud.com
desc: Exercicio 11 - Fun��es e Procedimentos.
obs:

1. Escreva um programa em C para encontrar o quadrado de qualquer n�mero usando uma fun��o.
Dados de teste:
Insira qualquer n�mero para o quadrado: 20
Resultado esperado :
O quadrado de 20 �: 400,00

2. Escreva um programa em C para encontrar o resultado desta express�o: 1! / 1 + 2! / 2 + 3! / 3 + 4! / 4 + 5! / 5
usando a fun��o:
(3! = 3 X 2 X 1 = 6) (factorial do numero 3)
Resultado esperado:
A soma da s�rie �: 34
void main() //dever� fazer apenas a fun��o responsavel pelo fact e inseri-la num programa.
{
int sum;
sum=fact(1)/1+fact(2)/2+fact(3)/3+fact(4)/4+fact(5)/5;
printf("\n\n Function : find the sum of 1!/1+2!/2+3!/3+4!/4+5!/5 :\n");
printf("----------------------------------------------------------\n");
printf("The sum of the series is : %d\n\n",sum);
}

3. Escreva um programa em C para verificar se um n�mero � primo ou n�o usando a fun��o.

4. Copie o c�digo abaixo para o seu projecto e explique o seu funcionamento linha a linha(+-) e
explique o objectivo do c�digo.

R: O objetivo do c�digo � transformar um n�mero d�cimal em bin�rio.

R: incluir a biblioteca de entrada/saida
#include<stdio.h>
R: desabilitar o aviso de seguran�a 4996
#pragma warning(disable: 4996)
R: pr�totipo da fun��o toB
long toB(int);
R: fun��o main
int main()
{
	R: declara��o das vari�veis long e int, bno e dno.
	long bno;
	int dno;
	R: escrita no ecr� a pedir para introduzir um numero d�cimal
	printf("Input any decimal number: ");
	R: leitura do teclado do n�mero d�cimal e atribuir � vari�vel dno
	scanf("%d", &dno);
	R: atribui��o do retorno da fun��o tob aplicada � vari�vel dno na vari�vel bno
	bno = toB(dno);
	R: imprimir o resultado com o valor da vari�vel bno
	printf("\nThe value is: %ld\n\n", bno);
	R: para o programa retornar 0 = sem erros
	return 0;
	R: fim do main
}
R: fun��o toB que recebe um valor decimal e retorna um valor bin�rio
long toB(int dno)
{
	R: declara��o de vari�veis locais e inicializa��o de algumas
	long bno = 0, remainder, f = 1;
	R: ciclo while diferente de 0
	while (dno != 0)
	{
	a variavel remainder recebe ao resto da divisao de dno por 2
	remainder = dno % 2;
	a vari�vel bno recebe bno mais o resto da divis�o anterior e multiplica por 1
	bno = bno + remainder * f;
	a vari�vel f recebe f vezes 10
	f = f * 10;
	a vari�vel dno  recebe dno a dividir por 2
	dno = dno / 2;
	}
	R: retorno da fun��o
	return bno;
	R: fim da fun��o
}

*/
//Inclus�o de bibliotecas.
#include <stdio.h>
#include <locale.h>
//Desabilitar o aviso de erro 4996.
#pragma warning (disable: 4996)
//Assinatura/Prot�tipo das Fun��es e Procedimentos.
#pragma region Prototipos
float quadrado(int);
void primo(int);
int fact(int fact);
long toB(int);
#pragma endregion
//Regi�o main.
#pragma region Main
//Programa principal.
int main11()
{
	//Permite reconhecer os caracteres portugueses.
	setlocale(LC_ALL, "Portuguese");
	//Introdu��o do programa.
	printf("\n\tEste programa serve para responder aos exerc�cios propostos.\n\t");
	//Declara��o de vari�veis.
	int num1 = 0;
	float num2 = 0;
	//Ciclo para repetir.
	int repetir = 0;
	do
	{
		//Menu do programa.
		int menu = 0;
		printf("\n\t1 - Exerc�cio N.� 1 - Encontrar o quadrado de qualquer n�mero usando uma fun��o.\n");
		printf("\n\t2 - Exerc�cio N.� 2 - Encontrar o resultado desta express�o: 1! / 1 + 2! / 2 + 3! / 3 + 4! / 4 + 5! / 5.\n");
		printf("\n\t3 - Exerc�cio N.� 3 - Verificar se um n�mero � primo ou n�o usando a fun��o.\n");
		printf("\n\t4 - Exerc�cio N.� 4 - Transformar um n�mero d�cimal em bin�rio.\n");
		printf("\n\t5 - Sair.");
		printf("\n\n\tEscolha a op��o: ");
		scanf(" %d", &menu);
		switch (menu)
		{
		case 1:
			printf("\n\tExerc�cio N.� 1 - Encontrar o quadrado de qualquer n�mero usando uma fun��o.\n\t");
			printf("\n\tIntroduza um n�mero: ");
			scanf(" %d", &num1);
			num2 = quadrado(num1);
			printf("\n\tO quadrado de %d �: %.2f\n\t", num1, num2);
			num1, num2 = 0;
			break;
		case 2:
			printf("\n\tExerc�cio N.� 2 - Encontrar o resultado desta express�o: 1! / 1 + 2! / 2 + 3! / 3 + 4! / 4 + 5! / 5.\n\t");
			int sum;
			sum = fact(1) / 1 + fact(2) / 2 + fact(3) / 3 + fact(4) / 4 + fact(5) / 5;
			printf("\n\tFunction : find the sum of 1!/1+2!/2+3!/3+4!/4+5!/5 :\n");
			printf("\n\t----------------------------------------------------------\n");
			printf("\n\tThe sum of the series is : %d\n", sum);
			break;
		case 3:
			printf("\n\tExerc�cio N.� 3 - Verificar se um n�mero � primo ou n�o usando a fun��o.\n\t");
			printf("\n\tIntroduza um n�mero: ");
			scanf(" %d", &num1);
			primo(num1);
			num1 = 0;
			break;
		case 4:
			printf("\n\tExerc�cio N.� 4 - Transformar um n�mero d�cimal em bin�rio.\n\t");
			long bno;
			int dno;
			printf("\n\tIntroduza qualquer n�mero d�cimal: ");
			scanf("%d", &dno);
			bno = toB(dno);
			printf("\n\tO valor em bin�rio �: %ld\n\t", bno);
			break;
		case 5:
			printf("\n\tDeseja mesmo sair? 1 - Sim / 0 - N�o: ");
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
//Fim da regi�o main.
#pragma endregion
//Fun��es e Procedimentos.
#pragma region Funcoes
float quadrado(int num)
{
	float quadrado;
	quadrado = num * num;
	return quadrado;
}
void primo(int numero)
{
	int ciclo = 0, primo = 1;
	for (ciclo = 2; ciclo < numero; ciclo++) {
		if ((numero % ciclo) == 0) {
			primo = 0;
		}
	}
	if (primo == 1)
		printf("\n\t%d � um n�mero primo.\n", numero);
	else
		printf("\n\t%d n�o � um n�mero primo.\n", numero);
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
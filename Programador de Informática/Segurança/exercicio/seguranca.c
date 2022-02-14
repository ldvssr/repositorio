
#pragma warning(disable:4996)

/*
#include <stdio.h>
#include <stdlib.h>

float ler_valor_patrimonial() {
	float v_patrimonial;
	printf("\nQual o valor Patrimonial?");
	scanf("%f", &v_patrimonial);
	return v_patrimonial;
}
float ler_taxa() {
	float taxa;
	printf("\nQual a taxa?");
	scanf("%f", &taxa);
	return taxa;
}
float imprime(float v_patrimonial, float taxa) {
	printf("O valor a pagar de imi é %.2f", v_patrimonial * taxa);
	return (v_patrimonial * taxa);
}
int main() {
	float v_patrimonal = 0.0, taxa = 0.0;
	v_patrimonal = ler_valor_patrimonial();
	taxa = ler_taxa();
	imprime(v_patrimonal, taxa);
	return 0;
}
*/

/*

#include <stdio.h>
#include <stdlib.h>

float aaa() {
	float abc;
	printf("\nQual o valor Patrimonial?");
	scanf("%f", &abc);
	return abc;
}
float bbb() {
	float bcd;
	printf("\nQual a taxa?");
	scanf("%f", &bcd);
	return bcd;
}
float ccc(float abc, float bcd) {
	printf("O valor a pagar de imi é %.2f", abc * bcd);
	return (abc * bcd);
}
int main() {
	float abc = 0.0, bcd = 0.0;
	abc = aaa();
	bcd = bbb();
	ccc(abc, bcd);
	return 0;
}
*/


/*
#include <stdio.h>



// este programa vai calcular o imc
void main()
{
	char genero;
	float peso, altura, imc;	
	do
	{
		printf("\nQual o seu genero(F/M)? ");
		//scanf ("%c", &genero);
		genero = getche();
	} while (genero != 'F' && genero != 'f' && genero != 'M' && genero != 'm');
	
	printf("\nQual o seu peso? ");
	scanf("%f", &peso);
	
	printf("\nQual a sua altura? ");
	scanf("%f", &altura);

	imc = peso / (altura * altura);
	printf("\nO seu indice de massa corporal = %.2f", imc);

	if (genero == 'M' || genero == 'm')
	{
		//caso seja masculino
		if (imc < 20)
			printf("\nAbaixo do peso!");
		else if (imc < 25)
			printf("\nPeso Normal");
		else if (imc < 30)
			printf("\nAcima do Peso!");
		else printf("\nObesidade!");
	}
	else if (genero == 'F' || genero == 'f')
	{
		//caso seja feminino
		if (imc < 19)
			printf("\nAbaixo do peso!");
		else if (imc < 24)
			printf("\nPeso Normal");
		else if (imc < 30)
			printf("\nAcima do Peso!");
		else printf("\nObesidade!");
	}

}
*/

/*
#include <stdio.h>
#include <stdlib.h>

char ler_genero(char genero);
float ler_peso(float peso);
float ler_altura(float altura);
void classifica_m(char genero, float imc);
void classifica_f(char genero, float imc);

void main()
{
	char genero = 'a';
	float peso = 0.0, altura = 0.0, imc = 0.0;
	genero = ler_genero(genero);
	peso = ler_peso(peso);
	altura = ler_altura(altura);
	imc = peso / (altura * altura);
	if (genero == 'M' || genero == 'm')
		classifica_m(genero, imc);
	else
		classifica_f(genero, imc);
}

char ler_genero(char genero)
{
	//char genero;
	do
	{
		printf("\nQual o seu genero(F/M)? ");
		//scanf ("%c", &genero);
		genero = getche();
	} while (genero != 'F' && genero != 'f' && genero != 'M' && genero != 'm');
	return genero;
}

float ler_peso(float peso)
{
	printf("\nQual o seu peso? ");
	scanf("%f", &peso);
	return peso;
}

float ler_altura(float altura)
{
	printf("\nQual a sua altura? ");
	scanf("%f", &altura);
	return altura;
}

void classifica_m(char genero, float imc)
{
	if (genero == 'M' || genero == 'm')
	{
		if (imc < 20)
			printf("\nAbaixo do peso!");
		else if (imc < 25)
			printf("\nPeso Normal");
		else if (imc < 30)
			printf("\nAcima do Peso!");
		else printf("\nObesidade!");
	}
}

void classifica_f(char genero, float imc)
{
	if (genero == 'F' || genero == 'f')
	{
		if (imc < 19)
			printf("\nAbaixo do peso!");
		else if (imc < 24)
			printf("\nPeso Normal");
		else if (imc < 30)
			printf("\nAcima do Peso!");
		else printf("\nObesidade!");
	}
}
*/

#include <stdio.h>
#include <stdlib.h>

char ler_genero(char genero);
float ler_peso(float peso);
float ler_altura(float altura);
void classifica_m(char genero, float imc);
void classifica_f(char genero, float imc);

void main()
{
	char genero = 'a';
	float peso = 0.0, altura = 0.0, imc = 0.0;
	genero = ler_genero(genero);
	peso = ler_peso(peso);
	altura = ler_altura(altura);
	imc = peso / (altura * altura);
	if (genero == 'M' || genero == 'm')
		classifica_m(genero, imc);
	else
		classifica_f(genero, imc);
}

char ler_genero(char genero)
{	
	do
	{
		printf("\nQual o seu genero(F/M)? ");		
		genero = getche();
		printf("\n");
	} while (genero != 'F' && genero != 'f' && genero != 'M' && genero != 'm');
	return genero;
}

float ler_peso(float peso)
{
	do
	{
		printf("\nQual o seu peso? ");
		scanf("%f", &peso);
	} while (peso < 40.0 && peso > 300.0);
	return peso;
}

float ler_altura(float altura)
{
	do
	{
		printf("\nQual a sua altura? ");
		scanf("%f", &altura);
	} while (altura < 0.9 && altura > 2.3);
	return altura;
}

void classifica_m(char genero, float imc)
{
	if (genero == 'M' || genero == 'm')
	{
		if (imc < 20)
			printf("\nAbaixo do peso!\n");
		else if (imc < 25)
			printf("\nPeso Normal\n");
		else if (imc < 30)
			printf("\nAcima do Peso!\n");
		else printf("\nObesidade!\n");
	}
}

void classifica_f(char genero, float imc)
{
	if (genero == 'F' || genero == 'f')
	{
		if (imc < 19)
			printf("\nAbaixo do peso!\n");
		else if (imc < 24)
			printf("\nPeso Normal\n");
		else if (imc < 30)
			printf("\nAcima do Peso!\n");
		else printf("\nObesidade!\n");
	}
}
/*
* Autor: Lic�nio Daniel 
* Data: 06 de setembro de 2021
* Vers�o: 1.0
* E-mail: ldvssr@icloud.com
* Descri��o: Trabalho Cart�o Matriz
* Observa��es: 
*/
#include "header.h"
#pragma region Main
int main()
{
	setlocale(LC_ALL, "Portuguese");

	//Random

	//Apenas inicializar uma vez
	srand(time(NULL));

	// Inicializa��o apenas deve ser chamada uma vez.
	int r = rand();
	printf("%d", r % 200);
	

	//Gravar Ficheiros
	
	//apontador para Ficheiros
	FILE* af;

	//apontar para endere�o de array, sendo que mem�ria alocada.
	char* nomeFicheiro = "temperaturas.dat";

	//variaveis auxiliares
	int nescritos, i;

	//array doubles para armazenar as temperaturas
	double temperaturas[7];

	for (i = 0; i < 7; i++)
	{
		printf("\nTemperatura do dia %d", i + 1);
		scanf("%lf", &temperaturas[i]);
	}
	//Criar ficheiro em modo de escrever em bin�rio
	af = fopen(nomeFicheiro, "wb");

	if (af == NULL) {
		printf("Ocorreu um erro meu caro");
	}
	else {
		nescritos = fwrite(&temperaturas[0], sizeof(double), 7, af);
		if (nescritos == 0) printf("N�o foi escrito nenhum elemento");
		else {
			if (nescritos < 7) {
				printf("Faltam %d temperaturas gravadas", 7 - nescritos);
			}

		}
	}
	fclose(af);


	/*int a, b;
	printf("\n\tEste programa realiza a soma entre dois n�meros. ");
	printf("\n");
	printf("\n\tN�mero a: ");
	scanf("%d", &a);
	printf("\n\tN�mero b: ");
	scanf("%d", &b);
	printf("\n\tA soma de %d com %d � igual a: %d ", a, b, soma(a,b));
	printf("\n");*/

	getche();

	return 0;
}
#pragma endregion

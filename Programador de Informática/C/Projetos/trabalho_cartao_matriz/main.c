/*
* Autor: Licínio Daniel 
* Data: 06 de setembro de 2021
* Versão: 1.0
* E-mail: ldvssr@icloud.com
* Descrição: Trabalho Cartão Matriz
* Observações: 
*/
#include "header.h"
#pragma region Main
int main()
{
	setlocale(LC_ALL, "Portuguese");

	//Random

	//Apenas inicializar uma vez
	srand(time(NULL));

	// Inicialização apenas deve ser chamada uma vez.
	int r = rand();
	printf("%d", r % 200);
	

	//Gravar Ficheiros
	
	//apontador para Ficheiros
	FILE* af;

	//apontar para endereço de array, sendo que memória alocada.
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
	//Criar ficheiro em modo de escrever em binário
	af = fopen(nomeFicheiro, "wb");

	if (af == NULL) {
		printf("Ocorreu um erro meu caro");
	}
	else {
		nescritos = fwrite(&temperaturas[0], sizeof(double), 7, af);
		if (nescritos == 0) printf("Não foi escrito nenhum elemento");
		else {
			if (nescritos < 7) {
				printf("Faltam %d temperaturas gravadas", 7 - nescritos);
			}

		}
	}
	fclose(af);


	/*int a, b;
	printf("\n\tEste programa realiza a soma entre dois números. ");
	printf("\n");
	printf("\n\tNúmero a: ");
	scanf("%d", &a);
	printf("\n\tNúmero b: ");
	scanf("%d", &b);
	printf("\n\tA soma de %d com %d é igual a: %d ", a, b, soma(a,b));
	printf("\n");*/

	getche();

	return 0;
}
#pragma endregion

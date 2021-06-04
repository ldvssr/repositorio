#include <stdio.h>
#include <stdlib.h>
/*Variáveis globais do programa*/
int fila[10];
int ultimo;
int primeiro;
int max;
int numeroItens;
/*Procedimento CreateQ (Criação de uma fila - Reset de variaveis)*/
void create()
{
	max = 10;
    ultimo = -1;
    primeiro = 0;
    numeroItens = 0;
}
/*Procedimento Insert (Inserir novo valor na fila)*/
void insert(int valor1)
{
	ultimo = ultimo + 1;
    numeroItens = numeroItens + 1;
    if (ultimo >= max)
    {
        ultimo = 0;
    }
    fila[ultimo] = valor1;
}
/*Função Remove (remove o ultimo valor da fila)*/
int remover()
{
	primeiro = primeiro + 1;
    numeroItens = numeroItens -1;
    if (primeiro >= max)
    {
        primeiro = 0;
    }
    return fila[primeiro];
}
/*Função Full (devolve 0 se pilha cheia
devolve 1 se a fila ainda tem vagas)*/
int full()
{
	if (numeroItens == max)
	{
		return 1;
	}
	else
	{
		return 0;
	}
}
/*Função Empty (devolve 1 se fila vazia
devolve 0 se a fila nao esta vazia)*/
int empty()
{
	if (numeroItens == 0)
	{
		return 1;
	}
	else
	{
		return 0;
	}
}
int main ()
{
	/*Vari�veis Locais*/
	int leitura;
	/*Apresentacao do programa*/
	printf("\n Este programa serve para manipular filas.\n");
	printf("\n");
	/*Ciclo de Repetição*/
	int repetir = 0;
	do 
	{
		/*Menu do programa*/
		int menu;
		printf("\n\t1 - Criar Fila\n\t2 - Inserir Valor na Fila\n\t3 - Remover Valor da Fila\n\t4 - Verificar se a Fila tem posicoes vagas\n\t5 - Verificar se a Fila esta vazia\n\t6 - Sair\n");
		printf("\n Qual a opcao:\t");
		scanf("%d",&menu);
		printf("\n");

		switch (menu)
		{
			case 1:
				/*Chamar o Procedimento CreateQ*/
				create();
				printf("\n [CreateS]\tA fila foi criada...\t");
				printf("\n\n");
				break;
			case 2:
				/*Chamar o Procedimento Insert*/
				
				printf("\n [Insert]\tIntroduza o valor na fila:\t");
				scanf("%d",&leitura);
				insert(leitura);
				printf("\n");
				break;
			case 3:
				/*Chamar a Função Remove*/
                
				printf("\n [Remove]\tO valor apresentado foi removido da fila:\t");
				printf("%d",remover());
				printf("\n\n");
				break;
			case 4:
				/*Chamar a Função Full*/
				if (full()==0)
				{
					printf("\n [Full]\tA fila ainda tem lugares");
					printf("\n\n");
				}
				else
				{
					printf("\n [Full]\tA fila encontra-se cheia");
					printf("\n\n");
				}
				break;
			case 5:
				/*Chamar a Função Empty*/
				if (empty()==1)
				{
					printf("\n [Empty]\tA fila esta vazia");
					printf("\n\n");
				}
				else
				{
					printf("\n [Empty]\tA fila encontra-se com dados");
					printf("\n\n");
				}
				break;
			case 6:
				/*Ciclo de Repetição*/
				printf("\n\tDeseja mesmo sair? 0 - Nao / 1 - Sim \t");
				scanf(" %d", &repetir);
				printf("\n");
				break;				
		}
	}
	while (repetir == 0);
	system("break");
}

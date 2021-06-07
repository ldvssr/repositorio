#include <stdio.h>
#include <stdlib.h>
/*Variáveis globais do programa*/
int pilha[10];
int pilha2[10];
int pos;
int pos2;
/*Procedimento CreateS (Define que o valor da posicao inicial na pilha é -1)*/
void create()
{
	pos = -1;
}
void create2()
{
	pos2 = -1;
}
/*Procedimento Push (introduz um valor no topo da pilha)*/
void push(int valor)
{
	pos = pos +1;
	pilha[pos] = valor;
}
/*Procedimento Push (introduz um valor no topo da pilha)*/
void push2(int valor2)
{
	pos2 = pos2 +1;
	pilha2[pos2] = valor2;
}
/*Função Pop (remove o ultimo valor da pilha)*/
int pop()
{
	int valor;
	valor = pilha [pos];
	pos = pos -1;
	return valor;
}
int pop2()
{
	int valor2;
	valor2 = pilha2 [pos2];
	pos2 = pos2 -1;
	return valor2;
}
/*Função Size (apresenta o numero de elementos contidos na pilha)*/
int size()
{
	return pos +1;
}
/*Função Peep (devolve o valor que esta no topo da pilha)*/
int stackpop()
{
	return pilha[pos];
}
/*Função Peep (devolve o valor que esta no topo da pilha)*/
int stackpop2()
{
	return pilha2[pos2];
}
/*Função isEmpty (devolve 0 se pilha vazia
devolve 1 se pilha nao vazia)*/
int empty()
{
	if (pos == -1)
	{
		return 0;
	}
	else
	{
		return 1;
	}
}
int main ()
{
	/*Vari�veis Locais*/
	int varLer;
	
	/*Apresentacao do programa*/
	printf("\n Este programa serve para manipular pilhas.\n");
	printf("\n");
	create();
	/*Chamar o Procedimento CreateS*/
	printf("\n [CreateS]\tA pilha foi criada...\t");
	printf("\n\n");
	/*Chamar o Procedimento CreateS*/
	create2();
	printf("\n [CreateS]\tFoi criada uma segunda pilha para armazenamento de valores...\t");
	printf("\n\n");
	/*Ciclo de Repetição*/
	int repetir = 0;
	do 
	{
		/*Menu do programa*/
		int menu;
		printf("\n\t1 - Inserir Valor na Pilha\n\t2 - Apresentar o Valor no Topo da Pilha\n\t3 - Apresentar o Numero de Elementos na Pilha\n\t4 - Apresentar Todos os Valores da Pilha\n\t5 - Apresentar Todos os Valores da Pilha e Guarda-los\n\t6 - Verificar se a Pilha se Encontra Vazia\n\t7 - Sair\n");
		printf("\n Qual a opcao:\t");
		scanf("%d",&menu);
		printf("\n");

		switch (menu)
		{
			case 1:
				/*Chamar o Procedimento Push*/				
				printf("\n [Push]\tIntroduza o valor do topo da pilha:\t");
				scanf("%d",&varLer);
				push(varLer);
				printf("\n");
				break;
			case 2:
				/*Chamar a Função Peep*/
				printf("\n [Peep]\tO valor apresentado refere o valor no topo da pilha:\t");
				printf("%d",stackpop());
				printf("\n\n");
				break;
			case 3:
				/*Chamar a Função Size*/
				printf("\n [Size]\tO valor apresentado refere a dimensao da pilha:");
				printf("\t");
				printf("%d",size());
				printf("\n\n");
				break;
			case 4:
				
				
				
				/*Chamar a Função Pop*/
				printf("\n [Pop]\tO valor do topo da pilha:\t");
				//printf("%d",pop());
				push2(pop());
				push(pop2());				
				printf("%d",stackpop());
				
				printf("\n\n");
				break;
			case 5:
				/*Chamar a Função Pop*/
				printf("\n [Pop]\tO valor apresentado transitou para a segunda pilha:\t");
				//printf("%d",pop());
				push2(pop());
				printf("%d",stackpop2());
				printf("\n\n");
				break;
			case 6:
				/*Chamar a Função isEmpty*/
				if (empty()==0)
				{
					printf("\n [isEmpty]\tA pilha encontra-se vazia");
					printf("\n\n");
				}
				else
				{
					printf("\n isEmpty\tA pilha encontra-se preenchida");
					printf("\n\n");
				}
				break;
			case 7:
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

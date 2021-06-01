#include <stdio.h>
#include <stdlib.h>
#include <stdio.h>
#include <stdlib.h>
/*Variáveis globais do programa*/
int pilha[10];
int pos;
/*Procedimento CreateS (Define que o valor da posicao inicial na pilha é -1)*/
void create()
{
	pos = -1;
}
/*Procedimento Push (introduz um valor no topo da pilha)*/
void push(int valor)
{
	pos = pos +1;
	pilha[pos] = valor;
}
/*Função Pop (remove o ultimo valor da pilha)*/
int pop()
{
	int valor;
	valor = pilha [pos];
	pos = pos -1;
	return valor;
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
	/*Variaveis locais*/
	int i;
	int j;	
	int varLer;	
	/*Apresentacao do programa*/
	printf("\n Este programa serve para manipular pilhas.\n");
	printf("\n");
	create();
	printf("\n [CreateS]\tA pilha foi criada com dez posicoes...\t");
	printf("\n\n");	
	/*Ciclo de Repetição*/
	int repetir = 0;
	do 
	{
		/*Menu do programa*/
		int menu;
		printf("\n\t1 - Tabuada\n\t2 - Inserir Valor na Pilha\n\t3 - Remover Valor da Pilha\n\t4 - Apresentar o Tamanho de Valores na Pilha\n\t5 - Apresentar o Valor no Topo da Pilha\n\t6 - Verificar se a Pilha se Encontra Vazia\n\t7 - Sair\n");
		printf("\n Qual a opcao:\t");
		scanf("%d",&menu);
		printf("\n");
		switch (menu)
		{
			case 1:
				/*Chamar o Procedimento CreateS*/
				printf("\n Insira um numero (entre 1 e 10):\n");
				printf("\n ");
				scanf("%d", &i);				
				for (j=1; j<=10 ; j=j+1) 
				{	
					varLer = (i*j);		
					push(varLer);
					printf("\n %d * %d = %d\n", i, j, (i*j));
				}		
				break;
			case 2:
				/*Chamar o Procedimento Push*/
				
				printf("\n [Push]\tIntroduza o valor do topo da pilha:\t");
				scanf("%d",&varLer);
				push(varLer);
				printf("\n");
				break;
			case 3:
				/*Chamar a Função Pop*/
				printf("\n [Pop]\tO valor apresentado foi removido do topo da pilha:\t");
				printf("%d",pop());
				printf("\n\n");
				break;
			case 4:
				/*Chamar a Função Size*/
				printf("\n [Size]\tO valor apresentado refere a dimensao da pilha:");
				printf("\t");
				printf("%d",size());
				printf("\n\n");
				break;
			case 5:
				/*Chamar a Função Peep*/
				printf("\n [Peep]\tO valor apresentado refere o valor no topo da pilha:\t");
				printf("%d",stackpop());
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
					printf("\n [isEmpty]\tA pilha encontra-se preenchida");
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
	system("pause");
}
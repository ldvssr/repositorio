#include <stdio.h>
#include <stdlib.h>
int vetor[10];
//Ordenação por Inserção
void ordenacaoInsercao()
{
	int p;
	p=1;
	int tmp,j;
	while (p<10)
	{
		tmp=vetor[p];
		j=p;
		while (j > 0 && tmp < vetor [j-1])
		{
			vetor[j]=vetor[j-1];
			j=j-1;
		}
		vetor[j]=tmp;
		p=p+1;
	}
}
//Ordenação por Seleção
void ordenacaoSelecao()
{
	int i, j, min, aux;
	i=0;
	while (i<10-1)
    {
        min=i;
        j=i+1;
        while(j<10)
        {
            if (vetor[j]<vetor[min])
            {
                min=j;
            }
            j=j+1;
        }
        aux = vetor[i];
        vetor[i]=vetor[min];
        vetor[min]=aux;
        i=i+1;
    }
}
int main()
{
int x, valor;
/*Ciclo de Repeti��o*/
int repetir = 0;
do
{
    
    /*Menu do programa*/
		int menu;
		printf("\n\t1 - Preencher vetor\n\t2 - Ordenar por Insercao\n\t3 - Ordenar por Selecao\n\t4 - Sair\n");
		printf("\n Qual a opcao:\t");
		scanf("%d",&menu);
		printf("\n");
    switch (menu)
    {
	
    		case 1:
    			//Preencher um vetor.
	
    x=0;
    do
    {
        printf("\n Insira um valor: ");
        scanf("%d",&vetor[x]);
        x=x+1;
    }
    while (x<10);
    		break;
		
			case 2:
				ordenacaoInsercao(vetor);
				x=0;
    do
    {
        printf(" O valor da posicao %d e: %d\n",x,vetor[x]);        
        x=x+1;
    			}
			    while (x<10);
			break;
			case 3:
				ordenacaoSelecao(vetor);
				x=0;
   				 do
   				 {
       				 printf(" O valor da posicao %d e: %d\n",x,vetor[x]);        
      			  x=x+1;
    			}
    			while (x<10);
			break;
		    case 4:
				/*Ciclo de Repeti��o*/
				printf("\n\tDeseja mesmo sair? 0 - Nao / 1 - Sim \t");
				scanf(" %d", &repetir);
				printf("\n");
			break;
			}
		}
	while (repetir == 0);
	system("break");
}
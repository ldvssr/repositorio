#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct sNo
{
  int N;   /* Numero */
  struct sNo *Prox;
} NO;


/*
 *  Inicializar uma Pilha
 */
void Inic(NO** Pilha)
{
  *Pilha=NULL;
}

/*
 *  Insere um novo registo no Topo da Pilha
 */
void Push(NO** Pilha, int Num)
{ NO * Tmp;
  Tmp = (NO*) malloc(sizeof(NO));
	if (Tmp==NULL) return;
	Tmp->N = Num;
	Tmp->Prox=*Pilha;
	*Pilha=Tmp;
}



int Empty(NO * Pilha)
{
 return (Pilha==NULL);
}

/*
 *  Apaga o elemento do topo da Pilha (se existir)
 */
void Pop(NO** Pilha)
{ NO *Tmp = *Pilha;

  if (Empty(*Pilha))  /* Nao existem elementos */
	 return;

  *Pilha = (*Pilha)->Prox;
  free(Tmp);
}

/*
 * Listar todos os elementos da Pilha Recursivamente
 */

void Print(NO* Pilha)
{
  if (Empty(Pilha))
	 return; /* Nao existem elementos */
  printf("%d \n",Pilha->N);
  Print(Pilha->Prox); /* Lista os outros */
}

/* Devolve o ELemento do Topo da Pilha. Supoe-se que sao todos positivos */
int Top(NO *Pilha)
{
  if (Empty(Pilha))
	 return -1; /* Nao existem elementos */
  return Pilha->N;

}

main()
{
  NO* P;
  Inic(&P);
  printf("%s esta vazia\n",Empty(P)?"":"Nao");
  Print(P);
  puts("Push: 10");
  Push(&P,10);
  puts("Push: 20");
  Push(&P,20);
  puts("Push: 30");
  Push(&P,30);
  printf("%s esta vazia\n",Empty(P)?"":"Nao");
  Print(P);
  puts("Pop: ");
  Pop(&P);
  Print(P);
  puts("Pop: ");
  Pop(&P);
  Print(P);
  puts("Pop: ");
  Pop(&P);
  Print(P);
  printf("%s esta vazia\n",Empty(P)?"":"Nao");
}


#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct sNo
{
  unsigned int N;   /* Numero positivo */
  struct sNo *Prox;
} LISTA;


/*
 *  Inicializar uma Lista
 */
void Inic(LISTA** Lista)
{
  *Lista=NULL;
}

/*
 *  Insere um novo registo na Lista
 */
unsigned Inserir(LISTA** Lista, unsigned int Num)
{ LISTA * Tmp;
  if (Num%2==1 || *Lista==NULL) /* Se for Impar ´e logo inserido */
    {  Tmp = (LISTA*) malloc(sizeof(LISTA));
      if (Tmp==NULL) return 0;
      Tmp->N = Num;
      Tmp->Prox=*Lista;
      *Lista=Tmp;
      return Num;
    }
  else
   return Inserir(&(**Lista).Prox,Num);
}


/*
 *  Apaga o primeiro elemento da Lista (se existir)
 */
unsigned Retirar(LISTA** Lista, unsigned Num)
{ LISTA *Tmp;

  if (*Lista==NULL)  /* Num nao existe na Lista */
   return 0;

  if ((**Lista).N!=Num)  /* nao e o elemento a apagar */
   return Retirar(&(**Lista).Prox,Num);
  else
    { unsigned so_para_devolver = (**Lista).N;
     Tmp =*Lista;
     *Lista = (*Lista)->Prox;
     free(Tmp);
     return so_para_devolver;
    }
}

/*
 * Listar todos os elementos da Lista Recursivamente
 */

void Print(LISTA* Lista)
{
  if (Lista==NULL)
   return; /* Nao existem elementos */
  printf("%d \n",Lista->N);
  Print(Lista->Prox); /* Lista os outros */
}



main()
{ int i;
  LISTA* P;
  Inic(&P);
  Print(P);
  puts("Inserir: 10..5");
  for (i=10;i<=15;i++)
   Inserir(&P,i);
  Print(P);
  puts("Inserir: 13");
  Inserir(&P,13);
  Print(P);
  puts("Retirar 12");
  Retirar(&P,12);
  Print(P);
  puts("Retirar 13 ");
  Retirar(&P,13);
  Print(P);
  puts("Retirar 13 ");
  Retirar(&P,13);
  Print(P);
  puts("Retirar 13 ");
  Retirar(&P,13);
  Print(P);
}

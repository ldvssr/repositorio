#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct sPessoa
{
  int Idade;
  char Nome[20+1];
  struct sPessoa *Prox;
} PESSOA;

typedef PESSOA* FILA ;

/*
 *  Inicializar uma Fila
 */
void Inic(FILA* Fila)
{
  *Fila=NULL;
}

/*
 *  Insere um novo registo no fim da Fila
 */

void Inserir(FILA* Fila, int Idade, char* Nome)
{
  if (*Fila==NULL)
	 {
		*Fila = (FILA) malloc(sizeof(PESSOA));
		if (*Fila==NULL) return;
		(*Fila)->Idade = Idade;
		strcpy((*Fila)->Nome, Nome);
		(**Fila).Prox=NULL;
	 }
  else
	 Inserir(& (**Fila).Prox, Idade, Nome);
}

/*
 *  Apaga o primeiro elemento da Fila (se existir)
 */
void Apagar(FILA* Fila)
{ PESSOA *Tmp = *Fila;

  if (*Fila==NULL)  /* Nao existem elementos */
	 return;

  *Fila = (*Fila)->Prox;
  free(Tmp);
}

/*
 * Listar todos os elementos da Fila Recursivamente
 */

void Listar(FILA Fila)
{
  if (Fila==NULL)
	 return; /* Nao existem elementos */
  printf("%d %s\n",Fila->Idade, Fila->Nome);
  Listar(Fila->Prox); /* Lista os outros */
}

main()
{
  FILA F;
  Inic(&F);
  puts("Inicializar:");
  Listar(F);
  puts("Inserir:");
  Inserir(&F,10,"Tiago");
  Inserir(&F,20,"Luisa");
  Inserir(&F,30,"Ana");
  puts("Listar 3");
  Listar(F);
  Apagar(&F);
  puts("Listar 2");
  Listar(F);
  Apagar(&F);
  puts("Listar 1");
  Listar(F);
  Apagar(&F);
  puts("Listar Nada");
  Listar(F);
  Apagar(&F);
  puts("Listar Nada");
  Listar(F);

}

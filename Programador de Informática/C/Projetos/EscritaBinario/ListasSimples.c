/*
Nome: Apontadores para apontadores
Autor: Daniel Ventura
Data: 06/08/2021
Descrição: Verificar o que são apontadores para apontadores
*/
#include <stdio.h>
#include <stdlib.h>
#include "lista.h"
#pragma warning(disable:4996)
void printList(struct Node* n)
{
	while (n != NULL)
	{
		printf("\n%d", n->data);
		n = n->next;
	}
}
int main5()
{
	struct Node* head = NULL;
	struct Node* second = NULL;
	struct Node* third = NULL;
	head = (struct Node*)malloc(sizeof(struct Node));
	second = (struct Node*)malloc(sizeof(struct Node));
	third = (struct Node*)malloc(sizeof(struct Node));
	head->data = 1;
	head->next = second;
	second->data = 2;
	second->next = third;
	third->data = 3;
	third->next = NULL;
	printList(head);
	free(head);
	getche();
	return 0;
}
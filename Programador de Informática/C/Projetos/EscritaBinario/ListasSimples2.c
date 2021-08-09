/*
Nome: Lista Simples Ligada 2
Autor: Daniel Ventura
Data: 09/08/2021
Descrição: Iteração de listas simples ligadas
*/

#include <stdio.h>
#include <stdlib.h>

typedef struct
{
	int data;
	struct Node* next;
}Node;

Node* head = NULL;

void printList()
{
	Node* ptr = head;
	while (ptr != NULL)
	{
		printf("%d", ptr->data);
		ptr = ptr->next;
	}
}

void insert(int data)
{
	Node* ptr = (Node*)malloc(sizeof(Node));
	ptr->data = data;
	ptr->next = head;
	head = ptr;
}

int main()
{
	insert(10);
	insert(20);
	insert(39);
	insert(42);

	printList();

	getche();
	return 0;
}
/*
Nome: Lista Simples Ligada 2
Autor: Daniel Ventura
Data: 09/08/2021
Descrição: Iteração de listas simples ligadas
*/

#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>

typedef struct
{
	int data;
	struct Node* next;
}Node;

Node* head = NULL;

void printList1()
{
	Node* ptr = head;
	while (ptr != NULL)
	{
		printf("\n%d", ptr->data);
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

void insertEnd(int data)
{
	Node* newNode = (Node*)malloc(sizeof(Node));
	newNode->data = data;
	newNode->next = NULL;
	Node* link = head;
	if (head == NULL) head = newNode;
	else
	{
		while (link->next != NULL)
		{
			link = link->next;
		}
		link->next = newNode;
	}
}

int getCount(Node* head)
{
	int count = 0;
	Node* temp = head;
	while (temp!=NULL)
	{
		count++;
		temp = temp->next;
	}
	return count;
}

bool search(int y)
{
	Node* current = head;
	while (current != NULL)
	{
		if (current->data == y) return true;
		current = current->next;
	}
	return false;
}

void deleteNode(int key)
{
	Node* temp = head, * prev = NULL;
	if (temp != NULL && temp->data == key)
	{
		head = temp->next;
		free(temp);
		return;
	}
	while (temp != NULL && temp->data != key)
	{
		prev = temp;
		temp = temp->next;
	}
	if (temp == NULL)return;
	prev->next = temp->next;
	free(temp);
}

int main6()
{
	insertEnd(10);
	insertEnd(20);
	insertEnd(30);
	insertEnd(40);
	insertEnd(50);

	printf("\n%s", search(30) ? "true" : "false");

	printf("\n%d elementos", getCount(head));

	printList1();

	deleteNode(50);

	printList1();

	//Explicação de operadores ternários.
	int a = 10, b = 25, c;
	if (a < b)
	{
		c = a;
	}
	else
	{
		c = b;
	}
	printf("%d", c);
	//Operador ternário.
	c = (a < b) ? a : b;
	printf("%d", c);

	getche();
	return 0;
}
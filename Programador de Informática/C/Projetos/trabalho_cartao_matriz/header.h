//bibliotecas + assinaturas das funções + estruturas + constantes
#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <time.h>

#pragma warning (disable: 4996)

struct Node {
	int data[5];
	struct Node* next;
};

struct Node* head; 
struct Node* temp;
//bibliotecas + assinaturas das fun��es + estruturas + constantes
#include <stdio.h>
#include <locale.h>
#include <stdlib.h>
#include <time.h>

#define COLUNAS 8
#define LINHAS 6
#define POSICOES 3

#pragma warning (disable: 4996)

//cria��o da struct.
struct Node {
	int data[POSICOES];
	struct Node* next;
};

struct Node* head; 
struct Node* temp;
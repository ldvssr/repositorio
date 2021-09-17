#include "header.h"

//função para gerar random numeros.
int RandomNum(int x) {
	int y = rand() % x;
	return y;
}
void insert(int a, int b, int c, int d, int e) { 
	//cria o node com os valores inseridos e insere na lista ligada 
	  
	 struct Node* novoNode = (struct Node*)malloc(sizeof(struct Node));  
	//inicializar estrutura   
	novoNode->data[0] = a;   
	novoNode->data[1] = b;    
	novoNode->data[2] = c;    
	novoNode->data[3] = d;   
	novoNode->data[4] = e;   
	novoNode->next = NULL;   
	//verifica se ja existe o head  
	if (head == NULL) {
		// se head NULL novo node passa a ser head  
		head = novoNode;    
		temp = head;    
		return; 

	}else{

		// senao percorre a lista ate o next ser NULL 
		while (temp->next != NULL) {  
			temp = temp->next;         }
		// next passa a ser o novo node
		temp->next = novoNode;    
	} 
}

int CriarCartao() {
	int x = 0;

	printf("   1   2   3   4   5   6   7   8");
	char letras[26] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	while (x < 7) {
		printf("\n%c", letras[x]);
		x++;
		int y = 0;
		while (y<8) {
			insert(RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10));
			y++;
			int z = 0;
			printf(" ");
			while (z < 3) {
				printf("%d", temp->data[z]);
				z++;
			}
		}
	}
}

int EscolheNumLetra() {
	int contar = 0;
	char letras[26] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

	while (contar < 3) {
	int nlinha = RandomNum(6);
	int ncoluna = RandomNum(8) + 1;
	int npos = RandomNum(3) + 1;
	char linha = letras[nlinha];

	
	printf("\n\n");
	printf("\n Indique a linha %c, Coluna %d, posição %d", linha, ncoluna, npos);
	printf("\n\n");

		// Inserção
		int num1;
		scanf("%d", &num1);

		//ValiDAÇÃO

		int cont = 0;
		temp = head;
		while (cont < nlinha * 8 + ncoluna - 1) {

			cont++;
			temp = temp->next;


		}
		if (num1 == temp->data[npos - 1]) {
			printf("Parabéns acertaste nabo");

		}
		else {
			printf("erraste burro");
		}contar++;


	}
	
}



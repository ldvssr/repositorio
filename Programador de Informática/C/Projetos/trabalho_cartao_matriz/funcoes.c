#include "header.h"

//fun��o para gerar numeros aleatorios.
int RandomNum(int x) {
	int y = rand() % x;
	return y;
}

//cria o node com os valores inseridos e insere na lista ligada 
void insert(int a, int b, int c, int d, int e) { //DEFINIR INTS A PARTIR DAS POSI��ES DO ARRAY DA ESTRUTURA.
	
	  
	 struct Node* novoNode = (struct Node*)malloc(sizeof(struct Node)); 

	//inicializar estrutura   --- PRECISA SER RESTRUTURADO com Fun�ao.
	novoNode->data[0] = a;   
	novoNode->data[1] = b;    
	novoNode->data[2] = c;    
	novoNode->data[3] = d;   
	novoNode->data[4] = e;   
	novoNode->next = NULL;   

	//verifica��o do head  
	if (head == NULL) {

		// se head NULL novoNode passa a ser head  
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
//fun��o de cria��o do cart�o matriz
int CriarCartao() {
	int x = 0;
	printf("  ----------CARTAO MATRIZ--------\n");
	printf("   1   2   3   4   5   6   7   8");
	char letras[26] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //-->COLOCAR LETRAS A PARTIR DA TABELA ASCII

	//cria��o das linhas
	while (x < LINHAS) {
		printf("\n%c", letras[x]);
		x++;
		int y = 0;
		//cria��o das colunas
		while (y < COLUNAS) {

			//----->TORNAR MODULAR = MENOS REPETI��O
			insert(RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10));
			y++;
			int z = 0;
			printf(" ");

			//cria�ao de conjunto de numeros aleatorios dentro do Node.
			while (z < POSICOES) {
				printf("%d", temp->data[z]);
				z++;
			}
		}
	}
}

//fun��o de verifica��o de seguran�a do cart�o matriz
int EscolheNumLetra() {
	int contar = 0;
	char letras[26] = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //-->COLOCAR LETRAS A PARTIR DA TABELA ASCII

	//escolha aleatoria da linha e coluna e numero contido no Node. ---- EVITAR REPETI��O.
	while (contar < 3) {
	int nlinha = RandomNum(6);
	int ncoluna = RandomNum(8) + 1;
	int npos = RandomNum(3) + 1;
	char linha = letras[nlinha];

	
	printf("\n\n");
	printf("\n Indique a linha %c, Coluna %d, posi��o %d", linha, ncoluna, npos);
	printf("\n\n");

		// Inser��o do valor de resposta
		int num1;
		scanf("%d", &num1);

		//Valida��o da escolha 

		int cont = 0;
		temp = head;
		while (cont < nlinha * 8 + ncoluna - 1) {

			cont++;
			temp = temp->next;


		}
		if (num1 == temp->data[npos - 1]) {
			printf("Parab�ns acertaste!");

		}
		else {
			printf("Errado!");
		}contar++;


	}
	
}



/*
* Autor: Lic�nio Daniel 
* Data: 16 de setembro de 2021
* Vers�o: 1.0
* E-mail: ldvssr@icloud.com
* Descri��o: Trabalho Cart�o Matriz
* Observa��es: 
*/
#include "header.h"

#pragma warning (disable: 4996)
#pragma region Main
int main()
{
	setlocale(LC_ALL, "Portuguese");
	srand(time(NULL));
	insert(RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10));
	//printf("%d %d %d %d %d", temp->data[0],temp->data[1],temp->data[2],temp->data[3],temp->data[4]);
	CriarCartao();
	EscolheNumLetra();
	
}
#pragma endregion

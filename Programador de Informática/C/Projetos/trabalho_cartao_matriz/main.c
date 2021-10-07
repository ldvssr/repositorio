/*
* Autor: João Guimarães/ Licínio Daniel 
* Data: 14 de setembro de 2021
* Versão: 2.0
* E-mail: joaopguimaraes@gmail.com/ ldvssr@icloud.com
* Descrição: Trabalho Cartão Matriz
* Observações: 
*/
#include "header.h"

#pragma warning (disable: 4996)
#pragma region Main
int main()
{
	setlocale(LC_ALL, "Portuguese");
	srand(time(NULL));
	insert( RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10)); //modificar ---> chamar função consoante 
	CriarCartao();
	EscolheNumLetra();
	
}
#pragma endregion

/*
* Autor: Jo�o Guimar�es/ Lic�nio Daniel 
* Data: 14 de setembro de 2021
* Vers�o: 2.0
* E-mail: joaopguimaraes@gmail.com/ ldvssr@icloud.com
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
	insert( RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10), RandomNum(10)); //modificar ---> chamar fun��o consoante 
	CriarCartao();
	EscolheNumLetra();
	
}
#pragma endregion

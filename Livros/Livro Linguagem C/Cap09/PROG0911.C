#include <stdio.h>

int Ler_Inteiro(char *Prompt)
{
	int n;
	do
	{
		printf(Prompt);
		scanf("%d",&n);
	}
	while (n<0);
	return n;
}

main()
{
  int Idade, Total;
  Idade = Ler_Inteiro("Introd. a Idade: ");
  Total = Ler_Inteiro("Qual o Total a Depositar\n\t");
}

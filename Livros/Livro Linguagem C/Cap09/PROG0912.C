#include <stdio.h>

void Ler_Inteiro(char *Prompt, int *ptr_valor)
{
	do
	{
		printf(Prompt);
		scanf("%d",ptr_valor);
	}
	while (*ptr_valor<0);
}

main()
{
	int Idade, Total;
	  Ler_Inteiro("Introd. a Idade: ", &Idade);
   Ler_Inteiro("Qual o Total a Depositar\n\t",&Total);
   printf("Idade: %d \n\nTotal: %d\n",Idade,Total);
}

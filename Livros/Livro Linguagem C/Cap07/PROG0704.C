#include <stdio.h>


main()
{
char Nome[100];
while (1) /* Ciclo Infinito */
	{
		puts("Nome:");
		gets(Nome);
		if (Nome[0]=='\0') 	/* Se a string estiver vazia */
			break;	 	/* Terminar o ciclo          */
		else
      printf("Nome Introduzido: %s\n",Nome);
	}
}

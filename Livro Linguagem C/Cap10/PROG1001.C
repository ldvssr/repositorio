#include <stdio.h>

main()
{
	FILE *fp;
	char s[100];

	puts("Introduza o Nome do Ficheiro:");
	gets(s);

	/* Abrir o Ficheiro */
	fp = fopen(s,"r");

	/* Verificar se a abertura foi feita com sucesso */
	if (fp==NULL)
		printf("Impossível abrir o ficheiro %s\n",s);
	else
		{
		 printf("Ficheiro %s aberto com sucesso!!!\n",s);
		 fclose(fp);
		}
}

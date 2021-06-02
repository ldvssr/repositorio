#include <stdio.h>
#include <stdlib.h> 

main(int argc, char*argv[])
{
	FILE *fp;
	char Nome[100];
	int Nota;

	/* Testar a Linha de Comando */
	if (argc!=2)
		{
		  printf("Sintaxe: \n\n%s Ficheiro\n\n",argv[0]);
		  exit(1);  /* Termina o Programa */
		}

	/* Abrir o Ficheiro com o nome em argv[1] */
	if ((fp = fopen(argv[1],"r"))==NULL)
		{ printf("Impossível abrir o ficheiro %s\n",argv[1]);
		  exit(2);
		}

	while (fscanf(fp,"%s %d",Nome,&Nota)!=EOF)
	  if (Nota>=10)
	    printf("%s %d\n",Nome,Nota);

	fclose(fp);
}

#include <stdio.h>
#include <stdlib.h> /* Por causa da função exit */

main()
{
	FILE *fp;
	int i=0, valor,n;

		/* Abrir o Ficheiro DADOS.DAT */
	if ((fp = fopen("DADOS.DAT","rb"))==NULL)
		{ printf("Impossível Abrir o ficheiro %s\n","DADOS.DAT");
		  exit(1);
		}

	while (fread(&valor,sizeof(int),1,fp))
		printf("%2dº Nº: %d\n",++i,valor);

	fclose(fp);
}

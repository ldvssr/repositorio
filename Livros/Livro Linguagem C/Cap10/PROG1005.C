#include <stdio.h>
#include <stdlib.h> /* Por causa da fun��o exit */

main()
{
	FILE *fp;
	int i=0, valor,n;

		/* Abrir o Ficheiro DADOS.DAT */
	if ((fp = fopen("DADOS.DAT","rb"))==NULL)
		{ printf("Imposs�vel Abrir o ficheiro %s\n","DADOS.DAT");
		  exit(1);
		}

	while (fread(&valor,sizeof(int),1,fp))
		printf("%2d� N�: %d\n",++i,valor);

	fclose(fp);
}

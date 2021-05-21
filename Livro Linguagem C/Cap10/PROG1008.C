#include <stdio.h>
#include <stdlib.h> /* Por causa da função exit */

main(int argc, char*argv[])
{
	FILE *fp;
	long int nBytes=0;

	if (argc!=2)
		 {printf("Sintaxe:\n\n%s ficheiro\n\n",argv[0]);
		  exit(1);
		}

	if ((fp = fopen(argv[1],"rb"))==NULL) /* Binario */
		{ printf("Impossível Abrir o ficheiro %s\n",argv[1]);
		  exit(2);
		}

  /* Acesso Sequencial Byte a Byte */

	while (fgetc(fp)!=EOF) /* Ler um char */
			nBytes++;
	fclose(fp);

  printf("Dim. do Ficheiro: %ld\n",nBytes);
}


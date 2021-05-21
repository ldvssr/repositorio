#include <stdio.h>
#include <stdlib.h> /* Por causa da função exit */

main()
{
  FILE *fp;
  float x;

  /* Abrir o Ficheiro DADOS.DAT */
  if ((fp = fopen("DADOS.DAT","rb"))==NULL)
    { printf("Impossível Abrir o ficheiro %s\n","DADOS.DAT");
      exit(1);
    }

 while (1)
  {
   if (fread(&x,sizeof(float),1,fp)==0) /* Falhou a Leitura */
      break;
    printf("%f\n",x);
    fseek(fp,sizeof(float),SEEK_CUR);
  }
  fclose(fp);
}

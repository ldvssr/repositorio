#include <stdio.h>
#include <stdlib.h> /* Por causa da função exit */

main()
{
  FILE *fp;
  int i, v[10];

  /* Ler os Dados a partir do Teclado */
  for (i=0; i<10; i++)
    {
      printf("Introd. o %d-esimo Nº: ",i+1);
      scanf("%d",&v[i]);
    }


  /* Abrir o Ficheiro DADOS.DAT */
  if ((fp = fopen("DADOS.DAT","wb"))==NULL)
    { printf("Impossível Criar o ficheiro %s\n","DADOS.DAT");
      exit(1);
    }

 if (fwrite(v,sizeof(int),10,fp)!=10)
   fprintf(stderr, "Não foram escritos todos os elementos!!!\n");

  fclose(fp);
}

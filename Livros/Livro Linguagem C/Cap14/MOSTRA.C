#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define MAX_LIN 80

void Mostra(FILE*, char *, int pos1, int pos2);

main(int argc, char *argv[])
{
  int i;			/* Para percorrer os Parametros */
  FILE *fin, *fout=stdout;	/* Ficheiros de Entrada e Saida */
  char linha[MAX_LIN+1];	/* Variavel com a linha do Fich */

  int pos1=1, pos2=80;

  /* Testar a existencia do Parametro do ficheiro de Output */
  if (strnicmp(argv[argc-1],"-o",2)==0)
   { if ((fout=fopen(argv[argc-1]+2,"wt"))==NULL)
       { /* O ficheiro nao foi criado */
         fprintf(stderr,"Impossivel Criar o Ficheiro %s\nOutput para o ecran\n",argv[argc-1]+2);
         fout = stdout;
       }
     argc--;	/* Ultimo parametro ja foi tratado */
   }
  i=1;

  /* Verificar se temos -pos1 */
  if (argc>i && argv[i][0]=='-')
    { pos1 = atoi(argv[i]+1);
      /* Garantir que pos1 esta entre 1..MAX_LIN */
      pos1 = min(max(pos1,1),MAX_LIN);
      i++;

      if (argc>i && argv[i][0]=='-')
        { pos2 = atoi(argv[i]+1);
          pos2 = max(1,min(pos2,MAX_LIN));
          i++;
        }
    }

  for( ; i< argc; i++)
   {
    fin = fopen(argv[i],"rt");
    if (fin==NULL) continue; /* Passa ao proximo */
    fprintf(fout,"%s\n",argv[i]);
    while (fgets(linha,MAX_LIN+1,fin)!=NULL)
      { /* Retirar o '\n' */
         if (linha[strlen(linha)-1]=='\n') linha[strlen(linha)-1]='\0';
        Mostra(fout,linha,pos1,pos2);
      }
    fclose(fin);
  }
}

/*
 * Mostra os caracteres existentes entre as posiçoes pos1 .. pos2
 * na string s
 */
void Mostra(FILE *fp, char *s, int pos1, int pos2)
{
  int len = strlen(s),i;
  for (i=pos1; i<=pos2 && i<=len ; i++)
	 fputc(s[i-1],fp); /* Strings em C começam no indice 0 */
  fputc('\n',fp);

}



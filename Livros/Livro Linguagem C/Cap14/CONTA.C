#include <stdio.h>
#include <string.h>
#include <stdlib.h>

#define OPCAO "-l"

enum BOOL {FALSE,TRUE};

main(int argc, char*argv[])
{
  int mostra_linhas = FALSE;  /* Mostra ou nao o Nº das Linhas */
  int n_chars;                /* Nº de caracteres              */
  int n_linhas=0;             /* Nº da Linha Actual            */

  FILE *fp=stdin;
  int ch;



  switch(argc)
   {
    case 1: break;
    case 3: if (stricmp(argv[1],OPCAO)==0)
              mostra_linhas=TRUE;
            else
              fprintf(stderr,"Erro: Opçao Invalida...\n");
    case 2: if ((fp=fopen(argv[argc-1],"rt"))==NULL)
          {
            fprintf(stderr,"Impossivel abrir o ficheiro %s\n",
                           argv[argc-1]);
            exit(1);
          }
          break;
   default: fprintf(stderr,"Erro: Sintaxe Invalida...\n");
            exit(2);
   }

  n_chars=0;
  while ((ch=fgetc(fp))!=EOF)
   {
    if (ch!='\n')
      n_chars++;
    else
      {
       if (mostra_linhas)
         printf("%d ",++n_linhas);
       printf("%d\n",n_chars);
       n_chars=0;
      }
   }
}


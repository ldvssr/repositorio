#include <stdio.h>
#include <stdlib.h>

#define MAX_STR 120  /* Dim. da maior string */

main(int argc, char *argv[])
{
  FILE * fp;
  char s[MAX_STR+1]; /* Linha lida no ficheiro */
  int i=0;		/* Contador das linhas    */

  if (argc==1)
   {
	fprintf(stderr,"Sintaxe: Line Ficheiro\n\n");
	exit(1);
   }

 if ((fp=fopen(argv[1],"r"))==NULL)
  {
    fprintf(stderr,"Impossível Abrir o Ficheiro %s\n\n",argv[1]);
    exit(1);
  }

 while ( fgets(s,MAX_STR+1,fp)!=NULL)
   printf("%2d: %s",++i,s);

fclose(fp);	                                      	
exit(0);
}

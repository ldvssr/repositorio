#include <stdio.h>
#include <string.h>
#include <stdlib.h>

main(int argc, char *argv[])
{
  FILE * fp;
  int So_Total=0;    /* Por Defeito, processa tudo */
  int n1, n2;			/* Operandos */
  char op;           /* Operador  */
  long res, total=0L;/* Total acumulado */

if (argc==3)
 So_Total = (stricmp(argv[1],"-t")==0); /* ver se argv[2]=="-t" */

  if (argc<2 || argc >3)
	 {
		fprintf(stderr,"Sintaxe: Proc [-t] Ficheiro\n");
		exit(1);
	 }

  if ((fp=fopen(argv[argc-1],"r"))==NULL)
	 {
  	   fprintf(stderr,"Impossível Abrir o Ficheiro %s\n\n", argv[argc-1]);
		exit(2);
	 }

 while ( fscanf(fp,"%d%c%d", &n1,&op,&n2)==3) /* Leu as 3 vars */
	 {
		switch(op)
		  {
			 case '+': res = n1 + n2; break;
			 case '-': res = n1 - n2; break;
			 case '*': res = n1 * n2; break;
			 case '/': res = n1 / n2; break;
		  }
		if (!So_Total)
		  printf("%d %c %d = %ld\n",n1,op,n2,res);
		total+=res;
	 }
printf("%ld\n",total);
fclose(fp);
exit(0);
}

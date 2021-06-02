#include <stdio.h>
#define DIM 20
#define SEP_NOME ", "
main()
{
  char Nome[DIM+1], Apelido[DIM+1],Completo[2*DIM+1];
  while (1)
  {
    printf("Nome: "); gets(Nome);
    if (strlen(Nome)==0) break;		/* Terminar o Programa */
    		   /* Colocar o Apelido, Nome na string Completo */
    printf("Apelido: "); gets(Apelido);
	strcpy(Completo,Apelido);  		/* Copiar o Apelido    */
	strcat(Completo,SEP_NOME); 		/* Juntar o Separador  */
	strcat(Completo,Nome);  		/* Juntar o Prim. Nome */
	puts(Completo);
	}
}

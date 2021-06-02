#include <stdio.h>
int strlen(char *s); /* Protótipo da função */

main()
{
  char s[100];
  char *ptr = s; /* Aponta para o primeiro carácter de s */

  printf("Introduza uma String: "); gets(s);

  printf("%d\n", strlen(s));
}

int strlen(char *s)
{
char *ptr = s;	/* Guardar o endereço inicial    	*/
while (*s!='\0')	/* Enquanto não chegarmos ao fim 	*/
	 s++;		/* Incrementar o apontador 		*/

return (int) (s-ptr);	/* Devolver a diferença entre os */
}				/* endereços */

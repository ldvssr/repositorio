#include <stdio.h>
#include <string.h>
#include <stdlib.h>

main()
{ char s[200],
		 *ptr ; /* Apontador para um conjunto de chars */

  printf("Qual a sua String:"); gets(s);

  /* Alocar a memoria necessaria */
  ptr = (char *) malloc(strlen(s)+1); /* '\0' tambem conta */
  if (ptr==NULL)
	 puts("Problemas na Alocaçao da Memoria");
  else
	 {
	  /* Colocar na string outra uma cópia da string s */
	  strcpy(ptr,s);

	  /* Mostrar as duas strings */
	  printf("String Original: %s\nCopia: %s\n",s,ptr);

     /* Libertar a memoria existente em ptr */
	  free(ptr);
    }
}

#include <stdio.h>
#include <string.h>
#include <stdlib.h>


int main(void)
{
	char *str;

	/* Criar s String */
	str = (char *) malloc(10);

	/* colocar "Maria" na string str*/
	strcpy(str, "Maria");

	printf("String: %s\nEndereço:%p\n", str, str);
	str = (char *) realloc(str, 100);
	printf("String: %s\nEndereço:%p\n", str, str);

	/* Libertar a memoria */
	free(str);

   return 0;
}

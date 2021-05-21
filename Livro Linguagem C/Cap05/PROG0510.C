#include <stdio.h>

int x_toupper(char ch)
{
  if (ch >= 'a' && ch <= 'z') /* Se minúscula */
	 return ch + 'A' - 'a';
  else
	 return ch;   /* Devolve-se na mesma */
}

/* Escreve todos os caracteres em maiúsculas */

main()
{
  char c;
  while(1) /* Termina com CTRL-C */
	{
	 c=getchar();
 	 putchar(x_toupper(c));
	}
}


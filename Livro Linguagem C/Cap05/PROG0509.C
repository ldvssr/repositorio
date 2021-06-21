#include <stdio.h>

int x_isdigit(char ch)
{
  return (ch >='0' && ch <= '9');
}

/* Escreve todos os caracteres não dígitos */

main()
{
  char c;
  while(1) /* Termina com CTRL-C */
	{
	 c=getchar();
	 if (!x_isdigit(c)) /* se não for digito */
		putchar(c);
	}
}


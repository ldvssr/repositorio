#include <stdio.h>

main()
{
  linha();
  printf("Hello World\n");
  linha();
}

void linha()
{
  int i;
  for (i=1; i<=20; i++)
	 putchar('*');
  putchar('\n');
}

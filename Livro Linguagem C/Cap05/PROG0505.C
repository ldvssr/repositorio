#include <stdio.h>

linha(int num)
{
  int i;
  for (i=1 ; i<=num ; i++)
	 putchar('*');
  putchar('\n');
}

main()
{
  linha(3);
  linha(5);
  linha(7);
  linha(5);
  linha(3);
}

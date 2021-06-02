#include <stdio.h>

void f_var_static()
{
  static int var = 1;
  printf("f_var_static: %d\n",var);
  var++;
}

void f_var_normal()
{
  int var = 1;
  printf("f_var_normal: %d\n",var);
  var++;
}

main()
{ int i;

  for (i=1;i<=5;i++)
	 f_var_static();

  printf("\n\n");

  for (i=1;i<=5;i++)
	 f_var_normal();
}


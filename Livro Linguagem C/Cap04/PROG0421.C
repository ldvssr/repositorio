#include <stdio.h>

main()
{
  int n;

  do
	{
		printf("Introd. um nº: ");
		scanf("%d", &n);
	}
  while ( n < 1 || n > 100 );

  printf("Foi Introduzido o nº %d\n",n);
}

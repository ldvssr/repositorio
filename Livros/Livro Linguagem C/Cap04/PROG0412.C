#include <stdio.h>

main()
{
  int i;
  for (i=1; i<=100;i=i+1)
	 if (i==60)
		break;
	 else
		if (i%2==1) /* se i for impar */
		  continue;
		else
		  printf("%2d\n",i);
	printf("FIM DO CICLO\n");
}

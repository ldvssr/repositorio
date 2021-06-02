#include <stdio.h>

#define DEBUG
main()
{
  int i,n=0;
for (i=1; i<10; i++)
  {
	 n=n+i;
#ifdef DEBUG
  printf("DEBUG Info: i=%d n=%d\n",i,n);
#endif
  }
printf("Resultado: %d\n",n);

}

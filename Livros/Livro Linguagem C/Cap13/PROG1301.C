#include <stdio.h>

#define  Mult(x,y)  x*y

main()
{
  int x=4,y=5;
  printf("%d*%d=%d\n",x,y,Mult(x,y));
  x++;y++;
  printf("%d*%d=%d\n",x,y,Mult(x,y));
}

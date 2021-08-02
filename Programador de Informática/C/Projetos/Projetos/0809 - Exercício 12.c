#include <stdio.h>
main()
{
    int x = 5 , *px = &x;
    float y = 5.0 , *py = &y;
    printf("%d %ld\n",x,(long)px);
    printf("%d %ld\n",x+1,(long)(px+1));
    printf("%f %ld\n",y,(long)py);
    printf("%f %ld\n",y+1,(long)(py+1));
}

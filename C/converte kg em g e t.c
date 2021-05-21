#include <stdio.h>

float a;

main()

{
printf (" quilograma? \n");
scanf ("%f",&a);
printf (" %.f quilograma = %.4f grama \n",a,a*1000);
printf (" %.f quilograma = %.4f tonelada \n",a,a/1000);
}
#include <stdio.h>

float a;
float b;
float c;
float d;


main()

{

b=9;
c=5;
d=32;

printf (" valor celsius ?\n");
scanf ("%f",&a);
printf (" O resultado de 9 / 5 * %.2f celsius + 32 =\n %.2f fahrenheit ",a,b/c*a+d);
}
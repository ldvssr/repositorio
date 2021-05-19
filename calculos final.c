#include <stdio.h>

main()

{
 
float a;
float b;
int c;
int d;
float soma;
float subtracao;
float multiplicacao;
float divisao;
int resto; 
  
printf (" introduza primeiro valor ? \n");
scanf ("%f",&a);
printf (" introduza segundo valor ? \n");
scanf ("%f",&b);

printf (" O resultado de %.f + %.f = %.f \n",a,b,a+b);

printf (" O resultado de %.f - %.f = %.f \n",a,b,a-b);

printf (" O resultado de %.f x %.f = %.f \n",a,b,a*b);

printf (" O resultado de %.f : %.f = %.2f \n",a,b,a/b);

c = a;
d = b;

printf (" O resultado de %d : %d = resto %d", c, d,c % d);

}
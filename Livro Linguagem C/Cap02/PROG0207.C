#include <stdio.h>

main()
{
float raio, perimetro;
double Pi = 3.1415927, area;

  printf("Introduza o Raio da Circunferência: ");
  scanf("%f", &raio);
  area = Pi * raio * raio;
  perimetro = 2 * Pi * raio;

  printf("Area = %f\nPerimetro = %f\n", area , perimetro);
}

#include <stdio.h>

main()
{ float x;
  printf("Introduza um Nº real: ");
  scanf("%f",&x);
  printf("Parte Inteira     : %d\n",(int) x);
  printf("Parte Fraccionaria: %f\n", x - ((int) x));

}


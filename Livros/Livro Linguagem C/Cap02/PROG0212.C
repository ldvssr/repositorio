#include <stdio.h>

main()
{ char ch1, ch2;
  printf("Introduza um Carácter: ");
  scanf("%c",&ch1);
  printf("Introduza outro Carácter: ");
  scanf(" %c",&ch2);
  printf("Os caracteres introduzidos foram '%c' e '%c'\n", ch1,ch2);
}

#include <stdio.h>

main()
{ int num=1000;
  printf("Introduza um Carácter: ");
  scanf("%c",&num);
  printf("O valor de num = %d cujo carácter = '%c'\n",
			 num,(char) num);
}

#include <stdio.h>

main()
{
  char Est_Civil;
  printf("Qual o estado Civil: ");
  scanf(" %c",&Est_Civil); /* ou Est_Civil = getchar(); */
  switch(Est_Civil)
	 {
		case 'C': printf("Casado\n");
		case 'S': printf("Solteiro\n");
		case 'D': printf("Divorciado\n");
		case 'V': printf("Viúvo\n");
		default : printf("Estado Civil Incorrecto\n");
	 }
}


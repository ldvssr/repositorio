#include <stdio.h>
main()
{
  int mes, n_dias;
  printf("Introd. o nº do mes 1..12: ");scanf("%d",&mes);
  switch(mes)
	 {
		case  2: n_dias = 28; break;
		case  4:
		case  6:
		case  9:
		case 11: n_dias = 30; break;
		default: n_dias = 31;
	 }
  printf("O mes %d tem %d dias\n",mes,n_dias);
}

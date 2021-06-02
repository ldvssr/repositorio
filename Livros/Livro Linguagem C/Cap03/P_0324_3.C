#include <stdio.h>
main()
{
  int mes, n_dias=0;
  printf("Introd. o nº do mes 1..12: ");scanf("%d",&mes);
  switch(mes)
	 {
		case  1: /* 31 dias */
		case  3:
		case  5:
		case  7:
		case  8:
		case 10:
		case 12: n_dias = n_dias + 1;
		case  4: /* 30 dias */
		case  6:
		case  9:
		case 11: n_dias = n_dias + 2;
		default: n_dias = n_dias + 28;
	 }
  printf("O mes %d tem %d dias\n",mes,n_dias);
}

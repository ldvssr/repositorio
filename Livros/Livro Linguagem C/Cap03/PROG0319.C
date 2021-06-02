#include <stdio.h>

main()
{
  int n_horas;
  long res;
  char tipo;
  printf("Nº de Horas: "); scanf("%d",&n_horas);
  printf("O que Mostrar (m/s/d): ");
  scanf(" %c", &tipo);
  switch(tipo)
	 {
		case 'm':
		case 'M': res = n_horas<0 ? 0 : n_horas * 60L;
                    break;
		case 's':
		case 'S': res = n_horas<0 ? 0 : n_horas * 3600L;
                    break;
		case 'd':
		case 'D': res = n_horas<0 ? 0 : n_horas * 36000L;
                    break;
	 }
  printf("%dh --> %ld%c ",n_horas,res,tipo);
}

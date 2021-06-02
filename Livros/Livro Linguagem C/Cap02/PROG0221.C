#include <stdio.h>

main()
{
int dia, mes, ano;
printf("Data (Formato aaaa-mm-dd): ");
scanf("%d-%d-%d",&ano,&mes,&dia);
printf("Data Completa: %d/%d/%d\n",dia,mes,ano);
}

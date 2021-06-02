 #include <stdio.h>

union Uni
{
  char   c;
  int    n;
  float  x;
};


main(void)
 {
	union Uni uniao;
	uniao.x = 12345.6;
	puts("Valores Iniciais");
	printf(" '%c' %d  %7.2f\n",uniao.c,uniao.n,uniao.x);
	puts("\nVou Alterar apenas o int");
 	uniao.n=2500;
	printf(" '%c' %d  %7.2f\n",uniao.c,uniao.n,uniao.x);

 }

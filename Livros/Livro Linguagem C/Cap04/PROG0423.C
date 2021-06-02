#include <stdio.h>

main()
{
  int i,nmin,nmax,tmp;

  do
	 {
		printf("Introd. um Nº entre 0 e 255: ");
		scanf("%d",&nmin);
	 }
  while (nmin < 0 || nmin > 255);

  do
	 {
		printf("Introd. outro Nº entre 0 e 255: ");
		scanf("%d",&nmax);
	 }
  while (nmax < 0 || nmax > 255);

  /* Verificar se e necessário trocar os valores das variáveis */

  if (nmin > nmax)
	 {
		tmp = nmin;
		nmin = nmax;
		nmax = tmp;
	 }

  for (i=nmin ; i<=nmax ; i++)
	 printf("%3d --> %c\n",i, (char) i);

}

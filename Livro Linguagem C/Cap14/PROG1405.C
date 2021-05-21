 #include <stdio.h>

main()
{
	int n,i;
	printf("Introd. um inteiro:");
	scanf("%d",&n);

	for(i=1; i<=10;i++)
	  if (n==i)
		 goto salta1;
	  else
		 if (n*i==50)
			goto salta2;

	puts("Nenhuma condiçao se verificou");
	goto end;

salta1:
	puts("n: Valor entre 1 e 10");
	goto end;

salta2:
	puts("n*i: Produto multiplo de 50");
	goto end;
end:
 ;
}

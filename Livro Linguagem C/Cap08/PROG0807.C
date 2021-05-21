#include <stdio.h>

#define N_STRINGS 3
main()
{
	char vector[N_STRINGS][20] = {"Ola", "Antonio", "Susana"};
	char (*ptr)[20] = vector; /* Apontador para vectores de 20 
						chars */
	char *p;

	while(ptr-vector<N_STRINGS)
		{
		  p = *ptr; 	/* p recebe a string apontada por ptr */
		  while (*p)
		    putchar (*p++);
		  putchar('\n');
		  ptr++;
		}


}

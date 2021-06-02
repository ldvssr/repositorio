5.
char *memcpy(char *dest, char *orig, int n)
{
	int i;
	for (i=0;i<n;i++)
		dest[i] = orig[i];
	return dest;
}


6.  
int memcmp(char *s1, char *s2, int n)
{
	int i;
	for (i=0;i<n;i++)
		if (s1[i] != s2[i])
			return 0; /* Não sao iguais */
	return 1; /* Terminou o ciclo e todos elementos são iguais */
}

7.
#include <ctype.h>
int memcmp(char *s1, char *s2, int n)
{
	int i;
	for (i=0;i<n;i++)
		if (toupper(s1[i])!= toupper(s2[i]))
			return 0; /* Não sao iguais */
	return 1; /* Terminou o ciclo e todos os elementos sao iguais */
}

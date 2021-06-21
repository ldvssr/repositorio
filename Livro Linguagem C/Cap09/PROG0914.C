#include <stdio.h>
#include <string.h>

char *rec_strcat(char *dest, char *orig)
{
	if (*dest=='\0')
		return strcpy(dest,orig);
	return rec_strcat(dest+1,orig)-1;
}
main()
{
	char s[100];
	gets(s);
	puts(rec_strcat(s,"OLA"));
}

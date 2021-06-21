#include <stdio.h>

char * strchr(char *str, char ch)
{
	if (*str=='\0')
		return NULL;
	else
		if (*str==ch)
			return str;
		else
  		return strchr(str+1,ch);
}
main()
{
	char s[100];
	do
		{
			gets(s);
			puts(strchr(s,'a'));
		}
  while (*s);

}

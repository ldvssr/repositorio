/* Mostra os n primeiros nºs decrescentemente */
void Down(int n)
{
 if (n<1) return;
 printf("%d\n",n);
 Down(n-1);
}

/* Mostra os n primeiros nºs Crescentemente */
void Up(int n)
{
 if (n<1) return;
 Up(n-1);
 printf("%d\n",n);
}

int strlen(char *s)
{
  if (*s=='\0')
    return 0;
  else
    return 1 + strlen(s+1);
}

int strcmp(char *s1, char *s2)
{
	if (*s1=='\0' || s2[0]=='\0' || *s1!=*s2)
		return *s1-*s2;
	else
		return strcmp(s1+1,s2+1);
}

float Pot(float x, int n)
{
	if (n==0)
		return 1.0;
	else
		return x * Pot(x,n-1);
}

float Exp(float x, int n, float t)
{
	if (n<1)
		return 0;
	else
		return x/Pot(1+t,n) + Exp(x,n-1,t);
}

char *Puts(char *s)
{
	if (*s=='\0')
		putchar('\n');
	else
		{
			putchar(*s);  /* Escrever o char corrente   */
			Puts(s+1);	 /* Escrever o resto da string */ 
		}
}


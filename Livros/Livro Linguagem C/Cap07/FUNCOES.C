int strlen(char *s)
{
	int i=0;
	while (s[i]!='\0')
		i++;
	return i;
}

ou

int strlen(char *s)
{
	int i;
	for (i=0 ; s[i]!='\0' ; i++)
		;
	return i;
}

int isnull(char *s)
{
  return (s[0] == '\0');
}

ou

int isnull(char *s)
{
   return (strlen(s) == 0);
}

char *strcpy(char *dest, char *orig)
{
	int i;
	for (i=0 ; orig[i]!='\0' ; i++)
		dest[i] = orig[i];
	dest[i] = '\0';
	return dest;
}

ou

char *strcpy(char *dest, char *orig)
{
  int i;
  for (i=strlen(orig) ; i>=0 ; i--) /*Ciclo ao Contrário para variar*/
    dest[i] = orig[i];
  return dest;
}

ou

char *strcpy(char *dest, char *orig)
{
   int i=0;
   while (dest[i] = orig[i])
     i++;
   return dest;
}

char *strcat(char *dest, char *orig)
{
	int i,len;
	for (i=0, len=strlen(dest) ; orig[i]!='\0' ; i++,len++)
		dest[len] = orig[i];
	dest[len]='\0';
	return dest;
}

ou

char *strcat(char *dest, char *orig)
{
	int i,len;
	for (i=0, len=strlen(dest) ; orig[i]!='\0' ; i++)
			dest[len+i] = orig[i];
	dest[len+i]='\0';
	return dest;
}

ou

char *strcat(char *dest, char *orig)
{
	int i=0, len=strlen(dest);
	while (dest[i+len] = orig[i])
		i++;
	return dest;
}

ou

char *strcat(char *dest, char *orig)
{
	int i=0, len=strlen(dest);
	while (dest[len++] = orig[i++])
		    ;
	return dest;
}

int strcountc(char *s, char ch)
{
	int i,conta;
	for (i=conta=0 ; s[i]!='\0' ; i++)
		if (s[i]==ch)	/* Se for o carácter que procuramos */
		  conta++;		/* Incrementar o contador		*/
	return conta;
}

int strcountd(char *s)
{
	int i,conta;
	for (i=conta=0 ; s[i]!='\0' ; i++)
		if (isdigit(s[i]))	/* Se o carácter for um dígito */
		  conta++;		/* Incrementar o contador 		*/
	return conta;
}

int indchr(char *s,char ch)
{
	int i;
	for (i=0 ; s[i]!='\0' ; i++)
		if (s[i]==ch)
			return i;
	return -1;
}

ou
int indchr(char *s,char ch)
{
	int i=0;
	while (s[i]!=ch && s[i]!='\0')
		i++;
	if (s[i]=='\0')
		 return -1;
	else
		 return i;
}

int strcap(char *s)
{
 int i,j;
 for (i=0,j=strlen(s)-1 ; i<j ; i++,j--)
   if (s[i]!=s[j]) 	/* Se os caracteres não forem iguais */
     return 0;	 	/* Não e capicua */
 return 1;
}

char  * strrev(char *s)
{
	int i,len;
	char aux;

	for (i=0,len=strlen(s)-1 ; i < len ; i++,len--)
		{
		 aux=s[i];
		 s[i] = s[len];
		 s[len]= aux;
		}
	return s;
}


int strcmp(char *s1 ,char *s2)
{
	int i=0;
	while (s1[i]==s2[i] && s1[i]!='\0')
		i++;
	return (s1[i] - s2[i]);
}

char * strpad(char *s)
{
	int i=strlen(s);
	s[2*i] = s[i]; /* Colocar o terminador na nova posição */

	for (i-- ; i>=0 ; i--)
		{
			 s[2*i] = s[i];
			 s[2*i+1] = ' ';
		}
	return s;
}

char * strdelc(char *s , char ch)
{
	int i,j;
	for (i=j=0 ; s[i]!='\0' ; i++)
		if (s[i]!=ch)
		   s[j++] = s[i];
	s[j]='\0';
	return s;
}

char *mygets(char *s)
{
	int i=0,ch;
	while ((ch=getchar())!='\n')
		s[i++]=ch;
	s[i] = '\0';
	return s;
}

char *strset(char *s , char ch)
{
	int i;
	for (i=0 ; s[i]!='\0' ; i++)
		s[i] = ch;
	return s;
}

char *strupr(char *s)
{
	int i;
	for (i=0 ; s[i]!='\0' ; i++)
		s[i] = toupper(s[i]);
	return s;
}


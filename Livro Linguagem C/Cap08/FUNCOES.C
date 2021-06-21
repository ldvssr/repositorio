4.
char *strstr(char *str1, char *str2)
{
int i,ii,j,len=strlen(str1)-strlen(str2);
for (i=0 ; i<=len ; i++)
   { for (ii=i , j=0 ; str1[ii]==str2[j] && str2[j]!='\0' ; j++,ii++)
			 ;
     if (str2[j]=='\0')
  	 return str1+i;
   }
return NULL;
}

5.
char *First_Vogal(char *s)
{
  const char vogais[] = "aeiou";
  int i;
  for (i=0 ; s[i]!='\0'; i++)
    if (strchr(vogais,s[i])!=NULL)
      return &s[i];
  return NULL;
}

6.
 /* Copia os caracteres de orig para dest do fim para o princípio */

char *strrcpy(char *dest,char *orig)
{
  int len;
  for (len = strlen(orig); len>=0 ; len--)
  dest[len]=orig[len];
  return dest;
}

char *strins(char *dest , char *orig)
{
  strrcpy(dest+strlen(orig),dest);
  memcpy(dest,orig,strlen(orig));
  return dest;
}

8.
char * StrDelUpper(char *s)
{ char *prim, *ptr;
  prim = ptr = s;

  while (*s) /* Equivalente a while (*s!='\0') */
    { if (!isupper(*s))
        *ptr++=*s;
      s++;
    }
  *ptr='\0';
  return prim;
}

9.
char * StrDelStr(char *s1,char *s2)
{
 char *loc = strstr(s1,s2);
 if (loc!=NULL) 				/* Se s2 existir em s1 */
   strcpy(loc,loc+strlen(s2));
 return s1;
}


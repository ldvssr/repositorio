1.
char *Repete(char *string, int n)
{
  int i;
  char * aux;
  if ((aux=(char *) malloc(n*(strlen(string)+1)))==NULL)
	 return aux; /* NULL */

  for (i=1 , aux[0]='\0' ; i<=n ; i++)
	 { strcat(aux,string);
		if (i!=n) strcat(aux," ");
	 }
  return aux;
}

2.
char *Metade(char *s)
{ char * tmp = (char*) malloc(strlen(s)/2+1);
  if (tmp==NULL) return tmp;
  strncpy(tmp,s,strlen(s)/2);
  tmp[strlen(s)/2]='\0';
  return tmp;
}

3.
char *Inverte(char *s)
{ char * tmp = (char*) malloc(strlen(s)+1);
  if (tmp==NULL) return tmp;
  strcpy(tmp,s);
  strrev(tmp);
  return tmp;
}



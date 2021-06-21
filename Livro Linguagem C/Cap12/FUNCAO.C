char * Ascii_Create(int n,char inic)
{
  int i;
  char * aux;
  if ((aux=(char *) malloc(n+1))==NULL)
    return aux; /* NULL */
  for (i=0;i<n;i++)
    aux[i]=inic+i;
  aux[i]='\0';
  return aux;
}

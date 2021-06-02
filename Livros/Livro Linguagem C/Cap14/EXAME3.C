1.1 
float Inverso(int x)
{
  if (x==0)
    return 0.0;
  else
    return 1/(float) x;
}

1.2 

void Linha(int n, char ch)
{
  while (n--)
    putchar(ch);

}

void  Triangulo(int n)
{ int i;
  for (i=1;i<=n;i++)
   {
     Linha(n-i,' ');
     Linha(i,'*');
     putchar('\n');
   }
}

1.3
void Troca(char *c1,char *c2)
{
  char tmp=*c1;
  *c1=*c2;
  *c2=tmp;
}

char *Encosta(char *s)
{ int i,existem_alteracoes,len=strlen(s)-1;
  do
   {
    existem_alteracoes=0;
    for (i=0;i<len;i++)
      if (!isupper(s[i]) && isupper(s[i+1]) || 
	 islower(s[i]) && !islower(s[i+1]))
       { 
          Troca(&s[i],&s[i+1]);
          existem_alteracoes=1;
       }
   }
  while(existem_alteracoes);
  return s;
}

1.4 
char * Up_Down(char *s)
{
  char *ptr=s;
  while (*ptr!='\0')
   { if (((ptr-s) %2)==0)	/* Se for um indice par */
       *ptr = toupper(*ptr);
     else
       *ptr = tolower(*ptr);
     ptr++;
   }
  return s;
}

1.5 
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

2 

-(x))
#define Vizinhanca(x,y,Delta) (ABS((x)-(y))<(Delta))


main(int argc, char *argv[], char *env[])
{ char *ptr;
  while (*env!=NULL)
   {
    ptr = strchr(*env,'=');
    if (ptr!=NULL)
      { *ptr='\0';
        printf("%s-->%s\n",*env,ptr+1);
      }
    env++;
   }
}

outra forma utilizando a função sscanf 
main(int argc, char *argv[], char *env[])
{ char var[100],valor[100];
  while (*env!=NULL)
   {
    if (sscanf(*env,"%[^=]%*c%s",var,valor)==2)
      printf("%s-->%s\n",var,valor);
    env++;
   }
}

4.0 
#include <stdio.h>
#include <stdlib.h>

#define MAX_LIN 80

main(int argc, char *argv[])
{
  int pos;
  FILE *fin;
  char linha[MAX_LIN+1];    /* Variavel com a linha do Fich */

  if (argc==1) return;
  if ((fin=fopen(argv[1],"rt"))==NULL)
  {
    fprintf(stderr,"Impossivel Abrir o Ficheiro %s\n",argv[1]);
    exit(1);
  }
  i=2;

  while (fgets(linha,MAX_LIN+1,fin)!=NULL)
    {
       if (linha[0]=='$')
         pos = atoi(linha+1);
       if (pos>0 && pos<=argc-1)
         puts(argv[pos+1]);
      }
  fclose(fin);
 exit(0);
}


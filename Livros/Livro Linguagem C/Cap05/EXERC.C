4. 
int Abs(int x)
{
  if (x>=0)
    return x;
  else
    return -x; 
}
ou
int Abs(int x)
{
  return (x>=0) ? x : -x;
}

5.

float VAL(float x, int n, float t)
{
  float res;
  int i;

  for(res=0,i=1; i<=n ; i++)
     res = res + x/Pot(1+t,i);

  return res;
}

6. 
long int n_segundos(int n_horas)
{
  return (long) n_horas * 3600;
}

7.1 /*com if-else */
#include <stdio.h>

long int num(int n_horas, char tipo)
{
  if (tipo=='h' || tipo == 'H')
    return (long) n_horas;
  else
    if (tipo=='m' || tipo == 'M')
      return (long) n_horas*60;
    else
      return (long) n_horas*60*60;
}

main()
{
  printf("%ld\n",num(3,'h'));
  printf("%ld\n",num(3,'m'));
  printf("%ld\n",num(3,'s'));
}

7.2 /* Com o switch com break */
long int num(int n_horas, char tipo)
{
  switch(tipo)
    { case 'h':
      case 'H': return (long) n_horas;
      case 'm':
      case 'M': return (long) n_horas*60;
      default: return (long) n_horas*60*60;
    }
}

7.3 /* Com o switch sem qualquer break */
long int num(int n_horas, char tipo)
{ long res=n_horas;
  switch(tipo)
    {
     case 's':
     case 'S': res=res*60;
     case 'm':
     case 'M': res=res*60;
    }
  return res;
}

8.
float Max(float x, float y, float w)
{
  if (x > y)
    if (x > w)
      return x;
    else
      return w;	
  else
    if (y > w)
      return y;
    else
      return w;	
}

9.
int Impar(int x) 	/* Se não é múltiplo de 2*/
{
  return x%2; 		/* ou return x%2==1; */ 
}

10.
int Entre(int x, int lim_inf, int lim_sup)
{
  return (x >= lim_inf && x <= lim_sup);
}

11.
11.1	
int isdigit(char c)
{
  return (c>='0' && c<='9');
}

11.2
int isalpha(char c)
{
  return (c>='a' && c<='z' || c>='A' && c<='Z');
}  

11.3
int isalnum(char c)
{
  return isalpha(c) || isdigit(c);
}

11.4
int islower(char c)
{
  return (c>='a' && c<='z');
}

11.5
int isupper(char c)
{
  return (c>='A' && c<='Z');
}

11.6
int isspace(char c)
{
  return c==' ' || c=='\t'; /* Espaço ou TAB */
}

11.7
char tolower(char c)
{
  if isupper(c)
    return c + 'a' -'A';
  else
    return c;
}

11.8
char toupper(char c)
{
if islower(c)
    return c + 'A' -'a';
  else
    return c;
}

12
int is_square(int x, int y) 
{
  return x==y*y;
}

13
int Minus(int valor)
{
  if (valor<0) 
    return valor;
  else
    return -valor;
}

ou 

int Minus(int valor)
{
  if (valor<0) 
    return valor;
  return -valor;
}

ou

int Minus(int valor)
{
  return -abs(valor); /* Usando a função escrita anteriormente */
}

14
int is_special(int x) 
{
  return 2*x==x*x;
}


15
int Cubo(int x)
{
  return x*x*x;
}

16
int IsVogal(char ch)
{
  return ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' ||
	ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U';
}

ou

int IsVogal(char ch)
{
  ch = toupper(ch);
  return ch=='A' || ch=='E' || ch=='I' || ch=='O' || ch=='U';
}

ou 

int IsVogal(char ch)
{
  switch (tolower(ch))
    {
      case 'a':
      case 'e':
      case 'i':
      case 'o':
      case 'u': return 1;
      default : return 0;
    }
}


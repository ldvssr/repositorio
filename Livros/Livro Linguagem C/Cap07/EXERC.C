2.1
int strcounta(char *s) 		/* isalpha: Necessario <ctype.h> */
{
	int i,conta;
	for (i=conta=0 ; s[i]!='\0' ; i++) 
		if (isalpha(s[i]))   /* Se o carácter for alfabetico */
			conta++;	 /* Incrementar o contador 	 */
	return conta;
}

2.2
char * init_str(char *s)
{
	s[0] = '\0';
	return s;
}

2.3
int ult_ind_chr1(char *s , char c)   /* Versao 1 */
{
	int i,ind=-1;
	for (i=0 ; s[i]!='\0' ; i++)
		if (s[i]==c)
			ind = i;
	return ind;
}

int ult_ind_chr2(char *s , char c)   /* Versao 2 */
{
	int i;
	for (i=strlen(s)-1 ; i>=0 ; i--)
		if (s[i]==c)
			return i;
	return -1;
}

2.4
char * strlwr(char *str)
{
	int i;
	for (i=0 ; str[i]!='\0' ; i++)
		str[i] = tolower(str[i]); /* tolower: Necessario <ctype.h> */
	return str;
}

2.5
char * strnset(char *s , char ch , int n)		/* Versão 1 */
{
	int i;
	for (i=0 ; s[i]!='\0' && i<n ; i++)
		s[i]=ch;
	return s;
}

char * strnset(char *s , char ch , int n)		/* Versão 2 */
{
	int i;
	for (i=0 ; s[i]!='\0' ; i++)
		if (i<n)
			s[i]=ch;
		else
			break;
	return s;
}

2.6
int stricmp(char *s1, char *s2)  /* toupper: Necessario <ctype.h> */
{
	int i=0;
	while (toupper(s1[i])==toupper(s2[i]) && s1[i]!='\0')
		i++;
	return (toupper(s1[i]) - toupper(s2[i]));
}

3.1
char * repeticoes(char *s)
{
	int i,j;
	for (i=j=0; s[i]!='\0'; i++)
		if (strcountc(s,s[i])>1) /* Ocorre mais que 1 vez */
			s[j++] = s[i];
	s[j]='\0';
	return s;
}

3.2
char n_esimo(char *s , int n)
{
   return s[n-1]; /* Pois os indices dos vectores começam em 0 */
}

3.3
char * strpack(char *s)
{ int i,j;
	for (i=j=0; s[i]!='\0';i++)
		if (s[i]!=s[j])
			s[++j]=s[i];
	s[++j]='\0';
	return s;
}

3.4
char * Entremeado(char *s , int n)
{
	int i,j, len=strlen(s);
	if (n==0) return s;

	for (i=j=0; i<len ; i+=n+1)
		s[j++] = s[i];
	s[j]='\0';
return s;
}

3.5
#define SPACE ' '

char * xspace(char *s)
{
   int i=strlen(s);  		/* i = nº caracteres em s */
   int N_Espacos = strcountc(s,SPACE); 	/* Nº de Espacos em s */
   int Dim = 2*i-N_Espacos;   /* Dimensao total da string resultado */

  s[Dim--] ='\0';			/* Terminador */
  for (--i ; i>=0 ; i--)
    if (s[i] == SPACE)
      s[Dim--] = s[i]; 		/* É um espaço. Copiar apenas */
    else
      {
        s[Dim--]=SPACE; 		/* Colocar o espaço */
        s[Dim--]=s[i];		/* a seguir a este carácter */
      }
  return s;
}

3.6
char Max_Ascii(char *str)
{
	int i;
	char res='\0';  /* Menor Código ASCII */
	for (i=0; str[i]!='\0';i++)
		res = res > str[i] ? res : str[i];
	return res;
}

3.7
char *Prox_Char(char *s)
{
	int i;
	for (i=0;s[i]!='\0';i++)
		s[i]=s[i]+1;		/* Carácter ASCII Seguinte */
	return s;
}

char *UpDown(char *s)   /* Versão 1 */
{
	int i;
	for (i=0;s[i]!='\0'; i++)
		if (i%2==0) 					/* Se for par */
			s[i] = toupper(s[i]);
		else                  /* Se for impar */
			s[i] = tolower(s[i]);
	return s;
}

char *UpDown(char *s)	/* Versão 2 */
{
	int i;
	for (i=0;s[i]!='\0'; i++)
			s[i] = (i%2==0) ? toupper(s[i]) : tolower(s[i]);
	return s;
}


3.10
char *allspaces(char *s)	/* Versão 1 */
{
	int i;
	for (i=0;s[i]!='\0'; i++)
		s[i]=' ';
	return s;
}

ou

char *allspaces(char *s)	/* Versão 2 */
{
 	return strset(s,' ');
}

3.11
char *strijset(char *s , int i, int j, char ch)
{
	if (i>=strlen(s)) return s;
	while (i<=j && s[i]!='\0')
		s[i++]=ch;
	return s;
}

3.12
char *strduplica(char *s)
{
	int i,len=strlen(s);
	for (i=0 ; i<len ; i++)
		s[i+len] = s[i];
	s[i+len]='\0';
	return s;
}

3.13
int atoi(char *s)		/* Necessario #include <ctype.h> */
{
  int i=0,res=0,sinal=1;
  if (s[0]=='-' || s[0]=='+') 
    i=1;					/* Começa a seguir ao 1º carácter */
  if (s[0]=='-') sinal=-1;	/* É um nº negativo 		*/

  for ( ; isdigit(s[i]) ; i++)
    res = res * 10 + s[i] - '0';
  return res*sinal;
}

char *wordupr(char *s)
{
  int i;
  s[0] = toupper(s[0]); /* O primeiro fica sempre em maiúsculas */
  for (i=1 ; s[i-1]!='\0' ; i++)
    if (s[i-1]==' ') /* Se o carácter anterior for um espaço */
      s[i] = toupper(s[i]);
    else
      s[i] = tolower(s[i]);
  return s;
}

3.15
char *lower_upper(char *s)
{
	int i, existem_trocas = 1 , len = strlen(s);
	char tmp; /* Aux para a realizaçao da troca de caracteres */

	while (existem_trocas)
	{
		existem_trocas = 0;
		for(i=0 ; i<len-1 ; i++)
			if (isupper(s[i]) && islower(s[i+1]))
				{
					tmp=s[i];
					s[i]=s[i+1];
					s[i+1]=tmp;
					existem_trocas=1;
				}
	}
	return s;
}

3.16
char * All_Big(char *s)
{
  int i,j;
  for (i=j=0; s[i]!='\0'; i++)
	 if (isupper(s[i]))
		s[j++]=s[i];
  s[j]=0;
  return s;
}

3.17
int Is_Len_OK(char *string, int comprimento)
{
  return strlen(string)==comprimento;
}

3.18
int Is_Alfa_Digit(char *s)
{
  int i;
  for (i=0;s[i]!='\0';i++)
   if (i%2==0)
     if (!isalpha(s[i])) return 0;
   else
     if (!isdigit(s[i])) return 0;
  return 1;
}

3.19
char *Transform(char *s)  /* Versão 1 */
{
  int i,len=strlen(s);
  for (i=0;i<len;i++)
    if (i<len/2)
      s[i] = tolower(s[i]);
    else
      s[i] = toupper(s[i]);
  return s;
}

char *Transform(char *s)
{
  int i,len=strlen(s)-1;
  for (i=0;i<=len;i++,len--)
   { s[i] = tolower(s[i]);
     s[len] = toupper(s[len]);
   }
  return s;
}

4.
#define OP_SAIR "SAIR"

/*
 * Coloca no Parâmetro Apelido a ultima palavra da string Nome.
 * Em seguida retira essa palavra da string Nome colocando um '\0'
 *
 */

void Separa(char *Nome, char * Apelido)
{
	int i,j;
	if (strcountc(Nome,' ')==0) 	/* Existe apenas uma ou zero 
palavras no nome */
		{
			 Apelido[0]='\0';
			 return;
		}
	/* Existe a garantia que existe um apelido */

	for (i=strlen(Nome)-1,j=0 ; Nome[i]!=' ' ; )
		Apelido[j++] = Nome[i--];
	Apelido[j]='\0'; 	/* Terminar a string Apelido        */
	Nome[i]='\0';    	/* Retirar o Apelido da String Nome */

 /* Como a string Apelido foi colocada do fim para o princípio é 
  * necessario inverte-la
  */

	 strrev(Apelido);
}

main()
{
char Nome[100],Apelido[20];

  for (;;)  /* Equivalente a while (1) */
  {
    printf("Nome: ");
    gets(Nome);
    if (stricmp(Nome,OP_SAIR)==0) break; /* Sair do Programa */
    Separa(Nome,Apelido);
    printf("%s, %s\n",wordupr(Apelido),wordupr(Nome));
  }
}


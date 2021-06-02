#define MAX 10

typedef struct
{ unsigned int N;
  char Nome[40+1];
} REGISTO;

typedef struct
{
  REGISTO v[MAX];
  int Conta;
} LISTA;

main()
{
 LISTA Lista;
}

b)
void Inic(LISTA * ptr)
{
  ptr->Conta=0;
}

c)
int Cheia(LISTA L)
{
  return L.Conta==MAX;
}

int Inserir(LISTA *ptr, REGISTO r)
{
  if (Cheia(*ptr))
	 return -1;
  ptr->v[ptr->Conta] = r;
  return ptr->Conta++;
}

d)
int Save(LISTA L, char * Nome_Fich)  /* Versão 1 */
{ int i;
  FILE *fp=fopen(Nome_Fich,"wb");
  if (fp==NULL) return 0;
  for (i=0 ; i<L.Conta;i++)
	 if (fwrite(&L.v[i],sizeof(REGISTO),1,fp)!=1) return 0;
  fclose(fp);
  return 0;
}

/* Outra Forma de escrever o Mesmo */
int Save_Outro(LISTA L, char * Nome_Fich)  /* Versão 2 */
{
  FILE *fp=fopen(Nome_Fich,"wb");
  if (fp==NULL) return 0;
  if (fwrite(L.v,sizeof(REGISTO),L.Conta,fp)!=L.Conta) return 0;
  fclose(fp);
  return 0;
}

e)
int Load (LISTA *L, FILE *fp)
{ REGISTO R;
  rewind(fp); /* Ir para o principio do Ficheiro */
  while (fread(&R,sizeof(R),1,fp)==1)
	 if (Inserir(L,R)==-1) return -1;
  return 0;
}

f)
void Listar(LISTA L)
{
  int i;
  for (i=0;i<L.Conta;i++)
	 printf("%d %s\n",L.v[i].N , L.v[i].Nome);
}


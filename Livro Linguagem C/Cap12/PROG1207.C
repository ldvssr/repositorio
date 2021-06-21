#include <stdio.h>
#include <string.h>
#include <stdlib.h>

typedef struct
{
  char Nome[30+1];
  float Altura;
  int Idade;
} REG;

/* Ficheiro: Variavel Global */
FILE *fp;

/*
 * So para conseguir testar o programa.
 * Esta função coloca 10 registos no Ficheiro
 */
void Inic()
{ char *v[]={"UM","DOIS","TRES","QUATRO","CINCO",
				"SEIS","SETE","OITO","NOVE","DEZ"};
  int i;
  REG r;
  FILE *fp = fopen("DADOS.DAT","wb"); /* Criar o Ficheiro */
  if (fp==NULL) return;
  for(i=0;i<10;i++)
	 { strcpy(r.Nome,v[i]);
		r.Idade = i*10;
		r.Altura = 1+i*.1;
		fwrite(&r,sizeof(r),1,fp);
	 }
  fclose(fp);
}

/* Listar Todos */

void Listar()
{ REG r;
  /* Salvaguardar a posicao actual */
  long Old_Pos = ftell(fp);
  /* Ir para o principio do ficheiro */
  rewind(fp);

  while(fread(&r,sizeof(r),1,fp)==1)
	 printf("%-30s  %3d  %7.2f\n",r.Nome,r.Idade,r.Altura);

  /* Reposicionar o Ficheiro */
  fseek(fp,Old_Pos,SEEK_SET);
}

/* Contar o Nº dos Maiores que n Anos */

int N_Maiores(int n)
{ REG r;
  int Contador=0;
  /* Salvaguardar a posicao actual */
  long Old_Pos = ftell(fp);
  /* Ir para o principio do ficheiro */
  fseek(fp,0L,SEEK_SET); /* igual a rewind(fp) */

  while(fread(&r,sizeof(r),1,fp)==1)
	 if (r.Idade>n)
		Contador++;

  /* Reposicionar o Ficheiro */
  fseek(fp,Old_Pos,SEEK_SET);

  return Contador;
}

/* Devolver o Nº de Registos existentes no Ficheiro */

long N_Registos()
{
  long res;
  /* Salvaguardar a posicao actual */
  long Old_Pos = ftell(fp);

  /* Ir para o fim do ficheiro */
  fseek(fp,0L,SEEK_END);

  /* Nº Registos = Nº Total de Bytes / Tamanho do Registo */
  res = ftell(fp)/sizeof(REG);

  /* Reposicionar o Ficheiro */
  fseek(fp,Old_Pos,SEEK_SET);

  return res;
}

REG * Carrega_Estrutura(REG **ptr)
{ long Old_Pos = ftell(fp);

  *ptr = calloc((int)N_Registos,sizeof(REG));
  if (*ptr==NULL) return NULL;

  rewind(fp);
  fread(*ptr,sizeof(REG),N_Registos(),fp);

  /* Reposicionar o Ficheiro */
  fseek(fp,Old_Pos,SEEK_SET);

  return *ptr;
}

main()
{ long n;
  REG *v,*outro;
  Inic();
  fp = fopen("DADOS.DAT","rb");
  if (fp==NULL)
	 {
		printf("Impossível abrir o Ficheiro dos Dados\n");
		exit(1);
	 }
  Listar();
  printf("Nº de ELementos Adultos  = %d\n",N_Maiores(18));
  printf("Nº de ELementos Velhotes = %d\n",N_Maiores(65));

  printf("\nNº de Registos = %d\n",N_Registos());

  outro = (REG *) Carrega_Estrutura(&v);
  if (outro!=NULL)
	 for (n=0;n<N_Registos();n++)
		 printf("%-30s %3d %5.2f %-30s %3d %5.2f\n",
			v[n].Nome,v[n].Idade,v[n].Altura,
			outro[n].Nome,outro[n].Idade,outro[n].Altura);

  free(v); /* O outro apenas aponta para v */
}

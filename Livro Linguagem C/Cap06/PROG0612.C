#include <stdio.h>

#define DIM 3
#define ESPACO ' '

void inic(char s[][DIM]);
void mostra(char s[DIM][DIM]);
int Ganhou(char g[DIM][DIM],char ch);
int Linha(char v[],char c);
int Coluna(char g[DIM][DIM], int col,char ch);


/* Inicializa o Tabuleiro */
void inic(char s[][DIM])
{
	int i,j;
	for(i=0;i<DIM;i++)
		for(j=0;j<DIM;j++)
			s[i][j]=ESPACO;
}

/* Mostra o aspecto do tabuleiro */
void mostra(char s[DIM][DIM])
{ int i,j;
	for (i=0;i<DIM;i++)
		{
			for (j=0;j<DIM;j++)
				printf("%c %c",s[i][j],j==DIM-1?' ':'|');
			if (i!=DIM-1) printf("\n--------");
			putchar('\n');
		}
}

/* Verifica se a n-esima linha esta toda preenchida com o carácter c */
int Linha(char v[],char c)
{
	return v[0]==v[1] && v[1]==v[2] && v[0]==c;
}

/* Verifica se a coluna col esta toda preenchida com o char ch */
int Coluna(char g[DIM][DIM], int col,char ch)
{
	return g[0][col]==g[1][col] && g[1][col]==g[2][col] && g[0][col]==ch;
}

/* Verifica se alguma das diagonais esta preenchida totalmente */
/* com o char ch                                               */
int Diagonal(char g[DIM][DIM],char ch)
{
	return (g[0][0]==g[1][1] && g[2][2]==g[1][1] & g[0][0]== ch) ||
				 (g[0][2]==g[1][1] && g[2][0]==g[1][1] & g[0][2]== ch);
}


/* Verifica se o jogador do carácter ch ganhou o jogo */
int Ganhou(char g[DIM][DIM],char ch)
{
	if (Linha(g[0],ch) || Linha(g[1],ch) || Linha(g[2],ch))
		return 1;
	if (Coluna(g,0,ch) || Coluna(g,1,ch) || Coluna(g,2,ch))
		return 1;
	if (Diagonal(g,ch))
		return 1;
	return 0;  /* Não ganhou o Jogo */
}

main()
{
	char Galo[DIM][DIM];
	int posx, posy;
	char ch = '0';  /* Carácter a Jogar */
	int n_jogadas = 0;

	inic(Galo);
	while (1)     /* Ciclo Infinito */
	 { mostra(Galo);
		 printf("\nIntroduza a Posicao de Jogo Linha Coluna: ");
		 scanf("%d %d",&posx,&posy);
		 if (posx> DIM || posy>DIM)
			 {printf("\n\n**** Valores Inválidos ****\n\n");
				continue; /* Proxima iteracao */
			 }
		 posx--;posy--;  /* Pois os indices do vector começam em ZERO */
		 if (Galo[posx][posy]==ESPACO) /* Casa Livre */
			 { Galo[posx][posy] = ch = (ch == '0') ? 'X' : '0';
				 n_jogadas++;
				 if (Ganhou(Galo,ch)) /* Basta apenas verificar o jogador corrente */
					 {printf("\n\n**** Ganhou o Jogador %c ****\n\n",ch);
						break;
					 }
			 }
		 else
			 printf("Posiçao ja ocupada\nJogue Novamente!!!\n");
		 if (n_jogadas==DIM*DIM)
			 { printf("\n\n**** EMPATE TECNICO ***\n\n");
				 break; /* Acabar o Ciclo */
			 }
	 }
   mostra(Galo);
}



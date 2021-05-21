#include <stdio.h>

typedef struct {int Dia,Mes,Ano;} DATA;

typedef struct pessoa
{
 	char  Nome[100];
 	int   Idade;
 	float Salario;
 	DATA  Nasc;
} PESSOA;

void Mostrar(struct pessoa x)
{
	printf("Nome      : %s\n",x.Nome);
	printf("Idade     : %d\n",x.Idade);
	printf("Salário   : %.2f\n",x.Salario);
	printf("Dt. Nasc  : %d/%d/%d\n",x.Nasc.Dia,x.Nasc.Mes, x.Nasc.Ano);
}


main()
{
	struct pessoa p = {"Carlos",23,12345.67,{23,5,1954}};

	Mostrar(p);
}

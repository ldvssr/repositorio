 #include <stdio.h>

 struct Pessoa
 {
	char Nome[30];
	int Idade;
	unsigned Sexo : 1; 		/* 1 Bit  */
	unsigned Est_Civil : 2; 	/* 2 Bits */
 }


main()
{
  struct Pessoa p;

  /* Carregar a Estrutura com valores */
  strcpy(p.Nome, "Samad o Terrivel");
  p.Idade = 32;
  p.Sexo = 1;     	/* Masculino  */
  p.Est_Civil = 3;	/* Divorciado */

  /* Mostrar os Valores */
  printf("Nome    : %s\n", p.Nome);
  printf("Idade   : %d\n", p.Idade);
  printf("Sexo    : %s\n", p.Sexo==0? "Feminino" : "Masculino");
  printf("E. Civil: ");
  switch(p.Est_Civil)
	 {
		case 0: puts("Solteiro"); break;
		case 1: puts("Casado"); break;
		case 2: puts("Viuvo"); break;
		case 3: puts("Divorciado"); break;
	 }
}

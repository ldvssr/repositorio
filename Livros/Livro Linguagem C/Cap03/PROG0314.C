#include <stdio.h>

main()
{
  float salario, imposto = 0.0;
  char sexo;

  printf("Introduza o Salário: ");
  scanf("%f",&salario);
  printf("Qual o Sexo: ");
  scanf(" %c",&sexo);
  switch (sexo)
	 {
		case 'f':
		case 'F': imposto = 0.10;
                 break;
		case 'm':
		case 'M': imposto = 0.15;
                 break;
	 }
  printf("Imposto %.2f\n",salario*imposto);
}


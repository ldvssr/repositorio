#include <stdio.h>
#include <assert.h>

int Quadrado(int x)
{ return x*x; }

int Dobro(int x)
{ return 2*x; }

int Abs(int x)
{ return x<0? -x:x; }

/* 	Esta funçao recebe dois parametros
		Um apontador para uma funcao que recebe como parametro
			um inteiro e devolve um inteiro como resultado
		Um inteiro a ser formatado pela funcao

	Depois coloca o resultado da execuçao de  funcao(n)
			entre <<<| e |>>>
*/

void Imprime_Especial( int (*funcao)(int), int n)
{
  assert(funcao!=NULL);
  printf("<<<|%d|>>>\n",(*funcao)(n));
}
main()
{
  int (*f)(int);
  int valor;
  f = NULL;     /* Nao aponta para funcao nenhuma */

  printf("Introd. um valor inteiro:");
  scanf("%d",&valor);
  if (valor < 0)
	 f = Abs;
  else
	 if (valor <=100)
		f = Quadrado;
	 else
		f = Dobro;

  Imprime_Especial(f,valor);

}

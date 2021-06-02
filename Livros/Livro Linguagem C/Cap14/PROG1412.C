 #include <stdio.h>

int Quadrado(int x)
{ return x*x; }

int Dobro(int x)
{ return 2*x; }

int Cubo(int x)
{ return Quadrado(x)*x; }

/* Esta funçao recebe dois parametros
     Um apontador para uma funcao que recebe como parametro um 
         inteiro e devolve um inteiro como resultado
     Um inteiro a ser formatado pela funcao

   Depois coloca o resultado da execuçao de  funcao(n) entre 
<<<| e |>>>
*/ 
void Imprime_Especial( int (*funcao)(int), int n)
{
  printf("<<<|%d|>>>\n",(*funcao)(n));
}
main()
{
  Imprime_Especial(Quadrado,3);
  Imprime_Especial(Dobro,10);
  Imprime_Especial(Cubo,5);

}

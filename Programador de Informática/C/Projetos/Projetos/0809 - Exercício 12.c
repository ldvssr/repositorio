/*

APONTADORES

1.Troque os valores entre duas variaveis inteiras usando apontadores.Fa�a-o com
um m�todo que ir� chamar de troca(), ele ter� dosi argumentos que ser�o
apontadores.
2.Realize um loop para imprimir apenas os numeros pares num array, mas dever�
usar incrementa��o de apontadores e n�o dos "indices" para realizar o loop.

ESTRUTURAS I

1)
Dever� criar uma struct que posibilite armazenar um Carro, com a seguinte
informa��o : Marca do Carro , Modelo Carro e Ano do carro
De seguida dever� inicializar dois carros diferentes, n�o precisa de pedir input ao
utilizador neste caso.
Dever� comparar se os dois carros s�o do mesmo ano, se forem, indicar a mensagem-
" Carros s�o do mesmo ano", sen�o indicar "Carros de anos diferentes".
Dever� tamb�m poder comparar do mesmo modo ao de tr�s se a Marca do Carro � a
mesma nos dois carros - Ser� que basta utilizar == para comparar?

2)
Dever� criar uma struct para suportar uma equipa de futebol de 5. A equipa consistir�
em, um nome de equipa, um treinador, e 5 jogadores.
Dever�o permitir que o utilizador introduza os valores correspondentes ao nome da
equipa(sem espa�os) , primeiro nome do treinador(sem espa�os) e o primeiro nome
dos 5 jogadores.
De seguida dever� imprimir a todos os dados disponiveis na struct criada
anteriormente.

ESTRUTURAS II

Crie uma estrutura que represente os alunos de um determinado curso. A estrutura deve conter o numero do
aluno, nome, nota da primeira prova, nota da segunda prova e nota da terceira prova.
(a) Permita ao utilizador introduzir os dados de 5 alunos.
(b) Encontre o aluno com maior nota de primeira prova.
(c) Encontre o aluno com maior media geral.
(d) Encontre o aluno com menor media geral.
(e) Para cada aluno diga se ele foi aprovado ou reprovado, considerando o valor 6 para aprova��o
Poder� realizar o exerc�cio, com ou sem o uso de fun��es.

*/

#include <stdio.h>
main()
{
    int x = 5 , *px = &x;
    float y = 5.0 , *py = &y;
    printf("%d %ld\n",x,(long)px);
    printf("%d %ld\n",x+1,(long)(px+1));
    printf("%f %ld\n",y,(long)py);
    printf("%f %ld\n",y+1,(long)(py+1));
}

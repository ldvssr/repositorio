/*

APONTADORES

1.Troque os valores entre duas variaveis inteiras usando apontadores.Faça-o com
um método que irá chamar de troca(), ele terá dosi argumentos que serão
apontadores.
2.Realize um loop para imprimir apenas os numeros pares num array, mas deverá
usar incrementação de apontadores e não dos "indices" para realizar o loop.

ESTRUTURAS I

1)
Deverá criar uma struct que posibilite armazenar um Carro, com a seguinte
informação : Marca do Carro , Modelo Carro e Ano do carro
De seguida deverá inicializar dois carros diferentes, não precisa de pedir input ao
utilizador neste caso.
Deverá comparar se os dois carros são do mesmo ano, se forem, indicar a mensagem-
" Carros são do mesmo ano", senão indicar "Carros de anos diferentes".
Deverá também poder comparar do mesmo modo ao de trás se a Marca do Carro é a
mesma nos dois carros - Será que basta utilizar == para comparar?

2)
Deverá criar uma struct para suportar uma equipa de futebol de 5. A equipa consistirá
em, um nome de equipa, um treinador, e 5 jogadores.
Deverão permitir que o utilizador introduza os valores correspondentes ao nome da
equipa(sem espaços) , primeiro nome do treinador(sem espaços) e o primeiro nome
dos 5 jogadores.
De seguida deverá imprimir a todos os dados disponiveis na struct criada
anteriormente.

ESTRUTURAS II

Crie uma estrutura que represente os alunos de um determinado curso. A estrutura deve conter o numero do
aluno, nome, nota da primeira prova, nota da segunda prova e nota da terceira prova.
(a) Permita ao utilizador introduzir os dados de 5 alunos.
(b) Encontre o aluno com maior nota de primeira prova.
(c) Encontre o aluno com maior media geral.
(d) Encontre o aluno com menor media geral.
(e) Para cada aluno diga se ele foi aprovado ou reprovado, considerando o valor 6 para aprovação
Poderá realizar o exercício, com ou sem o uso de funções.

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

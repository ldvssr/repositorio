
/*
 

1.Tarefa a entregar até ao
final da aula de hoje 

Código a ser enviado + comentários vossos


 */

/*

using System;

// Definição de como é o delegate a nível de estrutura, neste caso devolve um inteiro e tem um único parâmetro inteiro.
delegate int NumberChanger(int n);

namespace Explicações
{
    class Testdelegate
    {
        static int num = 10;

        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        static void Main(string[] args)
        {
            // Instâncias dos delegates
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            // Chamar os metodos a partir dos delegates
            nc1(25);
            Console.WriteLine("Valor de Número: {0}", getNum());
            nc2(5);
            Console.WriteLine("Valor de Número: {0}", getNum());
            Console.ReadKey();
        }
    }
}

*/

/*

using System;

namespace DelegatesAndEvents
{
    class Program
    {
        // 1.1 Função pronta a ser chamada com os mesmos parâmetros do ponto 2.1
        static void myCallBackCão(int i)
        {
            Console.WriteLine("Ladrar" + i);
        }

        // 1.2 Outra função pronta para ser chamada pelo mesmo delegate dado que apresenta os mesmos parâmetros
        static void myCallBackGato(int i)
        {
            Console.WriteLine("Miar" + i);
        }

        static void Main(string[] args)
        {
            // 1.3 Criação do objeto da classe MeuTrabalho, onde está disponível o delegate
            meuTrabalho myObj = new meuTrabalho();

            // 1.4 Fazer chamada da instância com o callback correspondente
            myObj.FazerSom(myCallBackCão);
            myObj.FazerSom(myCallBackGato);
        }

        public class meuTrabalho
        {
            // 2.1 Delegate serve como uma espécie de assinatura ou indicação de como irá ser a função enviada por parâmetro
            // neste caso fico a saber que as funções que chegam chamadas atrvés deste delegate apenas poderão ter um int como parâmetro
            // myCallBackCão e myCallBackGato seguem esses parâmetros
            public delegate void myCallBackPointer(int i);

            // 2.2 Função que irá receber os delegates como parâmetros, reparar que o tipo do parâmetro é igual ao delegate criado na linha anterior
            public void FazerSom(myCallBackPointer NewObj)
            {
                for (int i = 0; i < 10; i++)
                {
                    // 2.3 Aqui estamos a chamar indiretamente a função myCallBackcão e myCallBackGato dependendo do delegate
                    // enviado a quando a chamada desta função no main
                    NewObj(i);
                }
            }
        }
    }    
}

*/

/*

using System;

namespace DelegatesAndEvents
{
    // Etapa 1 - Criar um publicador
    class Publicador
    {
        // Etapa 1.1 - Criar um delegate cujo nome seja
        // "nomeDoEvento" + EventHandler
        public delegate void TrabalhoFeitoEventHandler(object sender, EventArgs args);

        // Etapa 1.2 - Criar um evento baseado no delegate
        public event TrabalhoFeitoEventHandler TrabalhoFeito;

        public void ProcessaUmTrabalho()
        {
            Console.WriteLine("Publicador: Um trabalho foi concluído");
            // Etapa 1.3 - Dispara o evento
            OnTrabalhoFeito();
        }

        
        //O padrão do C# standard requer que método seja definido como protected virtual.
        //O nome também precisa de coincidir com o nome do event e terá de ter o prefixo com 'On'.
        
        protected virtual void OnTrabalhoFeito()
        {
            if (TrabalhoFeito != null)
                TrabalhoFeito(this, EventArgs.Empty);
        }

    }

    // Etapa 2 - Criar um subscritor
    class Subscriber
    {
        // Tratamento do evento
        public void OnTrabalhoFeitoEventHandler(object sender, EventArgs args)
        {
            Console.WriteLine("O Subscritor foi notificado");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Evento exemplo");
            // Criar instancia do Editor e do Assinante
            Publicador remetente = new Publicador();
            Subscriber receptor = new Subscriber();
            // Define o tratamento de evento, aqui subscrevemos o subscritor às notificações do publicado
            remetente.TrabalhoFeito += receptor.OnTrabalhoFeitoEventHandler;

            // Define o tratamento de evento, aqui deixamos de subscrever o subscritor às notificações do publicado
            // remetente.TrabalhoFeito -= receptor.OnTrabalhoFeitoEventHandler;

            // Invoca
            remetente.ProcessaUmTrabalho();
            Console.ReadKey();
        }
    }
}

*/

/*


2.Tarefa a entregar até ao
final da próxima aula

EXERCÍCIOS


ETAPA 1

No Visual Studio.NET para criar seus programas, faça o seguinte:
• No Menu File escolha New Project
• Escolha o Tipo de Projeto como Visual C# Projects
• Depois escolha como Templates o modelo Console Applica􀀥on
• Dê um nome ao seu programa e escolha a pasta desejada e pronto, você poderá testar o código.
Estes programas têm a finalidade de fazer com que o aluno assimile conceitos fundamentais no
desenvolvimento de aplicações com o C#, especialmente delegates e call backs, como também Hierarquia.


ETAPA 2 - EXERCÍCIO com Hierarquias

2.1 Desenvolva um programa onde u􀀥lize um sistema de hierarquia para definir crianças, idosos, mulheres
homens,adolescentes ou adultos. Sendo que todos eles são HUMANOS, e podem ser mulheres ou homens, e
consequentemente idosos, crianças, adolescentes ou adultos.
Deve criar a estrutura hierarquica correspondente à descrição anterior.
Um Humano(CLASSE ABSTRATA) deve ter propriedades gerais a todos as classes, como:
Primeiro Nome, Ul􀀣mo Nome, Idade, Numero de Cartão de Cidadão, como também ter métodos gerais e
acessiveis por todas as outras classes, como falar e caminhar.
As mulheres devem possuir um método específico para Ensinar(), como também possuir um campo de 􀀣po
inteiro que possa armazenar o IQ da mulher.
Os Homens deverão ter um método especifico para Trabalhar(), como também possuir um campo para
armazenar o numero de Kilos que conseguem levantar.
Tanto as crianças, adolescentes, adultos e idosos devem derivar ou de Homem ou Mulher.
Depois de ter definido as classes e as sua relações deve realizar o seguinte:

1. Criar uma instancia de cada classe em que seja possivel isso mesmo.

2. Aceder em cada objecto a todas as propriedades(atribuindo valores a cada uma delas) e chamando
todos os métodos disponiveis nelas.


ETAPA 3 - EXERCÍCIO com delegates

3.1 Crie um delegate para que seja possivel chamar funções com um parametro String e um Int.
Este delegate deve pode ter callbacks deste 􀀣po de métodos
public sta􀀣c String NomeIndex(String nome, int index) que deverá devolver como string o nome + index,
como no exemplo a seguir = "Igor 1", dado que o nome seja "Igor" e o index seja 1.
public sta􀀣c String IndexNome(String nome, int index) que deverá devolver como string o index + nome,
como no exemplo a seguir = "2 Igor", dado que o nome seja "Igor" e o index seja 2.
Veja o primeiro exemplo citado na página 1 caso esteja a ter dificuldades a entender o pedido, pois é muito
parecido com tal exemplo.


ETAPA 4 - EXERCÍCIO com Eventos

4.1 Realize um programa que faça uso de eventos para no􀀥ficar mul􀀥plos subcritores, que estão inseridos
numa lista de subscritores, que receberam um prémio. Depois de o fazer, re􀀥re o primeiro elemento dessa
lista de estar subscrito a esse evento, e volte a no􀀥ficar os subscritores que voltaram a ganhar um prémio.


 */
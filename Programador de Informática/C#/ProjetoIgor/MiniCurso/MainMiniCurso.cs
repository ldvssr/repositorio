using System;
// Incluir a classe Heranças
using static MiniCurso.Heranças;
// Incluir a classe ClassesAbstratas
using static MiniCurso.ClassesAbstratas;
//using static MiniCurso.AAnimal;
//using static MiniCurso.ACão;
//using static MiniCurso.AGato;
// Incluir a classe DelegatesAndCallBacks
using static MiniCurso.DelegatesAndCallBacks;
//using static MiniCurso.meuTrabalho;

namespace MiniCurso
{
    class MainMiniCurso
    {                      
        static void Main(string[] args)
        {
            // Heranças
            Animal animal = new Animal();
            animal.Comer();
            animal.Lavar();

            Cão cão = new Cão();
            cão.Comer();
            cão.Lavar();
            cão.Ladrar();

            PastorAlemão alemão = new PastorAlemão();
            alemão.ChamarPastorAlemão();

            Gato gato = new Gato();
            gato.Comer();
            gato.Lavar();
            gato.Miar();

            // Classes Abstratas
            ACão a_cão = new ACão();
            Console.WriteLine(a_cão.AComer());
            Console.WriteLine(a_cão.valor++);
            Console.WriteLine(a_cão.valor++);

            AGato a_gato = new AGato();
            Console.WriteLine(a_gato.AComer());
            Console.WriteLine(a_gato.valor++);
            Console.WriteLine(a_gato.valor++);

            // DelegatesAndCallBacks
            meuTrabalho myObj = new meuTrabalho();
            myObj.trabalharEAdiar(myCallBackCatcher);
            myObj.trabalharEAdiar(myCallBackWordCatcher);            
        }        
    }    
}
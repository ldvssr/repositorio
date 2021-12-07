using System;

namespace MiniCurso
{
    class Heranças
    {
        public class Animal
        {
            public virtual void Comer()
            {
                Console.WriteLine("Sou um animal e estou a comer");
            }
            public void Lavar()
            {
                Console.WriteLine("Sou um animal e estou a lavar-me");
            }
        }
        public class Cão : Animal
        {
            public override void Comer()
            {
                Console.WriteLine("Sou um cão e estou a comer");
            }
            public void Ladrar()
            {
                Console.WriteLine("Sou um cão e ladro");
            }
        }
        public class Gato : Animal
        {
            public override void Comer()
            {
                Console.WriteLine("Sou um gato e estou a comer");
            }
            public void Miar()
            {
                Console.WriteLine("Estou a miar");
            }
        }
        public class PastorAlemão : Cão
        {
            public void ChamarPastorAlemão()
            {
                Console.WriteLine("Chamar alemão");
            }
        }
        Animal animal = new Animal();
        Cão cão = new Cão();
        PastorAlemão alemão = new PastorAlemão();
        Gato gato = new Gato();
    }
}
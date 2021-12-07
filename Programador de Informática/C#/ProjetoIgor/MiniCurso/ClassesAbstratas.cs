using System;

namespace MiniCurso
{
    class ClassesAbstratas
    {        
    }
    abstract class AAnimal
    {
        public int valor;
        public abstract string AComer();
    }
    class ACão : AAnimal
    {
        public override string AComer()
        {
            return "Sou um Cão";
        }
    }
    class AGato : AAnimal
    {
        public override string AComer()
        {
            return "Sou um Gato";
        }
    }
}

using System;

namespace MiniCurso
{
    class DelegatesAndCallBacks
    {
        public static void myCallBackCatcher(int i)
        {
            Console.WriteLine("Numero" + i);
        }
        public static void myCallBackWordCatcher(int i)
        {
            Console.WriteLine("Palavra" + i);
        }
        //
    }
    class meuTrabalho
    {
        public delegate void myCallBackPointer(int i);
        public void trabalharEAdiar(myCallBackPointer NewObj)
        {
            for (int i = 0; i < 10; i++)
            {
                NewObj(i);
            }
        }
    }   
}

 using System;

namespace AulaExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
           ExceptionsClass exceptions = new ExceptionsClass();

            try
            {
                exceptions.Utilizar();
            }catch(DivideByZeroException error)
            {
                Console.WriteLine("Ocorreu a seguinte exceção: (" + error.Message + ")");
                Console.WriteLine("Caminho da exceção: " + error.StackTrace);
            }

            Console.WriteLine("Exceção tratada!");

            Console.ReadLine();
        }
    }
}

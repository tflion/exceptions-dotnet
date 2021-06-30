using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExceptions
{
    public class ExceptionsClass
    {
        public static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Impossível dividir por zero");
                throw;
            }
                
       
        }

        public void Utilizar()
        {
            TestaDivisao(0);
        }

        public void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}

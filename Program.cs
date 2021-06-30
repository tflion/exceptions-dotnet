﻿using System;

namespace AulaExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
           ExceptionsClass exceptions = new ExceptionsClass();

            try
            {
                //exceptions.Utilizar();
                ContaCorrente conta = new ContaCorrente(5, 7);
                conta.Sacar(500);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Argumento com problema: " + ex.ParamName);
                Console.WriteLine("Ocorreu uma exceção do tipo ArgumentException");
                Console.WriteLine(ex.Message);
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo saldo insuficiente.");               
            }

            catch(Exception e) // trata todos os erros (conveção utilizar o 'e' para nomes de excessões)
            {
                Console.WriteLine("Ocorreu a seguinte exceção: (" + e.Message + ")");
                Console.WriteLine("Caminho da exceção: " + e.StackTrace);
            }

            Console.WriteLine("Exceção tratada!");

            Console.ReadLine();
         

            
            
        }
    }
}

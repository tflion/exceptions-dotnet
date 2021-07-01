using System;
using System.IO;

namespace AulaExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();



            Console.ReadLine();
        }

        private static void CarregarContas()
        {

            using(LeitorDeArquivos leitor = new LeitorDeArquivos("Teste.txt"))
            {
                leitor.LerProximaLinha();
            }

            /*
            
            LeitorDeArquivos leitor = null;

            try
            {
                leitor = new LeitorDeArquivos("contas.txt");

                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();  
                
            }
            catch (IOException)
            {
                Console.WriteLine("Exceção do tipo: IOException capturada e tratada!");
            }
            finally // executa quando acontece a exceção e quando não ocorre
            {
                if(leitor != null)
                {
                    leitor.Fechar();
                }
                
            }
            */
            
        }

        private static void TestesAnteriores()
        {
            /*
            
            try
            {
                ContaCorrente conta1 = new ContaCorrente(4564, 789684);
                ContaCorrente conta2 = new ContaCorrente(7891, 456794);

                conta1.Transferir(10000, conta2);
            }catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Inner Exception: " + e.InnerException.Message) ;
                Console.WriteLine(e.InnerException.StackTrace);
            }

            
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
                 Console.WriteLine(ex.Saldo);
                 Console.WriteLine(ex.ValorSaque);
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
             */
        }
    }
}

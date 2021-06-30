using System;
using System.Collections.Generic;
using System.Text;

namespace AulaExceptions
{
    public class SaldoInsuficienteException : Exception
    {
        public double Saldo { get; }
        public double  ValorSaque { get; set; }
        public SaldoInsuficienteException(string mensagem) : base(mensagem)
        {

        }

        public SaldoInsuficienteException(double saldo, double valorSaque ) : this("Tentativa de saque no valor de " + valorSaque + " em uma conta com saldo de " + saldo)
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public SaldoInsuficienteException() { }
        
    }
}

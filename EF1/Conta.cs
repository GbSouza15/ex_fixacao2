using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace EF1
{
    internal class Conta
    {
        public int NConta { get; private set; }
        public double Saldo { get; private set; }
        public string NomeTitular;
        
        
        public Conta(string nomeTitular, int nConta)
        {
            NomeTitular = nomeTitular;
            NConta = nConta;
            Saldo = 0;
        }

        public Conta(int nConta, string nomeTitular, double deposito) : this(nomeTitular, nConta)
        {
            Deposito(deposito);
        }

        public double Deposito(double deposito)
        {
            return Saldo += deposito;
        }

        public double Saque(double saque)
        {
            double valorComTaxa = saque + 5.0;
            return Saldo -= valorComTaxa;
        }

        public override string ToString()
        {
            return "Conta " 
                + NConta 
                + ", Titular: " 
                + NomeTitular 
                + ", Saldo: $ " 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

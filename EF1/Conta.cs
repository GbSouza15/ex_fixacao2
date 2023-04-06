using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace EF1
{
    internal class Conta
    {
        private int _nConta;
        private double _saldo;
        public string NomeTitular;
        
        
        public Conta(string nomeTitular, int nConta)
        {
            NomeTitular = nomeTitular;
            _nConta = nConta;
            _saldo = 0;
        }

        public Conta(int nConta, string nomeTitular, double deposito) : this(nomeTitular, nConta)
        {
            Deposito(deposito);
        }

        public double Deposito(double deposito)
        {
            return _saldo += deposito;
        }

        public double Saque(double saque)
        {
            double valorComTaxa = saque + 5.0;
            return _saldo -= valorComTaxa;
        }


        public double NConta
        {
            get { return _nConta; }
        }

        public double Saldo
        {
            get { return _saldo; }  
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

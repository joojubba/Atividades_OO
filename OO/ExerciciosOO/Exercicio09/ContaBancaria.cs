using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    internal class ContaBancaria
    {
        uint numeroConta;
        string titular;
        double saldo, limite;

        public uint NumeroConta
        {
            get { return numeroConta; }
            set { numeroConta = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public double Limite
        {
            get { return limite; }
            set { limite = value; }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (Saldo + Limite >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
    }
}

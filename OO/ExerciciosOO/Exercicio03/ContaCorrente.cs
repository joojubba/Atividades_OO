using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    internal class ContaCorrente
    {
        public double Saldo;
        public ContaCorrente()
        {

        }
        public void DefinirSaldoInicial(double valor)
        {
            this.Saldo = valor;
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor;
                return true;

            }
            else
            {
                return false;
            }

        }
    }
}

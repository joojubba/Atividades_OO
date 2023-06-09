using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    internal class Conta
    {
         int numero;
         double saldo;
         double limite;

        public Conta(int num)
        {
            numero = num;
        }
        public int Numero
        {
            get { return numero; }
        }
        public double Saldo
        {
            get { return saldo; }
            set 
            { 
                if(value >= 0)
                {
                    saldo = value;
                }
                else
                {
                    throw new ArgumentException("Erro: saldo menor que 0");
                }
                
            }
        }
        public double Limite
        {
            get { return limite; }
            set 
            {
                if (value >= 0)
                {
                    limite = value;
                }
                else
                {
                    throw new ArgumentException("Erro: limite negativo");
                }

            }
        }
    }
}

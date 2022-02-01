using D1_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main()
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();  

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 001;
            contaDaGabriela.saldo = 1000;
            
            Console.WriteLine("Titular:"+contaDaGabriela.titular +"\n");
        }
    }
}
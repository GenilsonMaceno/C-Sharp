﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o Proejto 12 ");


            double valorInvestido = 1000;
            double fatorRedimento = 1.0036;

            for (int contadorAno = 1; contadorAno <= 5; contadorAno++)
            {
                for(int contadorMes = 1; contadorMes <=12; contadorMes++)
                {
                    valorInvestido *= fatorRedimento;
                }

                fatorRedimento += 0.0010;
            }

            Console.WriteLine("Ao Término do investimento, você terá R$: " + valorInvestido);

            Console.ReadLine();
        }
    }
}

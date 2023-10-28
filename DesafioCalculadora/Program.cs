using System;
using System.Collections.Generic;

namespace DesafioCalculadora {
    internal class Program {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hello World!");
            Calculadora calc = new Calculadora("28/10/2023");

            calc.Dividir(10, 2);
            calc.Somar(2, 2);
            calc.Multiplicar(2, 2);
            calc.Subtrair(2, 2);

            List<string> listaHistorico = calc.HistoricoLista();

            foreach(string item in listaHistorico)
            {
                Console.WriteLine(item);
            }

            DateTime data = calc.Data;

            //Console.WriteLine(data);

        }
    }
}

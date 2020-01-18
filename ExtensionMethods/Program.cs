using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] nomes = { "João", "Maria", "Ana", "Pedro", "Carlos"};

            //var result = nomes.OrderBy(g => g);

            Agendamento agendamento = new Agendamento();

            var resultado = agendamento.AgendarSalao("cleiton", DateTime.Now);

            foreach (var item in resultado)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}

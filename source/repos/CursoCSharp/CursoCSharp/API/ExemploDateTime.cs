using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API
{
    class ExemploDateTime
    {
        public static void Executar()
        {
            var diaData = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(diaData.Day);
            Console.WriteLine(diaData.Month);
            Console.WriteLine(diaData.Year);

            //Today vem com horário zerado
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            Console.WriteLine(hoje.ToShortDateString());

            // Data com hora certa
            var dataComHora = DateTime.Now;
            Console.WriteLine(dataComHora);

            string d = DateTime.Now.ToShortTimeString();
            Console.WriteLine(d);
            Console.WriteLine("Hora: "+dataComHora.Hour);
            Console.WriteLine("Minutos: "+dataComHora.Minute);

            var amanha = dataComHora.AddDays(1);
            Console.WriteLine("Amanhã: "+amanha);

            var ontem = dataComHora.AddDays(-1);
            Console.WriteLine("Ontem: "+ontem);

            Console.WriteLine("Hoje é dia: "+dataComHora.ToString("dd"));
            Console.WriteLine("Hoje é dia: " + dataComHora.ToString("d"));
            Console.WriteLine("Hoje é dia: " + dataComHora.ToString("D"));
            Console.WriteLine("Hoje é dia: " + dataComHora.ToString("g"));
            Console.WriteLine("Hoje é dia: " + dataComHora.ToString("G"));
            Console.WriteLine("Hoje é dia: " + dataComHora.ToString("dd-MM-yyyy HH:mm"));

        }
    }
}

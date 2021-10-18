using System;
using System.Collections.Generic;
using System.Text;

namespace basic_concepts
{
    class Dates
    {
        public void DatesTypes()
        {
            DateTime data = new DateTime(2015, 3, 30); 

            Console.WriteLine(data); //30/03/2015 00:00:00
            Console.WriteLine(data.ToLongDateString()); //segunda-feira, 30 de março de 2015
            Console.WriteLine(data.ToString("dd . yyyy . MM")); //30 . 2015 . 03
            Console.WriteLine(data.ToString("ddyyyyMM")); //30201503
            Console.WriteLine(data.ToString("ddyyyyMM - hh:mm:ss")); //30201503 - 12:00:00

            Console.WriteLine(DateTime.Today); // imprime data atual => 17/10/2021 00:00:00
            Console.WriteLine(DateTime.Now); // imprime data atual c/ horario => 17/10/2021 22:11:00

            Console.WriteLine(DateTime.Today.AddDays(2)); // adianta 2 dias da data atual => 19/10/2021 00:00:00
            Console.WriteLine(DateTime.Today.AddDays(-2)); // remove 2 dias da data atual => 15/10/2021 00:00:00

            Console.WriteLine((DateTime.Today - new DateTime(2021,1,1)).Days); // diferenca de datas em dias => 88

            var calculo = DateTime.Today - TimeSpan.FromDays(2);
            Console.WriteLine(calculo);

            Console.Read();
        }
    }
}

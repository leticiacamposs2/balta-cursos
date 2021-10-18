using System;

namespace basic_concepts
{
    class StringFormatting
    {
        public void StringFormattingTypes()
        {
            object[] parametros = { "Natal", 2015, 800000, 10000000000 };

            string result = string.Format("{0} em {1}: população {2:N0}, Area {3:N1} m2", parametros);
            // Natal em 2015: população 800.000, Area 100.000.000,00 m2

            Console.WriteLine(result);

            Console.Read();
        }
    }
}

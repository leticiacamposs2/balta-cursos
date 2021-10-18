using System;
using System.Collections.Generic;
using System.Linq;

namespace basic_concepts
{
    class Dictionarys
    {
        public void DictionaryTypes()
        {
            var capitais = new Dictionary<string, string>();

            capitais.Add("RN", "Natal");
            capitais.Add("SP", "São Paulo");
            capitais.Add("RJ", "Rio de Janeiro");

            var estados = capitais.Keys.Where(x => x.StartsWith("R"));

            foreach (var uf in estados)
            {
                Console.WriteLine(uf);
            }

            var cidades = capitais.Values.Where(x => x.StartsWith("S"));

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            var capitaisBrasil = new Dictionary<string, List<string>();

            capitaisBrasil.Add("RN", new List<string> { "Natal", "Parnamirim", "Mossoró" });

            var cidadesBrasil = capitaisBrasil["RN"];

            foreach (var cidade in cidadesBrasil)
            {
                Console.WriteLine(cidade);
            }

            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace basic_concepts
{
    class Collections
    {
        public void CollectionsTypes()
        {
            var nomes = new string[]
            {
                "ana",
                "joão",
                "pedro",
                "paulo",
                "maria",
                "beatriz"
            };

            foreach (var nome in nomes)
            {
                Console.WriteLine(nome);
            }

            var cidades = new List<string>
            {
                "São Paulo",
                "Natal",
                "Rio de Janeiro",
                "Brasilia"
            };

            cidades.Add("Curitiba");

            var filtradas = from c in cidades
                            where c.StartsWith("S")
                            select c;

            var novoFiltro = cidades.Where(x => x.StartsWith("N"));

            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            Console.Read();
        }
    }
}

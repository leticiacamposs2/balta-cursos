using System;
using System.Collections.Generic;
using System.Text;

namespace basic_concepts
{
    class BasicSyntax
    {
        public void WorkingWithStrings()
        {
            var nome = "Leticia";
            var idade = 27;

            Console.WriteLine(nome + " tem " + idade + " anos.");

            Console.ReadLine();
        }

        public void WorkingWithBool(int idade)
        {
            bool maiorDeIdade = idade > 18;

            if (maiorDeIdade)
                Console.WriteLine("Essa pessoa é maior de idade");

            else if (idade == 0)
                Console.WriteLine("Idade inválida");

            else
                Console.WriteLine("Essa pessoa não é maior de idade");
        }
    }
}

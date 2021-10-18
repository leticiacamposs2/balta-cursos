using System;

namespace basic_concepts
{
    class ExceptionHandling
    {
        public void HandlingTypes()
        {
            var nome = "Leticia";
            var idade = 27;
            var maiorDeIdade = idade > 18;

            try
            {
                if (idade == 0)
                    throw new Exception("Idade Inválida");

                if (maiorDeIdade)
                    Console.WriteLine(nome + " é maior de idade");
                else
                    Console.WriteLine(nome + " NÂO é maior de idade");

                Console.WriteLine(nome + " tem " + idade + " anos.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro no sistema: " + e.Message);
            }

            Console.ReadLine();
        }
    }
}

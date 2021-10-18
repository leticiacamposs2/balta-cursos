using System;

namespace basic_concepts
{
    class MethodsAndExpressions
    {
        public void MethodsAndExpressionsTypes()
        {
            var numeros = ColecaoNumeros();
            Iteracao(numeros);

            var idade = 18;

            if (idade != 18)
                Console.ReadLine();
        }

        private static int[] ColecaoNumeros()
        {
            return new int[] { 1, 2, 3, 4 };
        }

        private static void Iteracao(int[] numeros)
        {
            foreach (var temp in numeros)
            {
                Console.WriteLine((temp + 1));
            }
        }
    }
}

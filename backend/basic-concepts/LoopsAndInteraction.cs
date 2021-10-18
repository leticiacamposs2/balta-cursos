using System;

namespace basic_concepts
{
    class LoopsAndInteraction
    {
        public void LoopsAndInteractionTypes()
        {
            var numeros = new int[] { 1, 2, 3, 4 };

            for (var i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(i);
            }

            var temp = 0;

            while (temp < numeros.Length)
            {
                Console.WriteLine(temp);
                temp++;
            }

            foreach (var n in numeros)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }
    }
}

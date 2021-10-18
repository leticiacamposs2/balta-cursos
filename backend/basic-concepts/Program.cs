using System;

namespace basic_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            BasicSyntax bs = new BasicSyntax();
            ExceptionHandling eh = new ExceptionHandling();
            LoopsAndInteraction li = new LoopsAndInteraction();
            MethodsAndExpressions me = new MethodsAndExpressions();
            Numbers nm = new Numbers();

            Console.WriteLine((("----- Basic Syntax ------").ToUpper()));
            bs.WorkingWithStrings();
            bs.WorkingWithBool(27);

            Console.WriteLine((("----- Exception Handling ------").ToUpper()));
            eh.HandlingTypes();

            Console.WriteLine((("----- Loops And Interaction ------").ToUpper()));
            li.LoopsAndInteractionTypes();

            Console.WriteLine((("----- Methods And Expressions Types ------").ToUpper()));
            me.MethodsAndExpressionsTypes();

            Console.WriteLine((("----- Numbers ------").ToUpper()));
            nm.NumbersTypes();
        }
    }
}

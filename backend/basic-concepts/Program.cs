using System;

namespace basic_concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((("----- Basic Syntax ------").ToUpper()));
            BasicSyntax bs = new BasicSyntax();
            bs.WorkingWithStrings();
            bs.WorkingWithBool(27);

            Console.WriteLine((("----- Exception Handling ------").ToUpper()));
            ExceptionHandling eh = new ExceptionHandling();
            eh.HandlingTypes();

            Console.WriteLine((("----- Loops And Interaction ------").ToUpper()));
            LoopsAndInteraction li = new LoopsAndInteraction();
            li.LoopsAndInteractionTypes();

            Console.WriteLine((("----- Methods And Expressions Types ------").ToUpper()));
            MethodsAndExpressions me = new MethodsAndExpressions();
            me.MethodsAndExpressionsTypes();

            Console.WriteLine((("----- Numbers ------").ToUpper()));
            Numbers nm = new Numbers();
            nm.NumbersTypes();

            Console.WriteLine((("----- Dates ------").ToUpper()));
            Dates dt = new Dates();
            dt.DatesTypes();

            Console.WriteLine((("----- String Formatting ------").ToUpper()));
            StringFormatting sf = new StringFormatting();
            sf.StringFormattingTypes();

            Console.WriteLine((("----- Collections ------").ToUpper()));
            Collections c = new Collections();
            c.CollectionsTypes();

            Console.WriteLine((("----- Dictionary ------").ToUpper()));
            Dictionarys d = new Dictionarys();
            d.DictionaryTypes();
        }
    }
}

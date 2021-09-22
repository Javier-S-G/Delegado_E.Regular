using Delegado_E.Regular.Model;
using System;
using System.Text.RegularExpressions;

namespace Delegado_E.Regular
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //crear 2 clases heredan de ivalidador
            //validador por regex?
            //validador normal
            //desde el main cargar regex.validation
            //validador.validate
            //decir si el email es valido o no en ambos casos

            UsingRegex emailUR = new UsingRegex("unodos@hotmail.com");
            Console.WriteLine($"Email validado por método Regex: {emailUR.Validator()}");
            Console.WriteLine("-------");

            NormalValidation emailNV = new NormalValidation("trescuatro@gmail.com");
            Console.WriteLine($"Email validado por método normal: {emailNV.Validator()}");
            Console.WriteLine("-------");

            Comparator comparador = emailUR.Validator;
            Console.WriteLine($"Email validado por delegado Regex: {comparador()}");
            Console.ReadLine();
        }
    }

    public delegate bool Comparator();
}
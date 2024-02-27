using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool completo = false;
            char genero = 'M';
            string nome = "Artimes";
            int idade = 24;
            double saldo = 10.4587;



            // Console.WriteLine(completo);
            // Console.WriteLine(genero);
            // Console.WriteLine(nome);
            // Console.WriteLine(saldo.ToString("F2"));
            // Console.WriteLine(saldo.ToString("F4"));
            // Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine("{0} tem {1} anos de idade e {2:F2} reias na conta bancaria", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos de idade e {saldo:F2} reais na conta bancaria");

            Console.WriteLine(nome + " tem " + idade + " anos de idade e " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");

        }
    }
}
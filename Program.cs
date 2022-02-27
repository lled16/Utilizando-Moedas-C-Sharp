using System;
using System.Globalization;

namespace Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // FORMATAÇÃO DE MOEDAS

            // decimal valor = 10.25m;

            // Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); //o C indica que ele vai colocar o R$ e o CULTURE.INFO transforma o valor pra ser exibido de acordo com o país



            // --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            // ARREDONDAR O VALOR


            decimal valor = 10.25m;

            Console.WriteLine(Math.Round(valor)); // só tira os valores depois da vírgula

            Console.WriteLine(Math.Ceiling(valor)); // arredonda pra cima

            Console.WriteLine(Math.Round(valor)); //arredonda pra baixo


        }
    }
}

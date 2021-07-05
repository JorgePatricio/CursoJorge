using System;
using System.Globalization;

namespace ExercicioClasses {
    class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dolar? ");
            ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Qual dolares você irá comprar? ");
            ConversorDeMoeda.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser pago em reais: R$ " + ConversorDeMoeda.CalculoDolarReal(ConversorDeMoeda.Dolar).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}

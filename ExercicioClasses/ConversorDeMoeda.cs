using System.Globalization;

namespace ExercicioClasses {
    class ConversorDeMoeda {

        public static double Cotacao, Dolar;

        public static double CalculoDolarReal(double dolar) {
            return ((dolar * 0.06)+dolar) * Cotacao;
        }

    }
}


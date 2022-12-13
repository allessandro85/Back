namespace Services
{
    public static class Fractions
    {
        public static string GetFractionSimplify(int numerador, int denominador)
        {
            int divisible = 0;
            for (; ; )
            {
                divisible = 0;
                for (int i = 9; i >= 2; i--)
                {
                    if (numerador % i == 0 && denominador % i == 0)
                    {
                        divisible = i; break;
                    }
                }
                if (divisible == 0) { break; }
                numerador = numerador / divisible;
                denominador = denominador / divisible;
            }
            return numerador.ToString() + "/" + denominador.ToString();
        }
    }
}
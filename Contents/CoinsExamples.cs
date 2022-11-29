using System.Globalization;

namespace StudiesCSharp.Contents
{
    public class CoinsExamples
    {
        public static void ReturnCoinsExamples()
        {
            decimal value = 10.32m;

            #region 02 - Formating Coins

                Console.WriteLine(value.ToString("G", CultureInfo.CreateSpecificCulture("pt-BR")));
                Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR")));
                Console.WriteLine(value.ToString("F", CultureInfo.CreateSpecificCulture("pt-BR")));
                Console.WriteLine(value.ToString("P", CultureInfo.CreateSpecificCulture("pt-BR")));
                Console.WriteLine(value.ToString("N", CultureInfo.CreateSpecificCulture("pt-BR")));

            #endregion

            #region 03 - Math

                Console.WriteLine(Math.Round(value));
                Console.WriteLine(Math.Ceiling(value));
                Console.WriteLine(Math.Floor(value));
                
            #endregion
        }
    }
}
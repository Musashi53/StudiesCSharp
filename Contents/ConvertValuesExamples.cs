namespace StudiesCSharp.Contents
{
    public class ConvertValuesExample
    {
        public static void ReturnConvertValueExamples()
        {
            // implicit convertion
            float valor = 21.4f;
            int outro = 25;

            valor = outro; // implicit convertion

            // explicit convertion
            int integerNumber1= 100;
            uint inteiroSemSinal = (uint)integerNumber1; // explicit convertion

            // Parse
            int integerNumber2 = int.Parse("100"); // 100

            // Convert
            int integerNumber3 = Convert.ToInt32("100"); // 100

            #region Convert
            /*
            static void Main(string[] args)
            {
                string inteiro = "100";
                int inteiroConvertido = Convert.ToInt32(inteiro);

                Console.WriteLine(inteiro);
                Console.WriteLine(inteiro + 200);

                Console.WriteLine(inteiroConvertido);
                Console.WriteLine(inteiroConvertido + 200);
            }
            */
            #endregion

            #region 24 - Convertendo Tipos
            /*
            static void Main(string[] args)
            {
                int inteiro = 100;
                float real = 25.4f;
                    
                real = inteiro;
                inteiro = int.Parse(real.ToString());
                inteiro = Convert.ToInt32(real);
                inteiro = Convert.ToByte(real);
            }
            */    
            #endregion
        }
    }
}
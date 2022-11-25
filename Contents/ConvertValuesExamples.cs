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
        }
    }
}
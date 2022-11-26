namespace StudiesCSharp.Contents
{
    public class RepeatingLoopsExamples
    {
        public static void RepeatRepeatingLoopsExamples()
        {
            #region For
                for (var i = 0; i <= 10; i++)
                    Console.WriteLine(i);

                // 1 to 10
                for (var i = 1; i <= 10; i++)
                    Console.WriteLine(i);

                // 0 to 9
                for (var i = 0; i < 10; i++)
                    Console.WriteLine(i);

                // 10 to 0
                for (var i = 0; i >= 10; i--)
                    Console.WriteLine(i);
            #endregion
            
            #region While
                var value = 0;

                // 0 to 5
                while (value <= 5)
                {
                    Console.WriteLine(value);
                    value++;
                }

                // 1 to 6
                while (value <= 5)
                {
                    value++;
                    Console.WriteLine(value);
                }

                // Infinite
                while (true)
                {
                    value++;
                    Console.WriteLine(value);
                }
            #endregion

            #region Do While
                do
                {
                    Console.WriteLine("teste");
                    value++;
                } while (value < 5);
            #endregion
        }
    }
}
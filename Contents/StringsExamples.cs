namespace StudiesCSharp.Contents
{
    public static class StringsExamples
    {
        public static void ReturnStringsExamples()
        {
            #region 01 - Guids
            
                var id = Guid.NewGuid();
                Console.WriteLine(id);
            
            #endregion
            
            #region 02 - Interpolação de strings
                var price = 12.2;
                var text1 = "O preço do produto é " + price + "apenas a vista!";
                var text2 = string.Format("O preço do produto é {0} apenas a vista! {1}", price, true);
                var text3 = @$"O preço do produto é {price} apenas \n a vista!";
            #endregion

            #region 03 - Comparação de Strings
            
                var text4 = "Testando";

                // CompareTo => retornará um inteiro
                Console.WriteLine(text4.CompareTo("Testando")); // 0
                Console.WriteLine(text4.CompareTo("testando")); // 1

                // Contains() => verifica se a string possui um determinado conjunto de caracteres
                var text5 = "Este texto é um teste";
                Console.WriteLine(text5.Contains("teste")); // true
                Console.WriteLine(text5.Contains("Testando metodo")); // false

                // StringComparison.OrdinalIgnoreCase => ignorará o case sensitive
                Console.WriteLine(text5.Contains("TestE", StringComparison.OrdinalIgnoreCase)); // true
            
            #endregion

            #region 04 - StartsWith/EndsWith
                var text6 = "Este texto é um teste";
        
                // StartsWith
                Console.WriteLine(text6.StartsWith("Este")); // True
                Console.WriteLine(text6.StartsWith("este")); // False
                Console.WriteLine(text6.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // True
                Console.WriteLine(text6.StartsWith("texto")); // False
        
                // EndsWith
                Console.WriteLine($" EndsWith => {text6.EndsWith("teste")}"); // True
                Console.WriteLine($" EndsWith => {text6.EndsWith("Teste")}"); // False
                Console.WriteLine($" EndsWith => {text6.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)}"); // True
                Console.WriteLine($" EndsWith => {text6.EndsWith("um")}"); // False
            #endregion

            #region 05 - Equals

                var text7 = "Este texto é um teste";
                // Equals => verifica se a string está exatamente igual
                Console.WriteLine($" Equals => {text7.Equals("Este texto é um teste")}"); // True
                Console.WriteLine($" Equals => {text7.Equals("este texto é um teste")}"); // False
                Console.WriteLine($" Equals => {text7.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase)}"); // True
                Console.WriteLine($" Equals => {text7.Equals("teste")}"); // False
            #endregion

            #region 06 - Índices

                var text8 = "este texto é um teste";

                // IndexOf => o primeiro
                Console.WriteLine(text8.IndexOf("e")); // 0
                Console.WriteLine(text8.IndexOf("E")); // -1

                // LastIndexOf => o ultimo
                Console.WriteLine(text8.LastIndexOf("s")); // 18

            #endregion
            
            string text9 = "This is a text variable";

            Console.WriteLine(text9.ToArray());

            // Trim
            text9.Trim();
            text9.TrimStart();
            text9.TrimEnd();
        }
    }
}
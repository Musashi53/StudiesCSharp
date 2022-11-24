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
            /*
            static void Main(string[] args)
            {
                var price = 12.2;
                var texto = "O preço do produto é " + price + "apenas a vista!";
                var texto = string.Format("O preço do produto é {0} apenas a vista! {1}", price, true);
                var texto = @$"O preço do produto é {price} apenas \n a vista!";
            }
            */
            #endregion

            #region 03 - Comparação de Strings
            
                var texto = "Testando";

                // CompareTo => retornará um inteiro
                Console.WriteLine(texto.CompareTo("Testando")); // 0
                Console.WriteLine(texto.CompareTo("testando")); // 1

                // Contains() => verifica se a string possui um determinado conjunto de caracteres
                var texto2 = "Este texto é um teste";
                Console.WriteLine(texto2.Contains("teste")); // true
                Console.WriteLine(texto2.Contains("Testando metodo")); // false

                // StringComparison.OrdinalIgnoreCase => ignorará o case sensitive
                Console.WriteLine(texto2.Contains("TestE", StringComparison.OrdinalIgnoreCase)); // true
            
            #endregion

            #region 04 - StartsWith/EndsWith
            /*
            static void Main(string[] args)
            {
                var texto = "Este texto é um teste";
        
                // StartsWith
                Console.WriteLine(texto.StartsWith("Este")); // True
                Console.WriteLine(texto.StartsWith("este")); // False
                Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // True
                Console.WriteLine(texto.StartsWith("texto")); // False
        
                // EndsWith
                Console.WriteLine($" EndsWith => {texto.EndsWith("teste")}"); // True
                Console.WriteLine($" EndsWith => {texto.EndsWith("Teste")}"); // False
                Console.WriteLine($" EndsWith => {texto.EndsWith("Teste", StringComparison.OrdinalIgnoreCase)}"); // True
                Console.WriteLine($" EndsWith => {texto.EndsWith("um")}"); // False
            }
            */
            #endregion

            #region 05 - Equals
            /*
            static void Main(string[] args)
            {
                var texto = "Este texto é um teste";

                // Equals => verifica se a string está exatamente igual
                Console.WriteLine($" Equals => {texto.Equals("Este texto é um teste")}"); // True
                Console.WriteLine($" Equals => {texto.Equals("este texto é um teste")}"); // False
                Console.WriteLine($" Equals => {texto.Equals("este texto é um teste", StringComparison.OrdinalIgnoreCase)}"); // True
                Console.WriteLine($" Equals => {texto.Equals("teste")}"); // False
            }
            */
            #endregion

            #region 06 - Índices
            /*
            static void Main(string[] args)
            {
                var texto = "este texto é um teste";

                // IndexOf => o primeiro
                Console.WriteLine(texto.IndexOf("e")); // 0
                Console.WriteLine(texto.IndexOf("E")); // -1

                // LastIndexOf => o ultimo
                Console.WriteLine(texto.LastIndexOf("s")); // 18
            }
            */
            #endregion
            
            string text = "This is a text variable";

            Console.WriteLine(text.ToArray());

            // Trim
            text.Trim();
            text.TrimStart();
            text.TrimEnd();
        }
    }
}
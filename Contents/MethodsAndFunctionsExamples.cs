namespace StudiesCSharp.Contents
{
    public class MethodsAndFunctionsExamples
    {
        public static void ReturnMethodsAndFunctionsExamples()
        {
            var returnName = ReturnName("Yuri", "Mendes", 21);
            Console.WriteLine(returnName);
        }

        public static string ReturnName(string name, string lastName, int age)
        {
            return name + " " + lastName + age.ToString();
        }
    }
}
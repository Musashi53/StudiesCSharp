namespace StudiesCSharp.ObjectOrientedProgramming.StaticClassesExamples
{
    public class StaticClassesExamples
    {
        public static void ReturnStaticClassesExamples()
        {
            // var payment = new Payment(); // ERROR
            Payment.Recovery = DateTime.Now;
        }
    }

    public static class Payment
    {
        public static DateTime Recovery { get; set; }
    }
}
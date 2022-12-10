namespace StudiesCSharp.ObjectOrientedProgramming.UsingDisposeExamples
{
    public class UsingDisposeExamples
    {
        public static void ReturnUsingDisposeExamples()
        {
            var payment = new Payment();
            payment.Dispose();

            using(var payment2 = new Payment())
            {
                Console.WriteLine("Processing payment...");
            }

        }
    }

    public class Payment : IDisposable
    {
        public Payment()
        {
            Console.WriteLine("inicializing payment...");
        }

        public void Dispose()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Finallizing payment...");
        }
    }
}
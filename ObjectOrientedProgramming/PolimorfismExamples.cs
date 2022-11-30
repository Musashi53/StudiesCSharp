namespace StudiesCSharp.ObjectOrientedProgramming.PolimorfismExamples
{
    public class PolimorfismExamples
    {
        public static void ReturnPolimorfismExamples()
        {

        }
    }

    class Payment
    {
        public DateTime Maturity;
        public virtual void Pay() {}
    }

    class CreditCardPayment: Payment
    {
        public int CreditCardNumber { get; set; }
        public override void Pay()
        {
            
            base.Pay();
            // Credit Card rule
        }

        public override string ToString()
        {
            return Maturity.ToString("dd/MM/yyyy");
        }
    }
}
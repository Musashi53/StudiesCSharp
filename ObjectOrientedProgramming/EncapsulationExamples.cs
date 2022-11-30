namespace StudiesCSharp.ObjectOrientedProgramming
{
    public class EncapsulationExamples
    {
        public static void ReturnEncapsulationExamples()
        {
            var payment = new Payment();
            var receiment = new Receivement();

            if(DateTime.UtcNow == DateTime.Now)
            {
                payment.Pay();
            }
            else
            {
                receiment.ReceivePayment();
            }
        }
    }

    class Payment
    {
        DateTime Maturity { get; set; }
        DateTime PaymentDate { get; set; }
        DateTime PayAt { get; set; }

        public void Pay()
        {
            PayAt = DateTime.UtcNow;
        }
    }

    class Receivement
    {
        public void ReceivePayment() {}
    }
}
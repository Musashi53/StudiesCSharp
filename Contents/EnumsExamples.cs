namespace StudiesCSharp.Contents
{
    public class EnumsExample
    {
        public void ReturnEnumsExample()
        {
            var keyboard = new Product();
            keyboard.Id = 1;
            keyboard.Name = "Keyboard";
            keyboard.Price = 99.90f;
            keyboard.Type = EProductType.Product;
            Console.WriteLine(keyboard.Id);
            Console.WriteLine(keyboard.Price);
            Console.WriteLine(keyboard.PriceInDolar(5.45f));
        }
    }

    struct Product
    {
        // Proprieties
        public int Id;
        public string Name;
        public float Price;
        public EProductType Type;

        // Methods
        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }
    }
    enum EProductType
    {
        Product = 1,
        Service = 2
    }
}
namespace StudiesCSharp.Contents
{
    public class StructsExamples
    {
        public static void ReturnStructsExamples()
        {
            // To create a struct 1
            var laptopGamer = new Product1();
            laptopGamer.Id = 1;
            laptopGamer.Name = "Laptop Gamer";
            laptopGamer.Price = 99.90f;
            Console.WriteLine(laptopGamer.Id);
            Console.WriteLine(laptopGamer.Price);
            Console.WriteLine(laptopGamer.PriceInDolar(5.45f));

            // To create a struct 2
            var mouseGamer = new Product2(1, "Mouse gamer", 99.90f);
            Console.WriteLine(mouseGamer.Id);
            Console.WriteLine(mouseGamer.Name);
            Console.WriteLine(mouseGamer.Price);
        }
    }

    struct Product1
    {
        // Proprieties
        public int Id;
        public string Name;
        public float Price;

        // Methods
        public float PriceInDolar(float dolar)
        {
            return Price * dolar;
        }
    }

    public struct Product2
    {
        public Product2(int id, string name, float price)
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name;
        public float Price;
    }
}
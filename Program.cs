using StudiesCSharp.Contents;

namespace StudiesCSharp
{
  class Program
  {
    public static void Main(string[] args)
    {
      StringsExamples.ReturnStringsExamples();
    }    

    

    #region Name
    /*
      static void Main(string[] args)
      {
        Product mouse = new Product();
        mouse.Id = 21;
        mouse.Title = "Mouse Gamer";
        mouse.Price = 299.99f;
        mouse.Type = EProductType.Product;
      

        Console.WriteLine(mouse.Id);
        Console.WriteLine(mouse.Title);
        Console.WriteLine(mouse.Price);
        Console.WriteLine(mouse.Type);
        Console.WriteLine((int)mouse.Type);
      }
    */
    #endregion

    #region Structs
    /*
      struct Product
      {
        public int Id;
        public string Title;
        public float Price;
        public EProductType Type;
      }
      
      public double PriceInDolar(double dolar)
      {
        return Price * dolar;
      }
      
      public Product(int id, string title, float price, EProductType type)
      {
        Id = id;
        Title = title;
        Price = price;
        Type = type;
      }
    */
    #endregion
  
  

    #region ENUMS
      /*
        enum EProductType
        {
          Product = 1,
          Service = 2
        }
      */
    #endregion
  }
}
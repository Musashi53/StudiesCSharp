using StudiesCSharp.Contents;

namespace StudiesCSharp
{
  class Program
  {
    public static void Main(string[] args)
    {
      StringsExamples.ReturnStringsExamples();
    }

    #region 23 - Convert
    /*
      static void Main(string[] args)
      {
        string inteiro = "100";
        int inteiroConvertido = Convert.ToInt32(inteiro);

        Console.WriteLine(inteiro);
        Console.WriteLine(inteiro + 200);

        Console.WriteLine(inteiroConvertido);
        Console.WriteLine(inteiroConvertido + 200);
      }
    */
    #endregion

    #region 24 - Convertendo Tipos
    /*
      static void Main(string[] args)
      {
        int inteiro = 100;
        float real = 25.4f;
            
        real = inteiro;
        inteiro = int.Parse(real.ToString());
        inteiro = Convert.ToInt32(real);
        inteiro = Convert.ToByte(real);
      }
    */    
    #endregion

    #region 30 - Operadores Lógicos
    /*
      static void Main(string[] args)
      {
        int x = 12;
        bool entre = (x > 25) && (x < 40); // false
        bool ou = (x > 25) || (x < 40); // True
        bool negacao = !(x < 25); // False

        Console.WriteLine(negacao);  
      }
    */   
    #endregion

    #region Utilizando o IF
    /*
      static void Main(string[] args)
      {
        int idade = 21;
        int maioridade = 18;
        int idadeMaxima = 65;

        if(idade >= maioridade && idade < idadeMaxima)
        {
          Console.WriteLine("verdadeiro");
        }
        else
        {
          Console.WriteLine("falso");
        }
      }
    */            
    #endregion

    #region 33 - Estrutura Condicional: Switch
    /*
      static void Main(string[] args)
      {
        string nome = "Yuri";

        switch (nome)
        {
          case "Yuri": Console.WriteLine(1); break;
          case "Silva": Console.WriteLine(2); break;
          case "Mendes": Console.WriteLine(3); break;
          default: Console.WriteLine(4); break;
        }
      }
    */  
    #endregion

    #region Name
    /*
      static void Main(string[] args)
      {
        var nome = RetornaNome("Yuri", "Mendes");
        Console.WriteLine(nome);

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

      static string RetornaNome(string nome, string sobrenome, int idade = 21)
      {
        return nome + " " + sobrenome + idade.ToString();
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
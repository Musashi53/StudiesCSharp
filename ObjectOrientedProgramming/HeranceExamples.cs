namespace StudiesCSharp.ObjectOrientedProgramming
{
    public class HeranceExamples
    {
        public static void ReturnHeranceExamples()
        {
            var bikeFactory = new BikeFactory();
            var carFactory = new CarFactory();
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: 
                {
                    bikeFactory.FactoryEngine();
                    bikeFactory.FactoryTires();
                    bikeFactory.FactoryWheels();
                    bikeFactory.FactoryBodyBike();
                    break;
                }
                case 2:
                {
                    carFactory.FactoryEngine();
                    carFactory.FactoryTires();
                    carFactory.FactoryWheels();
                    carFactory.FactoryFrame();
                    break;
                }
                default: Console.WriteLine("Invalid Option!"); break;
            }
        }
    }

    class Factory
    {
        DateTime FactoryAt;
        public void FactoryEngine() {}
        public void FactoryWheels() {}
        public void FactoryTires() {}
    }

    class BikeFactory : Factory
    {
        public void FactoryBodyBike() {}
    }

    class CarFactory : Factory
    {
        public void FactoryFrame() {}
    }
}
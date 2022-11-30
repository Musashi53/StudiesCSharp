namespace StudiesCSharp.ObjectOrientedProgramming
{
    public class AbstractionExamples
    {
        public static void ReturnAbstractExamples()
        {
            var car = new Car();
            // sets props
            car.Mark = "Nissan";
            car.Model = "Skyline GTR R32";
            car.HorsePower = 295;

            car.Acelerate(); // get method
            car.Break();
        }
    }

    class Car
    {
        // Props
        public string Mark { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public int CurrentVelocity { get; set; }

        // Methods
        public void Acelerate()
        {
            CurrentVelocity =+ 1;
        }

        public void Break()
        {
            CurrentVelocity =- 1;
        }
    }
}
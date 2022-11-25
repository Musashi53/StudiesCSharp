namespace StudiesCSharp.Contents
{
    public class ConditionalStructureExamples
    {
        public static void ReturnConditionalStructureExamples()
        {
            #region Logic Operators
                int x = 12;
                bool inBetween = (x > 25) && (x < 40); // false
                bool or = (x > 25) || (x < 40); // True
                bool negation = !(x < 25); // False

                Console.WriteLine(negation);
            #endregion

            #region IF
            
                int age = 21;
                int ageOfMajority = 18;
                int maxAge = 65;

                if(age >= ageOfMajority && age < maxAge)
                {
                Console.WriteLine("True");
                }
                else
                {
                Console.WriteLine("False");
                }                        
            #endregion

            #region Switch
                string name = "Yuri";

                switch (name)
                {
                case "Yuri": Console.WriteLine(1); break;
                case "Silva": Console.WriteLine(2); break;
                case "Mendes": Console.WriteLine(3); break;
                default: Console.WriteLine(4); break;
                }
            #endregion
        }
    }
}
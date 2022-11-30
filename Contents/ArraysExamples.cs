namespace StudiesCSharp.Contents
{
    public class ArraysExamples
    {
        public static void ReturnArraysExamples()
        {
            #region 01 - Arrays
                
                var myArray = new int[3] {1,2 ,3};
                var otherArray = new int[myArray.Length + myArray.Length];

                myArray.CopyTo(otherArray, 0);
                myArray.CopyTo(otherArray, myArray.Length);
            #endregion

            #region Foreach

                var employees = new Employee[5];
                employees[0] = new Employee() { Id = 666, Name = "Yuri" };
                employees[1] = new Employee() { Id = 333, Name = "Ricardo" };

                foreach(var employee in employees)
                {
                    Console.WriteLine(employee.Id);
                    Console.WriteLine(employee.Name);
                }
            #endregion

            #region Name
                // Array are reference objects
            #endregion
        }
    }

    public struct Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
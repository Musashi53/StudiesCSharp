namespace StudiesCSharp.Contents
{
    public class ExceptionsExamples
    {
        public static void ReturnExceptionsExamples()
        {
            #region 01 - Exceptions

                var arr = new int[3];

                for (int index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]); // System.IndexOutOfRangeException
                }

            #endregion

            #region 02 - Try/Catch

                try
                {
                    for (int index = 0; index < 10; index++)
                    {
                        Console.WriteLine(arr[index]);
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.HelpLink);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ops, something went wrong");
                }
                
            #endregion

            #region 03 - Handling Errors

                try
                {
                    for (int index = 0; index < 10; index++)
                    {
                        Console.WriteLine(arr[index]);
                    }
                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("index in list not found");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.HelpLink);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ops, something went wrong");
                }

            #endregion

            #region 04 - Disparing Errors
                try
                {
                    Register("");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.InnerException);
                    Console.WriteLine(ex.HelpLink);
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Ops, something went wrong");
                }
            #endregion
        }

        static void Register(string text)
        {
            if(string.IsNullOrEmpty(text))
                throw new ArgumentNullException("The text isn't can be null or empty");
        }
    }

    public class MyException : Exception
    {
        public MyException(DateTime date)
        {
            WhenHappining = date;
        }
        public DateTime WhenHappining { get; set; }
    }
}
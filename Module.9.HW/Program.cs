namespace Module._9.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exceptions = new Exception[] { 
                new ArgumentException(), 
                new ArgumentNullException(), 
                new IndexOutOfRangeException(), 
                new FormatException(),
                new InsertValueException("Value is not correct! Please try again!")
            };

            foreach (var exception in exceptions)
            {
                try
                {
                    throw exception;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(exception.GetType().FullName);
                    Console.WriteLine();
                }
            }
        }
    }
}

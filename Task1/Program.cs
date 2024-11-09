namespace Task1;

class Program
{
    static void Main(string[] args)
    {
        Exception[] exceptions = new Exception[5]
        {
            new ArgumentException("Argument exception"),
            new NotImplementedException("NotImplementedException"),
            new DivideByZeroException("DivideByZeroException"),
            new FileNotFoundException("FileNotFoundException"),
            new InvalidNameException("Недопустимое имя")
        };

        foreach (Exception exception in exceptions)
        {
            try
            {
                throw exception;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        Console.ReadLine();
    }
}
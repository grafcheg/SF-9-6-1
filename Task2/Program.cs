namespace Task2;

class Program
{
    static void Main(string[] args)
    {
        UserInput userInput = new UserInput();
        userInput.InputHandlerNotify += ProccessList;

        try
        {
            userInput.ReadUserInputAndInvokeSort();
        }
        catch (InputException e)
        {
            Console.WriteLine(e);
        }
        
        Console.ReadKey();
    }

    /// <summary>
    /// Обработчик события, проверяем ввод и проводим операции со списком фамилий
    /// </summary>
    /// <param name="input"></param>
    public static void ProccessList(string input)
    {
        List<string> surnamesList =
        [
            "Ефремов",
            "Немченко",
            "Иванов",
            "Петров",
            "Сидоров"
        ];

        if (input == "1")
        {
            surnamesList.Sort();
        }
        else if (input == "2")
        {
            surnamesList.Sort();
            surnamesList.Reverse();
        }
        
        foreach (string surname in surnamesList)
        {
            Console.WriteLine(surname);
        }
    }
}
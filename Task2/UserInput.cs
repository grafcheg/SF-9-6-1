namespace Task2;

class UserInput
{
    public delegate void InputHandler(string input);

    public InputHandler? InputHandlerNotify;

    public void ReadUserInputAndInvokeSort()
    {
        string userInput = String.Empty;

        do
        {
            Console.WriteLine("Введите '1' для сортировки от А до Я или '2' для сортировки от Я до А:");
            userInput = Console.ReadLine();
        } while (String.IsNullOrEmpty(userInput));

        if (userInput == "1" || userInput == "2")
        {
            InputHandlerNotify?.Invoke(userInput);
        }
        else
        {
            throw new InputException("Ошибка ввода.");
        }
    }
}
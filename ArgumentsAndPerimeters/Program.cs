
Console.WriteLine("Enter a word.");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);  //userInput - on argument

static void PrintAnyWord(string anyString) //anyString - on parameeter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i ++)
    {
        Console.WriteLine(anyString);
    }
}
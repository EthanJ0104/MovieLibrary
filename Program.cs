// See https://aka.ms/new-console-template for more information
using NLog;

string option = "1";

while (option == "1" || option == "2")
{
    Console.Write("Enter 1 to view movies in the file, enter 2 to add a movie. Enter anything else to exit: ");
    option = Console.ReadLine();

    if (option == "1")
    {

    }

    if (option == "2")
    {

    }
}

Console.WriteLine("Goodbye");

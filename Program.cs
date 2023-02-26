// See https://aka.ms/new-console-template for more information
using NLog;

string option = "1";
string file = "movies.csv";

while (option == "1" || option == "2")
{
    Console.Write("Enter 1 to view movies in the file, enter 2 to add a movie. Enter anything else to exit: ");
    option = Console.ReadLine();

    if (option == "1")
    {
        if (File.Exists(file))
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(',');
                Console.WriteLine("Movie ID: {0}, Title: {1}, Genres: {2}", arr[0], arr[1], arr[2]);
            }
            sr.Close();
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }

    if (option == "2")
    {
        
    }
}

Console.WriteLine("Goodbye");

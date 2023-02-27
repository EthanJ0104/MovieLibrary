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
        int numMovies = 0;
        Console.Write("How many movies would you like to add: ");
        try
        {
            numMovies = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Invalid input.");
        }
        List<string> newMovies = new List<string>();

        for (int i = 0; i < numMovies; i++)
        {
            Console.Write("Movie ID: ");
            string id = Console.ReadLine();
            Console.Write("Movie Name: ");
            string name = Console.ReadLine();
            Console.Write("Genre: ");
            string genre = Console.ReadLine();
            var newLine = string.Format("{0}, {1}, {2}", id, name, genre);
            newMovies.Add(newLine);
        }

        File.AppendAllLines("movies.csv", newMovies);
    }
}

Console.WriteLine("Goodbye");

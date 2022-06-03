// See https://aka.ms/new-console-template for more information
using Exercise_Collections_Set.Entities;
using System.Globalization;


Console.Write("Enter file full path: ");
string path = Console.ReadLine();

HashSet<UserLog> set = new HashSet<UserLog>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string[] logData = sr.ReadLine().Split(' ');
            string username = logData[0];
            DateTime accessDate = DateTime.ParseExact(logData[1], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
            set.Add(new UserLog(username, accessDate));
        }
        Console.WriteLine("Total users: " + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
// See https://aka.ms/new-console-template for more information
using KnowCheck2;

Console.WriteLine("How many records do you want to add?");

var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Author>();
{
    for (int i = 0; i < numberOfRecords; i++)
    {
        var Author = new Author();

        Console.WriteLine("Enter the Type of Book");
        Author.Type = Console.ReadLine();

        Console.WriteLine("Enter the Title of the Book");
        Author.Title = Console.ReadLine();

        Console.WriteLine("Enter the Number of Pages");
        Author.Pages = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Author of the Book");
        Author.Name = Console.ReadLine();

        recordList.Add(Author);
    }
    foreach (var author in recordList)
    {
        Console.WriteLine($"Type: {author.Type}, Title: {author.Title},Pages: {author.Pages} Author: {author.Name}");
       
    }
    Console.WriteLine("Goodbye");
}

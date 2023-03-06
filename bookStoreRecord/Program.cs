public record Bookstore(int ID, string Title, string Author, double Price);

class Program
{
    public static void Main()
    {
        Bookstore bookstore1 = new(88, "Blood Music", "Greg Bear", 19.99);
        Bookstore bookstore2 = new(923, "Shadow Divers", "Robert Kurson", 15.99);
        Bookstore bookstore3 = new(8391, "Shatterday", "Harlan Ellison", 13.99);

        Console.WriteLine("ID: {0}", bookstore1.ID);
        Console.WriteLine("TITLE: {0}", bookstore1.Title);
        Console.WriteLine("AUTHOR: {0}", bookstore1.Author);
        Console.WriteLine("PRICE: {0}", bookstore1.Price);
        Console.WriteLine();
        Console.WriteLine("ID: {0}", bookstore2.ID);
        Console.WriteLine("TITLE: {0}", bookstore2.Title);
        Console.WriteLine("AUTHOR: {0}", bookstore2.Author);
        Console.WriteLine("PRICE: {0}", bookstore2.Price);
        Console.WriteLine();
        Console.WriteLine("ID: {0}", bookstore3.ID);
        Console.WriteLine("TITLE: {0}", bookstore3.Title);
        Console.WriteLine("AUTHOR: {0}", bookstore3.Author);
        Console.WriteLine("PRICE: {0}", bookstore3.Price);
    }
}
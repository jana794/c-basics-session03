using System;
using System.Text;

class Program
{
    static string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

    static void PrintFirstBook()
    {
        if (books.Length == 0)
        {
            return;
        }
        Console.WriteLine(books[0]);
    }

    static void Main()
    {
        Console.WriteLine(" Q1 ");
        string title = "clean code";
        string upperTitle = title.ToUpper();
        Console.WriteLine(title);
        Console.WriteLine(upperTitle);

        Console.WriteLine(" Q2 ");
        string s1 = "Clean Code";
        string s2 = "Clean Code";
        Console.WriteLine(ReferenceEquals(s1, s2));

        Console.WriteLine(" Q3 ");
        StringBuilder sb = new StringBuilder();
        sb.Append("Book List");
        sb.Append(" - Updated");
        Console.WriteLine(sb);

        Console.WriteLine(" Q4 ");
        sb.Replace("Book List", "Library");
        Console.WriteLine(sb);

        Console.WriteLine(" Q5 ");
        title = "Clean Code";
        int pages = 464;
        string sentence1 = "Book: " + title + ", Pages: " + pages;
        Console.WriteLine(sentence1);

        Console.WriteLine(" Q6 ");
        string sentence2 = $"Book: {title}, Pages: {pages}";
        Console.WriteLine(sentence2);

        Console.WriteLine(" Q7 ");
        string sentence3 = string.Format("Book: {0}, Pages: {1}", title, pages);
        Console.WriteLine(sentence3);

        Console.WriteLine(" Q8 ");
        if (pages > 300)
        {
            Console.WriteLine("Long Book");
        }
        else
        {
            Console.WriteLine("Short Book");
        }

        Console.WriteLine(" Q9 ");
        bool isAvailable = true;
        if (pages > 300 && isAvailable)
        {
            Console.WriteLine("You can borrow this book");
        }

        Console.WriteLine(" Q10 ");
        title = "Refactoring";
        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;
        }

        Console.WriteLine(" Q11 ");
        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
        Console.WriteLine(sizeLabel);

        Console.WriteLine(" Q12 ");
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {books[i]}");
        }

        Console.WriteLine(" Q13 ");
        int index = 0;
        while (index < books.Length)
        {
            Console.WriteLine(books[index]);
            index++;
        }

        Console.WriteLine(" Q14 ");
        int count = 0;
        do
        {
            Console.WriteLine("Checking book...");
            count++;
        } while (count < 3);

        Console.WriteLine(" Q15 ");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine(" Q16 ");
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == "Refactoring")
            {
                break;
            }
            Console.WriteLine(books[i]);
        }

        Console.WriteLine(" Q17 ");
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == "The Pragmatic Programmer")
            {
                continue;
            }
            Console.WriteLine(books[i]);
        }

        Console.WriteLine(" Q18 ");
        PrintFirstBook();
    }
}


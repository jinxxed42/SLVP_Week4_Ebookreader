using SLVP_Week4_Ebookreader;

Book b = new Book("Stephen King", "Carrie", new DateOnly(1974, 4, 5), 199);


Console.WriteLine("Author: " + b.Author + " Title: " + b.Title + " Release date: " + b.ReleaseDate + " Pages: " + b.Pages);
Console.WriteLine(b.Read(10));

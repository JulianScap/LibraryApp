namespace LibraryApp;

internal class User
{
    public IList<Book> Books { get; set; } = new List<Book>();

    public string Name { get; set; }

    public User(string name)
    {
        Name = name;
    }

    internal void GiveBook(Book book)
    {
        Books.Add(book);
    }

    public override string ToString()
    {
        return $"User {Name} has books {string.Join(", ", Books)}";
    }
}
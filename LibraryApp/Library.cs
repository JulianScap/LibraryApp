namespace LibraryApp;

public class Library
{
    private readonly IList<Book> books = new List<Book>();

    internal void AddToLibrary(Book book)
    {
        books.Add(book);
    }

    internal void BorrowBook(User user, Book book)
    {
        user.GiveBook(book);
        books.Remove(book);
    }

    internal void BorrowBook(User user, string title)
    {
        Book foundBook = null;

        foreach (Book book in books)
        {
            if (book.Title == title)
            {
                foundBook = book;
            }
        }

        if (foundBook != null)
        {
            BorrowBook(user, foundBook);
        }
    }

    internal void ReturnBooks(User user)
    {
        foreach (Book book in user.Books)
        {
            AddToLibrary(book);
        }

        user.Books.Clear();
    }

    public override string ToString()
    {
        return $"A library with the books {string.Join(", ", books)}";
    }
}
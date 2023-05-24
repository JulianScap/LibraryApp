
using LibraryApp;

Book harryPotter = new("Harry Potter");

Library library = new();

library.AddToLibrary(harryPotter);
library.AddToLibrary(new Book("A good book"));
library.AddToLibrary(new Book("A bad book"));


User user = new("Joe");

Console.WriteLine("Initialisation");
Console.WriteLine(library);
Console.WriteLine(user);

library.BorrowBook(user, harryPotter);
library.BorrowBook(user, "A good book");

Console.WriteLine("After borrow");
Console.WriteLine(library);
Console.WriteLine(user);

library.ReturnBooks(user);

Console.WriteLine("After return");
Console.WriteLine(library);
Console.WriteLine(user);

using System;
public class BookService : IBookService
{
    public static List<Book> Books { get; set; }
    public BookService()
    {
        Books = new List<Book>();
    }


    public Book GetBookById(int id)
    {
        return Books.Find(x => x.Id == id);
    }
    public Book GetBookByTitle(string title)
    {
        return Books.Find(x => x.Title == title)
    }
    public List<Book> GetBookByTitle()
    {
        return Books;
    }
    public void CreateBook(Book book)
    {
        Books.Add(book);
    }
    public void DeleteBook(int id)
    {
        if (id != null)
        {
            var book = Books.Find(x => x.Id == id);
            if (book != null)
            {
                Books.Remove(book)
                    }
            else
            {
                throw new KeyNotFoundException($"Book with ID {id} not found.");
            }
        }

    }
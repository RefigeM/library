namespace LibraryManagementApp.Services.Concretes;

public class LibrarianService : ILibrarianService
{
    public List<Librarian> Librarians;
    public LibrarianService()
    {
        Librarians = new List<Librarian>();
    }
    public Librarian GetLibrarianById(int id)
    {
        return Librarians.Find(x => x.Id == id);
    }
    public Librarian GetLibrarianByTitle(string title)
    {
        return Librarians.Find(x => x.title == title);
    }
    public List<Librarian> GetAllLibrarian()
    {
        return Librarians;
    }
    public void CreateLibrarian(Librarian librarian)
    {
        Librarians.Add(librarian);
    }
    public void DeleteLibrarian(int id)
    {
        var librarian = Librarians.Find(x => x.Id == id);
        if (librarian != null)
        {
            Librarians.Remove(librarian);
        }
        else
        {
            throw new KeyNotFoundException($"Library member with ID {id} not found.");
        }
    }
}
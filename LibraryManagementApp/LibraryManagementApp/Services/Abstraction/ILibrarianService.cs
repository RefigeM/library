namespace LibraryManagementApp.Services.Abstraction;

public interface ILibrarianService
{
    Librarian GetLibrarianById(int id);
    Librarian GetLibrarianByTitle(string title);
    List<Librarian> GetAllLibrarian();
    void CreateLibrarian(Librarymember librarymember);
    void DeleteLibrarian(int id);
}

using LibraryManagementApp.Models;

namespace LibraryManagementApp.Services.Abstraction;

public interface ILibrarymemberService 
{
    Librarymember GetLibrarymemberById(int id);
    Librarymember GetLibrarymemberByTitle(string title);
    List<Librarymember> GetAllLibrarymember();
    void CreateLibrarymember(Librarymember librarymember);
    void DeleteLibrarymember(int id);
}

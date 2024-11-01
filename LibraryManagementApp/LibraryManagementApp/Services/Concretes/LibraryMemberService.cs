using LibraryManagementApp.Models;
namespace LibraryManagementApp.Services.Concretes;
public class LibrarymemberService : ILibrarymemberService
{
	public static List<Librarymember> Librarymembers;
	public LibrarymemberService()
	{
		Librarymembers = new List<Librarymember>();
	}

	public Librarymember GetLibrarymemberById(int id)
	{
		return Librarymembers.Find(x => x.Id == id);
	}
	public Librarymember GetLibrarymemberByTitle(string title)
	{
		return Librarymembers.Find(x => x.title == title)

	}
	public List<Librarymember> GetAllLibrarymember()
	{
		return Librarymembers;
	}
	public void CreateLibrarymember(Librarymember librarymember)
	{
		Librarymembers.Add(librarymember);
	}
	public void DeleteLibrarymember(int id)
	{
		var libraryMember = Librarymembers.Find(x => x.Id == id);
		if (libraryMember != null)
		{
			Librarymembers.Remove(libraryMember);
		}
		else
		{
			throw new KeyNotFoundException($"Library member with ID {id} not found.");

		}
	}
}
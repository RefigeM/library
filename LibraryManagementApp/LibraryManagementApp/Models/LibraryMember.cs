namespace LibraryManagementApp.Models;

public sealed class LibraryMember : Person
{
    public static int counter { get; set; }
    public int Id { get; set; }
    public DateTime MembershipDate { get; set; }

    public LibraryMember(string name) : base(name)
    {
        Id=++counter;
    }
}




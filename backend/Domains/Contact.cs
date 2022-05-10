namespace backend.domains;

public class Contact
{
    public int Id { get; set; }
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";

    public Contact(int id, string email, string fullname)
    {
        this.Id = id;
        this.FullName = fullname;
        this.Email = email;
    }
}
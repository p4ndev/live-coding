namespace backend.interfaces;

public interface IContactRepository{
    IEnumerable<Contact> All();
    IEnumerable<Contact> FindBy(string fullName);
}
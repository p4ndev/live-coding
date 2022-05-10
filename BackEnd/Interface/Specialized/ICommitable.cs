namespace BackEnd.Interface.Specialized;

public interface ICommitable{
    Task<bool> SaveAsync();
}

namespace BackEnd.Interface.Specialized;

public interface IRetrievable<T> where T : class{
    Task<IEnumerable<T>?> RetrieveAsync();
}

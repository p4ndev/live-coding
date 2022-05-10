using BackEnd.Interface.Base;

namespace BackEnd.Entity;

public class Employee : IEntity{

    public int                             Id          { get; set; }
    public string                          Email       { get; set; }
    public ICollection<EmployeeActivity>   Activities  { get; set; }
    public ICollection<Quarentine>         Quarentines { get; set; }

}
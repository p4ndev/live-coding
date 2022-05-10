using BackEnd.Interface.Base;

namespace BackEnd.Entity;

public class ActivityType : IEntity{

    public int                             Id          { get; set; }
    public string                          Name        { get; set; }
    public ICollection<EmployeeActivity>   Activities  { get; set; }

}

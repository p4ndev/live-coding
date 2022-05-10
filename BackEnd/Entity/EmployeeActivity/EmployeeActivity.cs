using BackEnd.Interface.Base;

namespace BackEnd.Entity;

public class EmployeeActivity : IEntity, ITrackable{

    public int                  Id              { get; set; }
    public Employee             Employee        { get; set; }    
    public ActivityType         ActivityType    { get; set; }
    public DateTime             CreatedAt       { get; set; }

}

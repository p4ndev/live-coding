using BackEnd.Interface.Base;

namespace BackEnd.Entity;

public class Quarentine : IEntity, ITrackable{

    public int          Id              { get; set; }
    public Employee     Employee        { get; set; }
    public string       RelatedEmail    { get; set; }
    public DateTime     CreatedAt       { get; set; }

}

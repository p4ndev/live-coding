namespace BackEnd.Entity;

public class EmployeeActivityDTO : EmployeeDTO{
    public DateTime      Period          { get; set; }
    public string        Action          { get; set; }
}
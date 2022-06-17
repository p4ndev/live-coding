namespace Udemy;

public interface IBaseProblem {
    
    public string? Problem { get; init; }
    public bool Done { get; set; }

    public void Naive();
    public void Proper();

}

public interface IProblem<InputType, OutputType> : IBaseProblem{

    public InputType? Input { get; init; }
    public OutputType? Output { get; set; }

}

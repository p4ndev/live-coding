namespace Udemy;

public class CountUniqueNumbers : IProblem<int[]?, int?>{

    public int[]? Input { get; init; }
    public string? Problem { get; init; }
    
    public int? Output { get; set; }
    public bool Done { get; set; }

    public CountUniqueNumbers(){
        Done = false;
        Output = null;
        Input = new[] { 1, 1, 1, 1, 2, 3, 4, 4, 5 };
        Problem = "Given an arrays count unique numbers found.";
    }

    private void Cases() {

        // Edge
        if (Input is null) throw new ArgumentNullException();

        // Corner
        if (Input!.Length == 0) throw new InvalidDataException();

    }

    public void Naive(){
        throw new NotImplementedException();
    }

    public void Proper() {
        Cases();

        int i = 0;

        for (int j = 0; j < Input!.Length; j++) {
            if (Input![i] != Input![j]) {
                i++;
                Input![i] = Input![j];
            }
        }
        
        Done = true;
        Output = i + 1;
    }

}
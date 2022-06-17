namespace Udemy;

public class MaxSubArraySum : IProblem<int[]?, int>{

    private const int PAIRS = 3;

    public int[]? Input { get; init; }
    public string? Problem { get; init; }

    public int Output { get; set; }
    public bool Done { get; set; }

    public MaxSubArraySum(){
        Input = new[] { 2, 6, 9, 2, 1, 8, 5, 6, 3 };
        Problem = $"Given an array, find a maximum matching pair with {PAIRS} numbers sum.";
    }

    private void Cases() {

        // Edge

        if (Input is null) throw new ArgumentNullException();

        // Corner

        if (PAIRS > Input.Length) throw new InvalidDataException();

    }

    public void Naive(){
        
        Cases();

        int max = 0, temp = 0;

        for (int i = 0; i < (Input!.Length - PAIRS + 1); i++) {

            temp = 0;

            for (int j = 0; j < PAIRS; j++)
                temp += Input![i + j];

            if (temp > max)
                max = temp;

        }

        Output = max;
        Done = true;

    }

    public void Proper(){

        Cases();

        int max = 0, temp = 0;

        for (int i = 0; i < PAIRS; i++)
            max += Input![i];
        temp = max;

        for (int i = PAIRS; i < Input!.Length; i++) {
            temp = temp - Input![i - PAIRS] + Input![i];
            max = Math.Max(max, temp);
        }

        Output = max;
        Done = true;

    }

}
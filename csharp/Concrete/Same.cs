namespace Udemy;

public class Same : IProblem<IList<int[]?>, bool?>{

    public IList<int[]?>? Input { get; init; }
    public string? Problem { get; init; }

    public bool? Output { get; set; }
    public bool Done { get; set; }

    public Same(){
        Done = false;
        Output = null;
        Input = new List<int[]?>();
        Problem = "Given two arrays find a matching pair where one is a square of other.";
    }

    public void ValidData() {
        Input!.Add(new[] { 1, 2, 3, 2 });
        Input!.Add(new[] { 9, 1, 4, 4 });
    }

    public void InvalidData() {
        Input!.Add(new[] { 1, 2, 3, 4, 5 });
        Input!.Add(new[] { 100, 200, 300, 400, 500 });
    }

    private void Cases(){

        // Edge
        if(Input is null) throw new ArgumentNullException();
        if(Input.Count == 0) throw new InvalidDataException();

        // Corner
        if (Input![0] is null || Input![1] is null) throw new ArgumentNullException();
        if (Input![0]!.Length != Input![1]!.Length) throw new ArgumentException();

    }

    public void Naive() {

        Cases();

        var arr1 = Input![0]!.ToList();
        var arr2 = Input![1]!.ToList();
        int idx  = -1;

        for (int i = 0; i < arr1.Count; i++) {

            idx = Array.FindIndex(
                arr2.ToArray(),
                r => r == ((int)Math.Pow(arr1[i], 2))
            );
            
            if (idx == -1) {
                Output = false;
                Done = true;
                return;
            }

            arr2.RemoveAt(idx);

        }

        Output = true;
        Done = true;

    }

    public void Proper(){

        Cases();

        Dictionary<int, int> fre1 = new();
        Dictionary<int, int> fre2 = new();

        var arr1 = Input![0]!.ToList();
        var arr2 = Input![1]!.ToList();

        int tmp = 0;

        foreach (var item in arr1) {
            if(!fre1.ContainsKey(item))
                fre1.Add(item, fre1.GetValueOrDefault(item) + 1);
        }

        foreach (var item in arr2){
            if (!fre2.ContainsKey(item))
                fre2.Add(item, fre2.GetValueOrDefault(item) + 1);
        }

        foreach(var item in fre1){

            tmp = (int)Math.Pow(item.Value, 2);

            if (!fre2.ContainsKey(tmp)){
                Output = false;
                Done = true;
                return;
            }

            if (fre1[tmp] != fre2[tmp]) {
                Output = false;
                Done = true;
                return;
            }

        }

        Output = true;
        Done = true;
    }

}
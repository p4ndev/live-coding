namespace Udemy;

public class Anagram : IProblem<IList<string>, bool?>{

    public IList<string>? Input { get; init; }
    public string? Problem { get; init; }

    public bool? Output { get; set; }
    public bool Done { get; set; }

    private Dictionary<char, int> _lookup;

    public Anagram(){

        _lookup = new();
        Done = false;
        Output = null;
        Input = new List<string>();
        Problem = "Given two strings check if both are anagrams.";

        Input.Add("anagrams");
        Input.Add("nagaramm");

    }

    private void Cases() {

        // Edge
        if (Input is null) throw new ArgumentNullException();

        // Corner
        if (Input.Count < 2) throw new ArgumentException();

        if (Input![0].Length != Input![1].Length) throw new InvalidDataException();

    }

    public void Naive() => throw new NotImplementedException();

    public void Proper(){

        Cases();

        var first = Input![0];
        var second = Input![1];
        char letter;

        for (int i = 0; i < first.Length; i++) {
            letter = first[i];

            if (_lookup.ContainsKey(letter))
                _lookup[letter]++;
            else
                _lookup[letter] = 1;

        }

        for (int i = 0; i < second.Length; i++) {

            letter = second[i];

            if (!_lookup.ContainsKey(letter)){
                Done = true;
                Output = false;
                return;
            } else
                _lookup[letter]--;

        }

        Done = true;
        Output = true;

    }

}
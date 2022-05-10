
FrequencyCounterInStringArray(new[] { "a", "ab", "abc" }, new[] { "ab", "abc", "abcd" });

static IDictionary<char, int> FrequencyCounterInStringArray(string[] array1, string[] array2) {

    IDictionary<char, int> res = new Dictionary<char, int>();

    array1.Concat(array2).ToList().ForEach(all => {
        foreach(var letter in all.ToCharArray()){
            if(res.ContainsKey(letter))   res[letter]++;
            else                          res.Add(letter, 1);
        }
    });

    foreach(var item in res)
        Console.WriteLine("Item {0} count {1}", item.Key, item.Value);

    return res;

}

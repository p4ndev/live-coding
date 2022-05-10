namespace Globant.GoDaddy.v1;
public static class LastUniqueFromIntArray{
    public static int Find(int[] input) {
        
        Dictionary<int, int> dict = new();

        foreach (var item in input) { 
            if(dict.ContainsKey(item))
                dict[item]++;
            else
                dict.Add(item, 1);
        }

        return dict.LastOrDefault(x => x.Value == 1).Key;

    }
}

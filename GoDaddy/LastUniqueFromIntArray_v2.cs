namespace Globant.GoDaddy.v2;
public static class LastUniqueFromIntArray{
    public static int Find(int[] input) {
        
        Dictionary<int, int> dict = new();

        foreach (var item in input) {
            if (dict.ContainsKey(item))
                dict.Remove(item);
            else
                dict.Add(item, 1);
        }

        return dict.FirstOrDefault().Key;

    }
}

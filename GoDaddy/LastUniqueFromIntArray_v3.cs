namespace Globant.GoDaddy.v3;
public static class LastUniqueFromIntArray{
    public static int Find(int[] input) =>
        input.LastOrDefault(
            x => (
                input.Count(y => y == x) == 1
            )
        );
}

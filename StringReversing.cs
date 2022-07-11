public static class StringReversing {

    public static void Statement() {
        Console.WriteLine("You are given a string s - you need to reverse the string.");
        Console.WriteLine("\nExample 1:\nInput: Geeks \t\t Output: skeeG\n");
        Console.WriteLine("Example 2:\nInput: for \t\t Output: rof\n");
    }

    public static string True_A() => Solution_Linear("Geeks");

    public static string True_B() => Solution_Swap("for");

    public static string Solution_Linear(string s) {

        string r = "";

        for (int i = s.Length - 1; i >= 0; i--)
            r += s[i];

        return r;

    }

    public static string Solution_Swap(string s) {

        char[] c = s.ToCharArray();
        int j = c.Length - 1;
        int i = 0;
        char a;

        while (i < j) {

            a = c[i];

            c[i] = c[j];
            c[j] = a;

            i++;
            j--;

        }

        s = new string(c);

        return s;

    }

}
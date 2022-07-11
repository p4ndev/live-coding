public static class StringPalindrome{

    public static void Statement() {

        Console.WriteLine("Given a string S, check if it is palindrome or not.\n");
        Console.WriteLine("Example 1:\nInput: S = `abba`\t\tOutput: 1\nExplanation: S is a palindrome\n");
        Console.WriteLine("Example 2:\nInput: S = `abc`\t\tOutput: 0\nExplanation: S is not a palindrome");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nPalindrome: palavra, grupo de palavras,\nverso ou número que se lê da mesma maneira\nde ambos os lados.\n");
        Console.ForegroundColor = ConsoleColor.White;

    }

    public static bool True() => Solution("abba");

    public static bool Falsy() => Solution("abc");

    public static bool Solution(string s) {

        if (s == null || s.Length == 0) return false;

        int i = 0;
        int j = s.Length - 1;

        while (i <= j) {
            if (s[i] != s[j]) return false;
            i++;
            j--;
        }

        return true;

    }

}
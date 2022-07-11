public static class StringAnagram {

    public static void Statement() {

        Console.WriteLine("Example 1:\nInput:\t\ta = geeksforgeeks\t\tb = forgeeksgeeks\nOutput: YES\nExplanation: Both the string have same characters with same frequency.\nSo, both are anagrams.");

        Console.WriteLine("\nExample 2:\nInput:\t\ta = allergy\t\t\tb = allergic\nOutput: NO\nExplanation: Characters in both the strings are not same.\nSo they are not anagram");

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\nAnagrama: uma palavra ou frase é construída através apenas\nda alteração da ordem das letras\nda outra.\n");
        Console.ForegroundColor = ConsoleColor.White;

    }

    public static bool True() => Solution("gustavo", "usaotvg");

    public static bool Falsy() => Solution("geeksforgeeks", "geeksgeeks");

    public static bool Solution(string a, string b){

        if (a.Length != b.Length) return false;

        int x = 0, y = 0;

        for (int i = 0; i < a.Length; i++) {
            x += a[i];
            y += b[i];
        }
        
        return (x == y);

    }

}
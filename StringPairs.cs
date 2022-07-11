public static class StringPairs {

    public static void Statement() {
        Console.WriteLine("Given an expression string. Examine whether the pairs and the orders of “{“,”}”,”(“,”)”,”[“,”]” are correct in exp.");
        Console.WriteLine("\nFor example, the function should return 'true' for exp = “[()]{}{[()()]()}” and 'false' for exp = “[(])”.\n");
    }

    public static bool True() => Solution("[()]{}{[()()]()}");

    public static bool Falsy() => Solution("[(])");

    public static bool Solution(string x) {

        char c;
        Stack<char> s = new();

        for (int i = 0; i < x.Length; i++) {

            c = x[i];

            switch (c) {

                #region Adding left possibilities to a stack
                case '{':
                    s.Push('}');
                    break;

                case '[':
                    s.Push(']');
                    break;

                case '(':
                    s.Push(')');
                    break;
                #endregion

                #region Right possibilities by respecting the order
                default:
                    if (s.Count <= 0 || s.Pop() != c)
                        return false;
                    break;
                    #endregion

            }

        }

        // Once no element, each letter is a par accordingly
        return s.Count <= 0;

    }

}
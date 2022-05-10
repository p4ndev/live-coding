
using System.Text;

Console.WriteLine("{0} sent and is: {1}", "{}",     Solution.IsValid2("{}")     );
Console.WriteLine("{0} sent and is: {1}", "()[]{}", Solution.IsValid2("()[]{}") );
Console.WriteLine("{0} sent and is: {1}", "([)]",   Solution.IsValid2("([)]")   );
Console.WriteLine("{0} sent and is: {1}", "{[]}",   Solution.IsValid2("{[]}")   );

public static class Solution{

    // 30 minutes: done
    public static bool IsValid2(string s){
        
        if(String.IsNullOrEmpty(s) || (s.Length % 2 != 0)) return false;

        Dictionary<char, char> dict = new();
        char currentLetter, opositeLetter;
        char nexPos, endPos;

        dict.Add('(',')');
        dict.Add('{','}');
        dict.Add('[',']');

        for(int i = 0, l = 0; (i+l) < s.Length; i++){

            currentLetter = s[i];
            opositeLetter = dict[currentLetter];
            
            nexPos        = s[i + 1];
            endPos        = s[(s.Length - 1) - i];

            if     (opositeLetter == nexPos)    i++;
            else if(opositeLetter == endPos)    l++;
            else if(opositeLetter != endPos)    return false;

        }

        return true;

    }
    
    // 15 Minutes: wrong
    public static bool IsValid(string s){

        if(String.IsNullOrEmpty(s) || (s.Length % 2 != 0))
            return false;
        
        Dictionary<char, char> dict = new();
        dict.Add('(', ')');
        dict.Add('{', '}');
        dict.Add('[', ']');

        string left = s.Substring(0, s.Length/2);
        StringBuilder sb = new StringBuilder();

        for(int i = left.Length; i > 0; i--){
            if(dict.ContainsKey(left[i-1]))
                sb.Append(dict[left[i-1]]);
            else
                return false;
        }

        string right = s.Substring(s.Length/2);

        return sb.Equals(right);

    }

}

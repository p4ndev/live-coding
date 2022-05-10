using System;
using System.Linq;
using System.Collections.Generic;

public class Challenge
{
    public static string[] Possibilities(string signals)
    {
      var idx = 0;
      var res = new List<string>();
 
      var alp = new[]{ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", ",", ".", "?", "ET", "IA", "RWGO", "IN" };
      
      var cod = new List<string>{ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..",".---", "-.-", ".-..", "--", "-.", "---", ".---.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----", "--..--", ".-.-.-", "..--..", "?", ".?", "?-?", "?." };
      
      if(String.IsNullOrEmpty(signals) && signals.Length > 3)
        return res.ToArray();
      
      do{
        foreach(var item in cod.OrderByDescending(c => c.Length)){
          idx = cod.FindIndex(c => c == item);
          signals = signals.Replace(item, alp[idx]);
        }
      }while(signals.IndexOf(".") != -1 || signals.IndexOf("-") != -1 || signals.IndexOf("?") != -1);
      
      for(int i = 0; i < signals.Length; i++)
        res.Add(signals[i].ToString());

      return res.ToArray();
      
    }
}
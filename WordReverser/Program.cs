using System;
using System.Linq;

public static class Kata
{
    public static string ReverseWords(string str)
    {
        // Grabs the individual words
        var words = str.Split(' ');

        // FOR EACH non-empty word,
        foreach (var w in words.Where(x => x != String.Empty))
        {
            // Reverse and replace the word in the string.
            str = str.Replace(w, new string(w.ToCharArray().Reverse().ToArray()));
        }

        return str;
    }    
}
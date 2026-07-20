namespace cSharp_withMrMike.String;

// Given 2 strings, return their concatenation, except omit the first char of each. 
// The strings will be at least length 1.

// Examples

// nonStart('Hello', 'There') → ellohere
// nonStart('java', 'code') → avaode
// nonStart('shotl', 'java') → hotlava

public class NonStart
{
    public static string nonStart(string word1, string word2)
    {
        string newWord = "";
        for(int i=1; i<word1.Length; i++)
        {
            newWord += word1[i];
        }

        for(int i=1; i<word2.Length; i++)
        {
            newWord += word2[i];
        }

        return newWord;
    }
}
namespace cSharp_withMrMike.String;

// Given a string of even length, return a string made of the middle two chars, so the 
// string "string" yields "ri". The string length will be at least 2.

// Examples

// middleTwo('string') →
// middleTwo('code') →
// middleTwo('Practice') →

public class Middletwo
{
    public static string middleTwo(string word)
    {
        string middleWord =  " ";
        for(int i=0; i<word.Length; i++)
        {
            if(i == word.Length/2-1 || i == (word.Length/2-1) +1)
            {
                middleWord += word[i];
            }
        }

        return middleWord;
    }
}
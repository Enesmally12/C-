namespace cSharp_withMrMike.String;

// Given a string, return a new string made of 3 copies of the last 2 chars of the original string.
//  The string length will be at least 2.

// Examples

// extraEnd('Hello') → lololo
// extraEnd('ab') → ababab
// extraEnd('Hi') → HiHiHi

public class ExtraEnd
{
    public static string extraEnd(string word)
    {
        int i=0;
        string newString = " ";
        while( i<=3)
        {
            for(int j=0; j<word.Length; j++)
            {
                if(j == word.Length-2 || j == word.Length-1)
                {
                    newString +=word[j];
                }
            }

            i++;
        }

        return newString;
    }
}
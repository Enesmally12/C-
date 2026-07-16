namespace cSharp_withMrMike.String;

// Given a string and an index, return a string length 2 starting at the given index.
//  If the index is too big or too small to define a string length 2, use the first 2 chars.
//  The string length will be at least 2.

// Examples

// twoChar('java', 0) → ja
// twoChar('java', 2) → va
// twoChar('java', 3) → ja

public class TwoChar
{
    public static string twoC(string word,int i)
    {
        string newString = " ";

        if(i> word.Length-2)
        {
            i=0;
        }
        
        for(int j=i; j < i+2; j++)
        {
            newString +=word[j];
        }

        return newString;
    }
}
namespace cSharp_withMrMike.String;

// Given a string, return a new string made of 3 copies of the first 2 chars of the original string. 
// The string may be any length. If there are fewer than 2 chars, use whatever is there.

// Examples

// extraFront('Hello') → HeHeHe
// extraFront('ab') → ababab
// extraFront('H') → HHH

public class ExtraFront
{
    public static string extraF(string word)
    {
        string newString = " ";
        if(word.Length<2)
        {
            return word;
        }

        int j=0;

        while( j<3)
        {
            if(word.Length>2)
            {
                for(int i = 0; i<2; i++)
                {
                    newString += word[i];
                }
            }
            j++;
        }

        return newString;
    }
}
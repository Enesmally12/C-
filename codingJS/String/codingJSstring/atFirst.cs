namespace cSharp_withMrMike.String;

// Given a string, return a string length 2 made of its first 2 chars. 
// If the string length is less than 2, use '@' for the missing chars.

// Examples

// atFirst('hello') → he
// atFirst('hi') → hi
// atFirst('h') → h@

public class AtFirst
{
    public static string atFirst(string word)
    {
        string newString = " ";
        if(word.Length < 2)
        {
            newString = word+"@";
        }
        else if(word.Length >= 2)
        {
            for(int i= 0; i< 2; i++)
            {
                newString += word[i];
            }
        }

        return newString;
    }
}
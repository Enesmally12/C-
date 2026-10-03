namespace cSharp_withMrMike.String;

// Given a string, if the first or last chars are 'x', return the string without those 'x' chars, and otherwise return the string unchanged.

// Examples

// withoutX('xHix') → Hi
// withoutX('xHi') → Hi
// withoutX('Hxix') → Hxi

public class WithoutX
{
    public static string withoutX(string word)
    {
        string newWord = "";

        if(word[0] == 'x' || word[^1] == 'x')
        {
            for(int i=1; i<word.Length-2; i++)
            {
                newWord += word;
            }
        }
        else
        {
            newWord += word;
        }

        return newWord;
    }
}
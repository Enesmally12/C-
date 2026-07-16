namespace cSharp_withMrMike.String;

// Given a string, return a version without the first and last char, so "Hello" yields "ell".
//  The string length will be at least 2.

// Examples

// withoutEnd('Hello') → ell
// withoutEnd('java') → av
// withoutEnd('coding') → odin

public class WithOUT
{
    public static string withou(string word)
    {
        string newWord = "";

        for(int i=1; i<word.Length-1; i++)
        {
            newWord += word[i];
        }

        return newWord;
    }
}
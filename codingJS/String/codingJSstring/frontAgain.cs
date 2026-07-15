namespace cSharp_withMrMike.String;

// Given a string, return true if the first 2 chars in the string also appear at the end of the string, such as with "edited".

// Examples

// frontAgain('edited') → true
// frontAgain('edit') → false
// frontAgain('ed') → true

public class FrontAgain
{
    public static bool frontA(string word)
    {
        bool isResult = false;

        if(word[0] == word[word.Length-2] && word[1] == word[word.Length-1])
        {
            isResult = true;
        }
        else
        {
            isResult = false;
        }
        
        return isResult;
    }
}
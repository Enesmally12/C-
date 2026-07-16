namespace cSharp_withMrMike.String;

// Given a string of odd length, return the string length 3 from its middle, so "Candy" yields "and".
//  The string length will be at least 3.

// Examples

// middleThree('Candy') → and
// middleThree('and') → and
// middleThree('solving') → lvi

public class MiddleThree
{
    public static string middleT(string word)
    {
        string newWord = " ";
        if(word.Length <=3)
        {
            newWord = word;
        }

        int start = word.Length/2-1;

        for(int i= start ; i<start+3; i++)
        {
            newWord += word[i];
        }

        return newWord;
    }
}


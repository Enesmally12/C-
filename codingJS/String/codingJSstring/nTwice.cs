namespace cSharp_withMrMike.String;

// Given a string and an int n, return a string made of the first and last n chars from the string. 
// The string length will be at least n.

// Examples

// nTwice('hello', 2) → helo
// nTwice('Chocolate', 3) → Choate
// nTwice('Chocolate', 1) → Ce

public class Ntwice
{
    public static string ntwice(string word, int num)
    {
        string newString = "";
        string frontL = "";
        string backL = "";

        for(int i =0; i<num; i++)
        {
            frontL += word[i];
        }

        for(int i= word.Length-num; i<word.Length ; i++)
        {
            backL += word[i];
        }

        newString = frontL+backL;
        return newString;
    }
}
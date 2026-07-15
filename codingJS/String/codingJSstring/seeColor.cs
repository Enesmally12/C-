namespace cSharp_withMrMike.seeColor;

// Given a string, if the string begins with "red" or "blue" return that color string, otherwise return the empty string.

// Examples

// seeColor('redxx') → red
// seeColor('xxred') →
// seeColor('blueTimes') → blue

public class SeeColor
{
    public static string color(string word)
    {
        string color = " ";

        if(word.StartsWith("red"))
        {
            color = "red";
        }
        
        if(word.StartsWith("blue"))
        {
            color = "blue";
        }
        

        return color;
    }
}
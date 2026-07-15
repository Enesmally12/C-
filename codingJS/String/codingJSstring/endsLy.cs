namespace cSharp_withMrMike.String;

// Given a string, return true if it ends in "ly".

// Examples

// endsLy('oddly') → true
// endsLy('y') → false
// endsLy('oddl') → false

public class EndLy
{
    public static bool endLy(string word)
    {
        bool isResult = false;
        if(word.EndsWith("ly"))
        {
            isResult = true;
        }
        else
        {
            isResult =  false;
        }

        return isResult;
    }
}
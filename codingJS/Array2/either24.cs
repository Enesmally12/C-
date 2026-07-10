using System.IO.Pipelines;

namespace cSharp_withMrMike.either24;

// Given an array of ints, return true if the array contains a 2 next to a 2 or a 4 next to a 4, but not both.

// Examples

// either24([1, 2, 2]) → true
// either24([4, 4, 1]) → true
// either24([4, 4, 1, 2, 2]) → false

public class Either24
{
    public static bool either2(int[] no)
    {
        bool is22 = false;
        bool is44 = false;
        bool result = false;

        for(int i=0; i< no.Length-1; i++)
        {
            if(no[i] == 2 && no[i+1] == 2)
            {
                is22 = true;
            }

            if(no[i] == 4 && no[i+1] == 4)
            {
                is44 = true;
            }
            
            
            if(is22 != is44)
            {
                result = true; 
            }
        }

        return result;
        
    }
}
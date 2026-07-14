namespace cSharp_withMrMike.post4;

// Given a non-empty array of ints, return a new array containing the elements from the original 
// array that come after the last 4 in the original array. The original array will contain at least one 4. 
// Note that it is valid in java to create an array of length 0.

// Examples

// post4([2, 4, 1, 2]) → 1,2
// post4([4, 1, 4, 2]) → 2
// post4([4, 4, 1, 2, 3]) → 1,2,3

public class Post4
{
    public static int[]  postIT(int[] no)
    {
        int count = 0;

        for(int i =0; i<no.Length; i++)
        {
            if(no[i] == 4)
            {
                count = i;
            }
        }

        int[] newArray = new int[no.Length-count];

        Array.Clear(no, 0, count);
        
        for(int i=0; i<newArray.Length ; i++)
        {
            if(no[i] > 0)
            {
                newArray[i] = no[i];
            }
        }

        return newArray;
        
    }
}
namespace cSharp_withMrMike.sum13;

// Return the sum of the numbers in the array, returning 0 for an empty array. 
// Except the number 13 is very unlucky, so it does not count and numbers that
//  come immediately after a 13 also do not count.

// Examples

// sum13([1, 2, 2, 1]) → 6
// sum13([1, 1]) → 2
// sum13([1, 2, 2, 1, 13]) → 6

public class Sum13
{
    public static int sum1(int[] no)
    {
        int count = 0;
        int sum = 0;

        for(int i=0; i< no.Length; i++)
        {
            if(no[i] == 13)
            {
                count = i;
            }
        }

        int[] newArray = new int[count];

        for(int i=0; i<count; i++)
        {
            newArray[i] = no[i];
        }

        for(int i=0; i< newArray.Length; i++)
        {
            sum += newArray[i];
        }

        return sum;
    }
}
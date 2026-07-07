namespace cSharp_withMrMike.countEvents;
// Return the number of even ints in the given array. Note: the % "mod" 
// operator computes the remainder, e.g. 5 % 2 is 1.

// Examples

// countEvens([2, 1, 2, 3, 4]) → 3
// countEvens([2, 2, 0]) → 3
// countEvens([1, 3, 5]) → 0

public class countEvents
{
    public static int countE(int[] no)
    {
        int count=0;

        foreach(int num in no)
        {
            if(num % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }
}
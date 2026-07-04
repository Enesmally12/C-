namespace cSharp_withMrMike.findLowestIndex;


// Return the index of the minimum value in an array. 
// The input array will have at least one element in it.

// Examples

// findLowestIndex([99, 98, 97, 96, 95]) → 4
// findLowestIndex([2, 2, 0]) → 2
// findLowestIndex([1, 3, 5]) → 0

public class FindLowestIndex
{
    public static int findLowest(int[] no)
    {
        int lowest = no[0];
        
        for(int i=0; i<no.Length; i++)
        {
            if(lowest > no[i])
            {
               lowest = no[i];
            }
        }

        return Array.IndexOf(no, lowest);
    }
}
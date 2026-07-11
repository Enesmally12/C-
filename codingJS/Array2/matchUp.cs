namespace cSharp_withMrMike.matchUp;

// Given arrays nums1 and nums2 of the same length, for every element in nums1, consider the corresponding 
// element in nums2 (at the same index). Return the count of the number of times that the two elements
//  differ by 2 or less, but are not equal.

// Examples

// matchUp([1, 2, 3], [2, 3, 10]) → 0
// matchUp([1, 2, 3], [2, 3, 5]) → 0
// matchUp([1, 2, 3], [2, 3, 3]) → 0

public class MatchUp
{
    public static int matchUp(int[] num1, int[] num2)
    {
        int count = 0;
        for(int i=0; i<num1.Length; i++)
        {
             if(Math.Abs(num1[i] - num2[i] ) <= 2 && num1[i] != num2[i])
            {
                count++;
            }
        }


        return count;
    }
}
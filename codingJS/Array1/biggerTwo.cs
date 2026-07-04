namespace cSharp_withMrMike.biggerTwo;

// Start with 2 int arrays, a and b, each length 2. Consider the sum of the values in each array. 
// Return the array which has the largest sum. In event of a tie, return a.

// Examples

// biggerTwo([1, 2], [3, 4]) → 3,4
// biggerTwo([3, 4], [1, 2]) → 3,4
// biggerTwo([1, 1], [1, 2]) → 1,2

public class BiggerTwo
{
    public static int[] biggerT(int [] num1, int[] num2)
    {
        int[] sumIt = new int[2];
        
        if(num1[0]+num1[1] > num2[0]+num2[1])
        {
            sumIt = num1;
        }
        else if(num2[0]+num2[1] > num1[0]+num1[1])
        {
            sumIt = num2;
        }
        else
        {
            sumIt = num1;
        }

        return sumIt;
    }
}
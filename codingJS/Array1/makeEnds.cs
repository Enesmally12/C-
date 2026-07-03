// namespace cSharp_withMrMike.makeEnds;

// // Given an array of ints, return a new array length 2 containing the 
// // first and last elements from the original array. 
// // The original array will be length 1 or more.

// // Examples

// // makeEnds([1, 2, 3]) → 1,3
// // makeEnds([1, 2, 3, 4]) → 1,4
// // makeEnds([7, 4, 6, 2]) → 7,2

// public class MakeEnds
// {
//     public static int[] makeE(int[] num)
//     {

//         int[] result = new int[2]; 

//         if(num.Length > 2)
//         {
//             result[0] = num[0];
//             result[1] = num[num.Length-1];
//         }

//         return result;
//     }


// }
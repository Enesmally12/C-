// namespace cSharp_withMrMike.makeMiddle;

// // Given an array of ints of even length, return a new array length 2 containing 
// // the middle two elements from the original array. 
// // The original array will be length 2 or more.

// // Examples

// // makeMiddle([1, 2, 3, 4]) → 2,3
// // makeMiddle([7, 1, 2, 3, 4, 9]) → 2,3
// // makeMiddle([1, 2]) → 1,2

// public class MakeMiddle
// {
//     public static int[] makeM(int[] num)
//     {
//         int [] newArray = new int[2];
//         if(num.Length > 2)
//         {
//             newArray[0] = num[(num.Length/2)-1];
//             newArray[1] = num[num.Length/2];
//         }
//         else
//         {
//             Array.Copy(num, newArray, num.Length);
//         }

//         return newArray;
//     }

// }

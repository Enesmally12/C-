// namespace cSharp_withMrMike.unlucky1;

// // We'll say that a 1 immediately followed by a 3 in an array is an "unlucky" 1. 
// // Return true if the given array contains an unlucky 1 in the first 2 or last 2 positions in the array.

// // Examples

// // unlucky1([1, 3, 4, 5]) → true
// // unlucky1([2, 1, 3, 4, 5]) → true
// // unlucky1([1, 1, 1]) → false

// public class Unlucky
// {
//     public static bool unlucky1(int[] no)
//     {
//         bool result;
//         if(no[0] == 1 && no[1] == 3 || no[1] == 1 && no[2] == 3)
//         {
//             result = true;
//         }
//         else if(no[no.Length-2] == 1 && no[no.Length-1] == 3)
//         {
//             result = true;
//         }
//         else
//         {
//             result = false;
//         }
//         return result;
//     }
// }
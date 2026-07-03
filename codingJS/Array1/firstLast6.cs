// namespace cSharp_withMrMike.firstLast6;
// // firstLast6
// // Given an array of ints, return true if 6 appears as either the first or last element in the array. 
// // The array will be length 1 or more.

// // Examples

// // firstLast6([1, 2, 6]) → true
// // firstLast6([6, 1, 2, 3]) → true
// // firstLast6([13, 6, 1, 2, 3]) → false

// public class FirstLast6
// {
//     public static bool first6(int[] num)
//     {
//         bool result;

//         if(num[0] == 6 || num[num.Length-1] == 6)
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
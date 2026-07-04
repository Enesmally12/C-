// namespace cSharp_withMrMike.front11;
// // Given 2 int arrays, a and b, of any length, return a new array with the 
// // first element of each array. If either array is length 0, ignore that array.

// // Examples

// // front11([1, 2, 3], [7, 9, 8]) → 1,7
// // front11([1], [2]) → 1,2
// // front11([1, 7], []) → 1

// public class Front11
// {
//     public static int[] front1(int[] num1, int[] num2)
//     {
//         int[] newArray = new int[2];

//         if(num1.Length > 0 && num2.Length > 0)
//         {
//             newArray[0] = num1[0];
//             newArray[1] = num2[0];
//         }
//         else if(num1.Length <= 0)
//         {
//             newArray[0] = num2[0];
//         }
//         else if(num2.Length <= 0)
//         {
//             newArray[0] = num1[0];
//         }

//         return newArray;

//     }
// }
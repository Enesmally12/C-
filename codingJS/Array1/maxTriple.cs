// namespace cSharp_withMrMike.maxTriple;

// // Given an array of ints of odd length, look at the first, last, and 
// // middle values in the array and return the largest. 
// // The array length will be a least 1.

// // Examples

// // maxTriple([1, 2, 3]) → 3
// // maxTriple([1, 5, 3]) → 5
// // maxTriple([5, 2, 3]) → 5

// public class maxTriple
// {
//     public static int maxT(int[] num)
//     {
//         int maxNo=0;

//         maxNo = num[0];

//         for(int i=0; i<num.Length;i++)
//         {

//             if(num[i] > maxNo)
//             {
//                 maxNo = num[i];
//             }
//         }
//         return maxNo;
//     }
// }
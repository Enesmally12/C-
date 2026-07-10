// namespace cSharp_withMrMike.bigDiff;

// // Given an array length 1 or more of ints, return the difference between the largest and 
// // smallest values in the array. Note: the built-in Math.min(v1, v2) and Math.max(v1, v2) methods 
// // return the smaller or larger of two values.

// // Examples

// // bigDiff([10, 3, 5, 6]) → 7
// // bigDiff([7, 2, 10, 9]) → 8
// // bigDiff([2, 10, 7, 2]) → 8

// public class BigDiff
// {
//     public static int bigD(int[] no)
//     {
//         int MaxNo = no[0];
//         int MinNo = no[0];

//         for(int i= 0; i < no.Length; i++)
//         {
//             if(no[i] > MaxNo)
//             {
//                 MaxNo = no[i];
//             }

//             if(no[i] < MinNo)
//             {
//                 MinNo = no[i];
//             }
//         }

//         return MaxNo - MinNo;
//     }
// }
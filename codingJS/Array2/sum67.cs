// namespace cSharp_withMrMike.sum67;

// // Return the sum of the numbers in the array, except ignore sections of 
// // numbers starting with a 6 and extending to the next 7 
// // (every 6 will be followed by at least one 7). Return 0 for no numbers.

// // Examples

// // sum67([1, 2, 2]) → 5
// // sum67([1, 2, 2, 6, 99, 99, 7]) → 5
// // sum67([1, 1, 6, 7, 2]) → 4

// public class sum67
// {
//     public static int sumSix(int[] no)
//     {
//         int startIndex = 0;
//         int endIndex  =0;
//         int sum=0;
//         int minus = 0;

//         for(int i=0; i< no.Length; i++)
//         {
//             sum += no[i];

//             if(no[i] == 6)
//             {
//                 startIndex = i;
//             }

//             if(no[i] == 7)
//             {
//                 endIndex = i;
//             }

//             if(i >= startIndex && i <= endIndex)
//             {
//                 minus+= no[i];
//             }

//         }
        
//         sum = sum - minus;

//         return sum;
//     }
// }
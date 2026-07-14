// namespace cSharp_withMrMike.has77;

// // Given an array of ints, return true if the array contains two 7's next to each other, 
// // or there are two 7's separated by one element, such as with {7, 1, 7}.

// // Examples

// // has77([1, 7, 7]) → true
// // has77([1, 7, 1, 7]) → true
// // has77([1, 7, 1, 1, 7]) → false

// public class Has77
// {
//     public static bool has7(int[] no)
//     {
//         bool result  = false;
//          for(int i=0; i<no.Length; i++)
//         {
//             if(no[i] == 7 && no[i+1] == 7)
//             {
//                 result = true;
//             }
//             else
//             {
//                 result = false;
//             }
//         } 
   
//         return result; 
//     }
// }
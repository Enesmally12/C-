// namespace cSharp_withMrMike.fix23;
// // Given an int array length 3, if there is a 2 in the array immediately followed by a 3,
// // set the 3 element to 0. Return the changed array.

// // Examples

// // fix23([1, 2, 3]) → 1,2,0
// // fix23([2, 3, 5]) → 2,0,5
// // fix23([1, 2, 1]) → 1,2,1

// public class fix23
// {
//     public static int[] fix2(int[] no)
//     {
//         for(int i=0; i < no.Length; i++)
//         {
//             if(no[i] == 2 && no[i+1] == 3)
//             {
//                 no[i+1] = 0;
//             }
//         }

//         return no;
//     }
// }
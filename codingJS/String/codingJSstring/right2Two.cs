// namespace cSharp_withMrMike.String;

// // Given a string, return a "rotated right 2" version where the last 2 chars are moved to the start.
// //  The string length will be at least 2.

// // Examples

// // right2('Hello') → loHel
// // right2('java') → vaja
// // right2('Hi') → Hi

// public class RightTwo
// {
//     public static string rightTwo(string word)
//     {
//         string rev = "";

//         if(word.Length<=2)
//         {
//             return word;
//         }
//         else
//         {
//             for(int i=word.Length-2; i>=0; i++)
//             {
//                 rev += word[i];
//             }
//         }

//         return rev;
//     }
// }
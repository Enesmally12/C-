// namespace cSharp_withMrMike.String;

// // Given a string, return a string length 1 from its front, unless front is false,
// //  in which case return a string length 1 from its back. The string will be non-empty.

// // Examples

// // theEnd('Hello', true) → H
// // theEnd('Hello', false) → o
// // theEnd('oh', true) → o

// public class TheEnd
// {
//     public static char Endwith(string word1, bool check)
//     {
//         char result = ' ';
//         if(check == true)
//         {
//             result = word1[0];
//         }
        
//         if(check == false)
//         {
//             result = word1[^1];
//         }

//         return result;
//     }
// }
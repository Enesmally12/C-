// namespace cSharp_withMrMike.String;

// // Given a string, return the string made of its first two chars, so the String "Hello" yields "He".
// //  If the string is shorter than length 2, return whatever there is, so "X" yields "X", and the empty string "" yields
// //  the empty string "". Note that str.length() returns the length of a string.

// // Examples

// // firstTwo('Hello') → He
// // firstTwo('abcdefg') → ab
// // firstTwo('ab') → ab

// public class FirstTwo
// {
//     public static string firstTwo(string word)
//     {
//         string newString = " ";

//         if(word.Length < 2)
//         {
//             newString = word;
//         }
//         else if(word.Length >2)
//         {
//             for(int i=0; i< 2; i++)
//             {
//                 newString +=word[i];
//             }
//         }

//         return newString;
//     }
// }


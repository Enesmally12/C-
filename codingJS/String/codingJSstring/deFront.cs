// namespace cSharp_withMrMike.String;

// // Given a string, return a version without the first 2 chars. 
// // Except keep the first char if it is 'a' and keep the second char if it is 'b'. 
// // The string may be any length. Harder than it looks.

// // Examples

// // deFront('Hello') → llo
// // deFront('java') → va
// // deFront('away') → aay

// public class DeFront
// {
//     public static string deFront(string word)
//     {
//         string newString = " ";

//         if(word[0] != 'a' && word[1] != 'b')
//         {
//             for(int i =2; i<word.Length; i++)
//             {
//                 newString += word[i];
//             }
//         }
//         else if(word[0] == 'a')
//         {
//             newString += word[0];

//             for(int i=2 ; i<word.Length; i++)
//             {
//                 newString += word[i];
//             }
//         }
//         else if(word[1] == 'b')
//         {
//             newString += word[1];

//             for(int i=2 ; i<word.Length; i++)
//             {
//                 newString += word[i];
//             }
//         }
//         return newString;
//     }
// }

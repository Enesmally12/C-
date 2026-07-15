// namespace cSharp_withMrMike.String;

// // Given a string, return a version without both the first and last char of the string. The string may be any length, including 0.

// // Examples

// // withoutEnd2('Hello') → ell
// // withoutEnd2('abc') → b
// // withoutEnd2('ab') →

// public class WithOutend
// {
//     public static string withOut(string word)
//     {
//         string newWord = "";
//         for(int i=0; i< word.Length; i++)
//         {
//             if(i != 0 && i != word.Length-1)
//             {
//                 newWord += word[i];
//             }
//         }

//         return newWord;
//     }
// }
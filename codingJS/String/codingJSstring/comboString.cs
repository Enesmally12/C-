// namespace cSharp_withMrMike.String;

// // Given 2 strings, a and b, return a string of the form short+long+short, with the shorter 
// // string on the outside and the longer string on the inside. The strings will not be the same 
// // length, but they may be empty (length 0).

// // Examples

// // comboString('Hello', 'hi') → hiHellohi
// // comboString('Hi', 'Hello') → HiHelloHi
// // comboString('aaa', 'b') → baaab

// public class ComboS
// {
//     public static string comboS(string word1, string word2)
//     {
//         string newWord = "";

//         if(word1.Length < word2.Length)
//         {
//             newWord += word1+word2+word1;
//         }
//         else if(word2.Length < word1.Length)
//         {
//             newWord += word2+word1+word2;
//         }

//         return newWord;
//     }
// }
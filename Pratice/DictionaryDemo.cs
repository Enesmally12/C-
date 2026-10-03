// using System.Collections.Immutable;

// namespace cSharp_withMrMike.String;

// public class DictionaryDemo
// {
// // //     public static Dictionary<char , int> CharChecker(string text)
// // //     {
// // //         Dictionary<char, int> freq = new();

// // //         foreach(char c in text)
// // //         {
// // //             if(freq.ContainsKey(c))
// // //             {
// // //                freq = c++;
// // //             }
// // //             else
// // //             {
// // //                 c= 0;
// // //             }
// // //         }
// // //     }
// // // }

// // public static char? first1(string text)
// // {
// //     Dictionary<char, int> freq = new();

// //     foreach(char ch in text)
// //     {
// //         if(freq.ContainsKey(ch))
// //         {
// //             freq[ch]++;
// //         }
// //         else
// //         {
// //             freq[ch] = 1;
// //         }
// //     }


// //     foreach(char ch in text)
// //     {
// //         if(freq[ch]==1)
// //         {
// //             return ch;
// //         }
// //     }

// //     return null;

// public static Dictionary<string, List<string>> SolveAnagrams(string[] words)
//     {
        
//         foreach(string word in words)
//         {
//             char[] characters  = word.ToCharArray();
//             characters.Sort();

//             string key = new string(characters);
//         }
//     }
// }
// namespace cSharp_withMrMike.String;

// // Given a string, if a length 2 substring appears at both its beginning and end, 
// // return a string without the substring at the beginning, so "HelloHe" yields "lloHe". 
// // The substring may overlap with itself, so "Hi" yields "". Otherwise, return the original string unchanged.

// // Examples

// // without2('HelloHe') → lloHe
// // without2('HelloHi') → HelloHi
// // without2('Hi') →

// public class WithoutT
// {
//     public static string withoutT(string word)
//     {
//         string newString = " ";
        
//         if(word.Length <= 2)
//         {
//             newString = "";
//         }

//         if(word[0] == word[word.Length-2] && word[1] == word[word.Length-1])
//         {
//             for(int i=2; i<word.Length-2; i++)
//             {
//                 newString += word[i];
//             }
//         }
//         else
//         {
//             newString = word;
//         }

//         return newString;
//     }
// }
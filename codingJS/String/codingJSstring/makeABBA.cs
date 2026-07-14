// namespace cSharp_withMrMike.String;

// // Given two strings, a and b, return the result of putting them together in the order abba, 
// // e.g. "Hi" and "Bye" returns "HiByeByeHi".

// // Examples

// // makeAbba('Hi', 'Bye') → HiByeByeHi
// // makeAbba('Yo', 'Alice') → YoAliceAliceYo
// // makeAbba('What', 'Up') → WhatUpUpWhat

// public class MakeAbba
// {
//     public static string combine(string word1, string word2)
//     {
//         string conCat = "";
//         string backCat = "";
//         string newCat = "";

//         conCat = word1+word2;

//         backCat = word2+word1;

//         newCat = conCat+backCat;
        
//         return newCat;
//     }
// }

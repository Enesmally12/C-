// namespace cSharp_withMrMike.share.shareDigit;

// // Given two ints, each in the range 10..99, return true if there is a digit that appears 
// // in both numbers, such as the 2 in 12 and 23. 
// // (Note: division, e.g. n/10, gives the left digit while the % "mod" n%10 gives the right digit.)

// // Examples

// // shareDigit(12, 23) → true
// // shareDigit(12, 43) → false
// // shareDigit(12, 44) → false

// public class shareDigit
// {
//     public void share(int a, int b)
//     {
//         bool isResult;
//         if(a/10 == b/10 || a % 10 == b % 10)
//         {
//             isResult =  true;
//             Console.WriteLine($"{isResult}");
//         }
//         else if(a/10 == b % 10 || a % 10 == b/ 10)
//         {
//             isResult =  true;
//             Console.WriteLine($"{isResult}");
//         }
//         else
//         {
//             isResult =  false;
//             Console.WriteLine($"{isResult}");
//         }
//     }
// }
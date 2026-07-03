// namespace cSharp_withMrMike;

// // Given three ints, a b c, return true if b is greater than a, and c is greater than b. 
// // However, with the exception that if "bOk" is true, b does not need to be greater than a.

// // Examples

// // inOrder(1, 2, 4, false) → true
// // inOrder(1, 2, 1, false) → false
// // inOrder(1, 1, 2, true) → true

// public class inOrder
// {
//     public void order(int a, int b, int c,bool isbOk)
//     {
//         bool isResult;
//         if(b > a && c > b)
//         {
//             isResult = true;
//             Console.WriteLine($"{isResult}");
//         }
//         else if(c > b && isbOk == true)
//         {
//             isResult = true;
//             Console.WriteLine($"{isResult}");
//         }
//         else
//         {
//             isResult = false;
//             Console.WriteLine($"{isResult}");
//         }
//     }
// }
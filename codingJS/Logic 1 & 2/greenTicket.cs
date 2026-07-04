
// namespace cSharp_withMrMike.greenTicket;

// // Logic-1 -- greenTicket
// // You have a green lottery ticket, with ints a, b, and c on it. 
// // If the numbers are all different from each other, the result is 0. If all of the numbers are the same, the result is 20. 
// // If two of the numbers are the same, the result is 10.

// // Examples

// // greenTicket(1, 2, 3) → 0
// // greenTicket(2, 2, 2) → 20
// // greenTicket(1, 1, 2) → 10

// public class greenTicket
// {
//     public void green(int a,int b,int c)
//     {
//         int result;
//         if(a != b && b != c && a != c)
//         {
//             result  = 0;
//             Console.WriteLine($"{result}");
//         }
//         else if( a == b && b==c )
//         {
//             result  = 20;
//             Console.WriteLine($"{result}");
//         }
//         else if(a == b || b == c || a == c)
//         {
//             result  = 10;
//             Console.WriteLine($"{result}");
//         }
//     }
// }
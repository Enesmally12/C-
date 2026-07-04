// namespace cSharp_withMrMike.fizzString;

// // Given a string str, if the string starts with "f" return "Fizz". 
// // If the string ends with "b" return "Buzz". If both the "f" and "b" conditions are true, return "FizzBuzz". 
// // In all other cases, return the string unchanged.

// // Examples

// // fizzString('fig') → Fizz
// // fizzString('dib') → Buzz
// // fizzString('fib') → FizzBuzz

// public class fizzString
// {
//     public void fizz(string fizz)
//     {
//         if(fizz[0] == 'f' && fizz[^1] == 'b')
//         {
//             fizz  = "FizzBuzz";
//             Console.WriteLine($"{fizz}");
//         }
//         else if(fizz[^1] == 'b')
//         {
//             fizz = "Buzz";
//             Console.WriteLine($"{fizz}");
//         }
//         else if(fizz[0] == 'f')
//         {
//             fizz = "Fizz";
//             Console.WriteLine($"{fizz}");
//         }
//         else
//         {
//             Console.WriteLine($"{fizz}");
//         }
//     }
// }
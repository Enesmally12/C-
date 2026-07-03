// namespace cSharp_withMrMike;
// // Given an int n, return the string form of the number followed by "!". So the int 6 yields "6!". 
// // Except if the number is divisible by 3 use "Fizz" instead of the number, and if the number is divisible by 5 use "Buzz", and 
// // if divisible by both 3 and 5, use "FizzBuzz". Note: the % "mod" operator computes the remainder after division, so 23 % 10 yields 3. 
// // What will the remainder be when one number divides evenly into another?

// // Examples

// // fizzString2(1) → 1!
// // fizzString2(2) → 2!
// // fizzString2(3) → Fizz!

// public class fizzString2
// {
//     public void fizz(int n)
//     {
//         string text = n.ToString();
//         if(n % 3 == 0 && n % 5== 0)
//         {
//             text = "FizzBuzz";
//             Console.WriteLine($"{text}!");
//         }
//         else if( n % 3 ==0)
//         {
//             text = "Fizz";
//             Console.WriteLine($"{text}!");
//         }
//         else if(n % 5 == 0)
//         {
//             text = "Buzz";
//             Console.WriteLine($"{text}!");
//         }
//         else
//         {
//             Console.WriteLine($"{text}!");
//         }
//     }
// }

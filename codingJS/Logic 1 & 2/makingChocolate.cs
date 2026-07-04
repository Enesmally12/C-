// namespace cSharp_withMrMike.makingChololate;

// // We want make a package of goal kilos of chocolate. We have small bars (1 kilo each) and big bars (5 kilos each). 
// // Return the number of small bars to use, assuming we always use big bars before small bars. Return -1 if it can't be done.

// // Examples

// // makeChocolate(4, 1, 9) → 4
// // makeChocolate(4, 1, 10) → -1
// // makeChocolate(4, 1, 7) → 2

// public class makingChocolate
// {
//     public void making(int small, int big, int goal)
//     {
//         int bigBrickstoUse = Math.Min(goal/5, big);

//         int smallBricks =  goal - bigBrickstoUse * 5;

//         int result= bigBrickstoUse + smallBricks;

//         if(result == goal)
//         {
//             Console.WriteLine($"{smallBricks}");
//         }
//         else
//         {
//             Console.WriteLine(-1);
//         }
//     }
// }
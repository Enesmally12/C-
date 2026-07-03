// namespace cSharp_withMrMike.luckySum;
// // Given 3 int values, a b c, return their sum. However, if one of the values is 
// // 13 then it does not count towards the sum and values to its right do not count. 
// // So for example, if b is 13, then both b and c do not count.

// // Examples

// // luckySum(1, 2, 3) → 6
// // luckySum(1, 2, 13) → 3
// // luckySum(1, 13, 3) → 1


// public class LuckySum
// {
//    public void luckyS(int a,int b, int c)
//     {
//         int sum=0;
//         if(a != 13)
//         {
//             sum += a;
//         }
        
//         if(b != 13 && a != 13)
//         {
//             sum += b;
//         }

//         if(c != 13 && b != 13)
//         {
//             sum += c;
//         }

//         Console.WriteLine($"{sum}");            

//     }
// }
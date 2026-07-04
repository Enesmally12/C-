// namespace cSharp_withMrMike.caughtSpeeding;

// // You are driving a little too fast, and a police officer stops you. Write code to compute the result, 
// // encoded as an int value: 0=no ticket, 1=small ticket, 2=big ticket. If speed is 60 or less, the result is 0. 
// // If speed is between 61 and 80 inclusive, the result is 1. If speed is 81 or more, the result is 2. Unless it is your birthday -- on that day, 
// // your speed can be 5 higher in all cases.

// // Examples

// // caughtSpeeding(60, false) → 0
// // caughtSpeeding(65, false) → 1
// // caughtSpeeding(65, true) → 0

// public class caughtSpeeding
// {
//     public void caught(int speed, bool isbirthday)
//     {
//     int ticket = 0;

//     if( isbirthday != false && speed <= 65)
//     {
//         ticket = 0;
//         Console.WriteLine($"{ticket}");
//     }
//     else if(speed <= 60)
//     {
//         ticket = 0;
//         Console.WriteLine($"{ticket}");
//     }
//     else if(isbirthday != false && speed >= 66 && speed <85)
//     {
//         ticket = 1;
//         Console.WriteLine($"{ticket}");
//     }
//     else if(speed >= 61 && speed <=80)
//     {
//         ticket = 1;
//         Console.WriteLine($"{ticket}");
//     }
//     else if(isbirthday != false && speed >= 85)
//     {
//         ticket = 2;
//         Console.WriteLine($"{ticket}");
//     }
//     else if(speed >= 81)
//     {
//         ticket = 2;    
//         Console.WriteLine($"{ticket}");
//     }
//     else
//     {
//         ticket = 0;
//         Console.WriteLine($"{ticket}");
//     }
//     }
// }
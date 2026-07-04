// namespace cSharp_withMrMike.inOrderEqual;

// // Given three ints, a b c, return true if they are in strict increasing order, 
// // such as 2 5 11, or 5 6 7, but not 6 5 7 or 5 5 7. However, 
// // with the exception that if "equalOk" is true, equality is allowed, such as 5 5 7 or 5 5 5.

// // Examples

// // inOrderEqual(2, 5, 11, false) → true
// // inOrderEqual(5, 7, 6, false) → false
// // inOrderEqual(5, 5, 7, true) → true

// public class inOrderEqual
// {
//     public void orderEqual(int a, int b, int c)
//     {

//     bool equalOk = true;
//     bool check;

//     if( b>a && c>b)
//     {
//         check = true;
//         Console.WriteLine($"{check}");
//     }
//     else if(b==a && c==b || c>b && equalOk == true)
//     {
//         check = true;
//         Console.WriteLine($"{check}");
//     }
//     else
//     {
//         check = false;
//         Console.WriteLine($"{check}");
//     }
//     }
// }
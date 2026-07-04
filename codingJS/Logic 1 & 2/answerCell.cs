// namespace cSharp_withMrMike.answerCell;
// // Your cell phone rings. Return true if you should answer it. Normally you answer, except in the morning you only answer 
// // if it is your mom calling. In all cases, if you are asleep, you do not answer.

// // Examples

// // answerCell(false, false, false) → true
// // answerCell(false, false, true) → false
// // answerCell(true, false, false) → false

// public class answerCell
// {
//     public void answer(bool isMorning, bool isMom, bool isAsleep)
//     {

//     bool result;

//     if(isMorning != false && isMom != false && isAsleep != true)
//     {
//         result = true;
//         Console.WriteLine($"{result}");
//     }
//     else if(isAsleep != false)
//     {
//         result = false;
//         Console.WriteLine($"{result}");
//     }
//     else if(isMorning != false && isMom != true)
//     {
//         result = false;
//         Console.WriteLine($"{result}");
//     }
//     else
//     {
//         result = true;
//         Console.WriteLine($"{result}");
//     }
//     }
// }
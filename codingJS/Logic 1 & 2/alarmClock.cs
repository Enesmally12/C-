// namespace cSharp_withMrMike.alarmClock;
// // Given a day of the week encoded as 0=Sun, 1=Mon, 2=Tue, ...6=Sat, and a boolean indicating if we are on vacation, 
// // return a string of the form "7:00" indicating when the alarm clock should ring. Weekdays, the alarm should be "7:00" and on the 
// // weekend it should be "10:00". Unless we are on vacation -- then on weekdays it should be "10:00" and weekends it should be "off".

// // Examples

// // alarmClock(1, false) → 7:00
// // alarmClock(5, false) → 7:00
// // alarmClock(0, false) → 10:00

// public class alarmClock
// {
//     public void alarm(string alarm, int day)
//     {
//     bool isVacation= false;

//     if((isVacation != false)&& (day == 6 || day == 0 ))
//     {
//         alarm = "OFF";
//         Console.WriteLine($"{alarm}");
//     }
//     else if(isVacation !=false && (day >= 1 && day <=5))
//     {
//         alarm = "10:00";
//         Console.WriteLine($"{alarm}");
//     }
//     else if(isVacation !=true && (day >= 1 && day <=5))
//     {
//         alarm = "7:00";
//         Console.WriteLine($"{alarm}");
//     }
//     else if(isVacation !=true && (day == 6 || day ==0))
//     {
//         alarm = "10:00";
//         Console.WriteLine($"{alarm}");
//     }

//     }
// }
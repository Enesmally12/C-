// namespace cSharp_withMrMike.squirrel;

// // The squirrels in Palo Alto spend most of the day playing. 
// // In particular, they play if the temperature is between 60 and 90 (inclusive). 
// // Unless it is summer, then the upper limit is 100 instead of 90. 
// // Given an int temperature and a boolean isSummer, return true if the squirrels play and false otherwise.

// // Examples

// // squirrelPlay(70, false) → true
// // squirrelPlay(95, false) → false
// // squirrelPlay(95, true) → true

// public class squirrelClass
// {
//     public void play(int play,bool isSummer)
//     {
//     bool result = false;

//     if(play >= 60 && play <= 90)
//     {
//         result = true;
//         Console.WriteLine($"{result}");
//     }
//     else if((play >= 60 && play <= 100) && isSummer == true)
//     {
//         result = true;
//         Console.WriteLine($"{result}");
//     }
//     else
//     {
//         result = false;
//         Console.WriteLine($"{result}");
//     }
//     }
// }
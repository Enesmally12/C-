// using System.Net.NetworkInformation;

// namespace cSharp_withMrMike.Banks;

// public class Bank
// {
//    public static decimal balance = 50000;
   
//    public static void ShowMenu()
//     {
//         Console.WriteLine();
//         Console.WriteLine("=== ATM MACHINE MENU ===");
//         Console.WriteLine("1. Check balance");
//         Console.WriteLine("2. Deposit");
//         Console.WriteLine("3. Withdrawal");
//         Console.WriteLine("4. Exit menu");
//     }

//     public static void CheckBalance()
//     {
//         Console.WriteLine($"Current balance: ₦{balance}");
//     }


//     public static void Deposit()
//     {
//         Console.WriteLine($"Enter the amount to deposit");
//         decimal amount = Convert.ToDecimal(Console.ReadLine());
        
//         if(amount > 100)
//         {
//             balance += amount;
//             Console.WriteLine("Deposit Successful.");
//         }
//         else
//         {
//             Console.WriteLine("Amount must be greater than ₦100");
//         }
//     }

//     public static void Withdraw()
//     {
//         Console.WriteLine("Enter amount to withdraw");
//         decimal amount = Convert.ToDecimal(Console.ReadLine());

//         if(amount < balance)
//         {
//             balance -= amount;
//             Console.WriteLine("Withdrawal Successful.");
//         }
//         else
//         {
//             Console.WriteLine("Insufficient Funds!");
//         }
//     }

//     public static void Exit()
//     {
//         Console.WriteLine("Are you sure you want to exit.");
//     }

//     public static void confirmExit()
//     {
//         Console.WriteLine("Are you sure you want to exit.(Y/N)");
//         Console.ReadLine(); 
//     }

//     public static void RunATM()
//     {
//         int option;
//         int pin;

//         Console.WriteLine("Enter your pin:");
//         pin = Convert.ToInt32(Console.ReadLine());

//         if(pin == 1234)
//         {
//                 do
//             {
//                 ShowMenu();
//                 Console.WriteLine("Enter your option:");
//                 option = Convert.ToInt32(Console.ReadLine());

//                 switch(option)
//                 {
//                     case 1:
//                     CheckBalance();
//                     break;

//                     case 2:
//                     Deposit();
//                     break;

//                     case 3:
//                     Withdraw();
//                     break;

//                     case 4:
//                     Exit();
//                     break;

//                     default:
//                     Console.WriteLine("Input must be between 1-4");
//                     break;
                
//                 }
//             }while(option != 4);
//         }
//         else
//         {
//             Console.WriteLine("INVALID PIN");
//         }
            
//     }

// }
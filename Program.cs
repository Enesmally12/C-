using cSharp_withMrMike.String;


// // Dictionary<string, decimal> ingredients = new();

// // ingredients.Add("onion", 1500);
// // ingredients.Add("spag", 1700);
// // ingredients.Add("maggi",500);
// // ingredients.Add("oil", 500);
// // ingredients.Add("crayfish", 1000);
// // ingredients.Add("tomato", 2000);
// // ingredients.Add("salt", 300);
// // ingredients.Add("pepper", 500);

// // if(ingredients.ContainsKey("onion"))
// // {
// //     Console.WriteLine("Ingredient found");
// // }
// // else
// // {
// //     Console.WriteLine("Ingredient not found");
// // }

// List<int> numbers = [2,4,6,7,0];



// List<int> results = checkIndex.getIndex(numbers, 9);

// foreach(var result in results)
// {
//     Console.WriteLine(result);
// }

Paymentprocess paymentProcess = new CardPayment();

Paymentprocess paymentProcess2 = new BankTransfer();

Paymentprocess paymentProcess3 = new CryptoPayment();

paymentProcess.PaymentMethod(30000);

Console.WriteLine("  ");

paymentProcess2.PaymentMethod(22000);

Console.WriteLine(" ");

paymentProcess3.PaymentMethod(40000);
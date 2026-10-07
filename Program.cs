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

Employee PermanentEmployee = new PermanetEmployee(1, "David", 150000, 50000, 15000);

Employee ContractEmployee = new ContractEmployee(2, "John", 150000, 30000);

Employee InterEmployee = new Intern(3, "Deinma", 15000, "6 Months");

Console.WriteLine($"Permanet Employee Salary is:{PermanentEmployee.calculateSalary()}");
 Console.WriteLine("");
Console.WriteLine($"Contract Employee Salary is:{ContractEmployee.calculateSalary()}");
 Console.WriteLine("");
Console.WriteLine($"Intern Salary is:{InterEmployee.calculateSalary()}");
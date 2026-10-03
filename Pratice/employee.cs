using System.Dynamic;

namespace cSharp_withMrMike.String;

public class Employees
{
    public int id{get; set;}
    public string name{get; set;}

    public string Department{get; set;}

    public decimal Salary{get; set;}

    public DateTime HiredDate{get; set;}

    public override string ToString()=> $"Id: {id}\nName: {name}\nDepartment: {Department}\nSalary:{Salary}\nHireDate: {HiredDate}";
    
}

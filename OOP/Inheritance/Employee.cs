namespace cSharp_withMrMike.String;

public abstract class Employee
{
    public int Id{get;}

    public string Name{get;}

    public decimal Salary{get;}

    protected Employee(int id, string name, decimal salary)
    {       
        
        if(id <=0 ) throw new ArgumentOutOfRangeException(nameof(id));
    

        if(string.IsNullOrWhiteSpace(name)) throw new ArgumentException(nameof(name));

        if(salary <= 0 ) throw new ArgumentOutOfRangeException(nameof(salary));

        Id = id;

        Name = name;

        Salary = salary;
    }

    public abstract decimal calculateSalary();
   
}
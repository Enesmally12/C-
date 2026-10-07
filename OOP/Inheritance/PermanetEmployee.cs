namespace cSharp_withMrMike.String;

public class PermanetEmployee : Employee
{
    public decimal Allowance{get;}

    public decimal Benefits{get;}


    public PermanetEmployee(int id, string name, decimal salary, decimal allowance, decimal benefits):base(id , name , salary)
    {
        if(allowance < 0 ) throw new ArgumentOutOfRangeException(nameof(allowance), "Allowance cannot be less than zero.");

        Allowance = allowance;

        Benefits = benefits;

    }
    public override decimal calculateSalary()
    {
        return Salary + Allowance + Benefits;  
    }


}
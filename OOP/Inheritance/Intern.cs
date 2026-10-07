namespace cSharp_withMrMike.String;

public class Intern : Employee
{
    public string InternDuration{get;}
    public Intern(int id, string name, decimal salary, string internDuration) :base(id, name, salary)
    {
        InternDuration = internDuration;
    }
    public override decimal calculateSalary()
    {
        return Salary;
    }
}
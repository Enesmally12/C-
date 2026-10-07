namespace cSharp_withMrMike.String;

public class ContractEmployee : Employee
{
    public decimal ContractAllowance{get;}

    public ContractEmployee(int id, string name, decimal salary, decimal contractAllowance): base(id, name, salary)
    {
        if(contractAllowance <0) throw new ArgumentOutOfRangeException(nameof(contractAllowance));

        ContractAllowance = contractAllowance;
    }
    public override decimal calculateSalary()
    {
        return Salary+ContractAllowance;
    }
}
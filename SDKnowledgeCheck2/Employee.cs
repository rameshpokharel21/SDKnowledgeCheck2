namespace SDKnowledgeCheck2;

public class Employee : Person
{
    public double Salary { get; set; }

    public override string ToString() =>  $"{base.ToString()}\nSalary: {Salary:C2}\n";
   
}

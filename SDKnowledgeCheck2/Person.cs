namespace SDKnowledgeCheck2;

public  class Person
{
    public String? Name { get; set; }
    public int Age { get; set; }

    public override string ToString() => $"\nName: {Name}\nAge: {Age}";
    
}

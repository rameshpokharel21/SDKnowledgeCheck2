

using SDKnowledgeCheck2;
using System.Text.Json;



var recordList = new List<Employee>();
bool isValid = true;

do
{
    try
    {
        Console.WriteLine("\nHow many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var myClass = new Employee();

            Console.WriteLine("\nEnter the value for Name:");
            myClass.Name = Console.ReadLine();

            Console.WriteLine("Enter the value for Age ");
            myClass.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value for Salary ");
            myClass.Salary = Double.Parse(Console.ReadLine());

            recordList.Add(myClass);
            
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        isValid = false;
    }
} while (!isValid);

// Print out the list of records using Console.WriteLine()
Console.WriteLine("\nHere is the list of objects created:\n");
foreach (var record in recordList)
{
    Console.WriteLine($"{JsonSerializer.Serialize(record)}");


}



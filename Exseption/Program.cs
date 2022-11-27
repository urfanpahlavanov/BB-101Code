// See https://aka.ms/new-console-template for more information
using Exseption;
using Exseption.Exseption;


Employee employee = new Employee("Urfan",20,1000);
    
Console.WriteLine(employee.IdProp);

try
{
	var department = new Department("Urfan",15);

	department.Exceptionmethod();
}
catch (CapacityLimitException ex)
{

	Console.WriteLine(ex.Message);
}

using Microsoft.AspNetCore.Mvc;

public class EmployeeOld
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public decimal Salary { get; set; }

    public EmployeeOld(string firstName, string lastName, DateTime hireDate, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        HireDate = hireDate;
        Salary = salary;
    }
}

public class EmployeeNew(string firstName, string lastName, DateTime hireDate, decimal salary)
{
    public string FirstName { get; init; } = firstName;
    public string LastName { get; init; } = lastName;
    public DateTime HireDate { get; init; } = hireDate;
    public decimal Salary { get; init; } = salary;

    public void SayHello()
    {
        Console.WriteLine($"This is ${firstName} ${lastName}");
    }

}


/// Dependency injection example for usage if Primary Constructors
/// 
public interface IService
{
    object GetData();
}

public class ExampleControllerOld : ControllerBase
{
    private readonly IService _service;
    public ExampleControllerOld(IService service)
    {
        _service = service;
    }
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.GetData());
    }
}

public class ExampleControllerNew(IService service) : ControllerBase
{
    private readonly IService _service = service;

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.GetData());
    }
}
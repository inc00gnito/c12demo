var refOnlyParametersDemo = new RefOnlyParameters();
var number = 5;

refOnlyParametersDemo.PrintOld(ref number);
Console.WriteLine($"Your number is now {number}");
public class RefOnlyParameters
{
    public void PrintOld(ref int number)
    {
        Console.WriteLine($"Your number is {number}");
        number++;
    }

    //public void PrintNew(in int number)
    //{
    //    Console.WriteLine($"Your number is {number}");
    //    number++;
    //}
}
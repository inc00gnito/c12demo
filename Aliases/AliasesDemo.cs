// C#12 using

using Point = (int x, int y);
using CityPlaces = System.Collections.Generic.Dictionary<string, System.Collections.Generic.IEnumerable<string>>;

Tuple <int, int> pointTuple = new Tuple<int,int>(1,2);

var point = new Point(3, 4);
(var xPos, var yPos) = point;
Console.WriteLine(xPos + " "  + yPos);
Point Copy(Point source)
{
    return new Point(source.x, source.y);
}

var copyPoint = Copy(point);
Console.WriteLine(copyPoint);
class ExampleClass
{
    //public Dictionary<string, IEnumerable<string>> CityPlaces { get; set; }
    public CityPlaces CityPlaces { get; set; } = new();
}
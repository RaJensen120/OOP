// See https://aka.ms/new-console-template for more information
/*
using System {
    public static ConvertRadiansToDegrees(double radians) {

        double degrees = (180/Math.PI) * radians;
        return (degrees);
    }
}
*/


Console.WriteLine("Enter radians");
double radians = Convert.ToDouble(Console.ReadLine());
double degrees = ((180/Math.PI) * radians)%360;
       // return (degrees);
        Console.WriteLine(degrees);

Console.WriteLine("Enter degrees");
double degrees2 = Convert.ToDouble(Console.ReadLine());
double radians2 = ((Math.PI/180) * degrees2)%(2*Math.PI);
       // return (degrees);
        Console.WriteLine(radians2);

using System.Net.Http.Headers;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;
using System.Xml.XPath;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Choose your A point coordinates: ");
        System.Console.Write("X: ");
        int xa = int.Parse(Console.ReadLine());
        System.Console.Write("Y: ");
        int ya = int.Parse(Console.ReadLine());
        
        System.Console.WriteLine("Choose your A point coordinates: ");
        System.Console.Write("X: ");
        int xb = int.Parse(Console.ReadLine());
        System.Console.Write("Y: ");
        int yb = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Calculating...");
        pointsDist point = new pointsDist(xa, ya, xb, yb);
        point.calculate();
    }

    public struct pointsDist
    {
        public static int Xa { get; set; }
        public static int Ya { get; set; }
        public static int Xb { get; set; }
        public static int Yb { get; set; }

        public pointsDist(int xa, int ya, int xb, int yb)
        {
            Xa = xa;
            Ya = ya;

            Xb = xb;
            Yb = yb;
        }

        public void calculate(){
            double xResult = Math.Pow(Xb + Xa, 2);
            double yResult = Math.Pow(Yb - Ya, 2);
            double distSqrt = Math.Sqrt(xResult + yResult);
            double roundedResult = Math.Round(distSqrt, 3);

            System.Console.WriteLine("Calculation done!");
            System.Console.WriteLine($"{roundedResult} is a distance between point A({Xa}, {Ya}) and B({Xb}, {Yb})");

        }
    }
}

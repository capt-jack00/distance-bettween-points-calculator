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
        
        System.Console.WriteLine("Choose your B point coordinates: ");
        System.Console.Write("X: ");
        int xb = int.Parse(Console.ReadLine());
        System.Console.Write("Y: ");
        int yb = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Calculating...");
        cordSys pointSys = new cordSys(xa, ya, xb, yb);
        pointSys.calcDist();
        pointSys.calcMiddle();
    }

    public struct cordSys
    {
        public static int Xa { get; set; }
        public static int Ya { get; set; }
        public static int Xb { get; set; }
        public static int Yb { get; set; }

        public cordSys(int xa, int ya, int xb, int yb)
        {
            // X and Y coordinates for A point
            Xa = xa;
            Ya = ya;

            // X and Y coordinates for B point
            Xb = xb;
            Yb = yb;
        }

        // Calculate distance between two points
        public void calcDist(){
            double xResult = Math.Pow(Xb + Xa, 2);
            double yResult = Math.Pow(Yb - Ya, 2);
            double distSqrt = Math.Sqrt(xResult + yResult);
            double roundedResult = Math.Round(distSqrt, 3);

            System.Console.WriteLine("Calculation done!");
            System.Console.WriteLine($"{roundedResult} is a distance between point A({Xa}, {Ya}) and B({Xb}, {Yb})");

        }


        // Calculate middle point between two points
        public void calcMiddle(){
            double xMiddle = (Xa + Xb) / 2;
            double yMiddle = (Ya + Yb) / 2;

            // System.Console.WriteLine("Calculation done!");
            System.Console.WriteLine($"Middle point between point A({Xa}, {Ya}) and B({Xb}, {Yb}) is S({xMiddle}, {yMiddle})");        
        }
    }
}

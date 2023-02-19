namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int x1 = 1;
            int y1 = 2;
            int x2 = 3;
            int y2 = 4;
            //Variables
            double dist = 0;
            dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));

            Console.WriteLine("Distance Between Two Point is " + dist);
        }
    }
}
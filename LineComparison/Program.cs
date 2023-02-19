namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1 = 1;
            double a2 = 2;
            double b1 = 3;
            double b2 = 6;
            double c1 = 4;
            double c2 = 8;

            if ((a1 / a2 == b1 / b2) && (c1 / c2 == a1 / a2) && (b1 / b2 == c1 / c2))
            {
                Console.WriteLine("The Two lines are Equal");
            }
            else
                Console.WriteLine("The Two Lines are not Equal");
        }
    }
}
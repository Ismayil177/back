namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*    int a = 10;

            int b;

            b = a;

            a = 11;

            Console.WriteLine( a );
            Console.WriteLine( b );*/

            Location l1 = new Location();
            l1.x = 10;
            l1.y = 20;

            Location l2 = l1;

            Console.WriteLine(l1);
            Console.WriteLine(l2);

            l1.y = 100;

            Console.WriteLine(l1);
            Console.WriteLine(l2);
        }

        class Location
        {
            public int x { get; set; }
            public int y { get; set; }

            public override string ToString()
            {
                return $"({this.x} , {this.y})";
            }
        }
    }
}
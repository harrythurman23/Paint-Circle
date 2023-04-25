using System;

namespace Paint_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is the radius of the center cricle you need to paint, in feet?");
            int radius = Convert.ToInt32(Console.ReadLine());
            int area = Convert.ToInt32(radius * radius * Math.PI); // can use (int) instead of convert.toint32 for doubles like here; doesnt work on strings


            Console.WriteLine("what color paint would you like to use? you choices are red, blue, green, and yellow");
            string color = Console.ReadLine().ToLower();
            //use console.tolower(string) too
            if (color == "red")
            { Console.WriteLine("it will take " + (area / 100 + 1) + " buckets to paint the " + (radius) + "' radius circle red"); }
            if (color == "blue")
            { Console.WriteLine("it will take " + (area / 120 + 1) + " buckets to paint the " + (radius) + "' radius circle blue"); }
            if (color == "green")
            { Console.WriteLine("it will take " + (area / 90 + 1) + " buckets to paint the " + (radius) + "' radius circle green"); }
            if (color == "yellow")
            { Console.WriteLine("it will take " + (area / 70 + 1) + " buckets to paint the " + (radius) + "' radius circle yellow"); }
        }
    }
}

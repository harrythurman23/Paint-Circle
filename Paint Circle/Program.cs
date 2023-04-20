using System;

namespace Paint_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Writeline("what is the radius of the center cricle you need to paint, in feet?");
            int radius = convert.toint32(console.readline());
            int area = convert.toint32(radius * radius * math.pi); // can use (int) instead of convert.toint32 for doubles like here; doesnt work on strings


            console.writeline("what color paint would you like to use? you choices are red, blue, green, and yellow");
            string color = console.readline().tolower();
            //use console.tolower(string) too
            if (color == "red")
            { console.writeline("it will take " + (area / 100 + 1) + " buckets to paint the " + (radius) + "' radius circle red"); }
            if (color == "blue")
            { console.writeline("it will take " + (area / 120 + 1) + " buckets to paint the " + (radius) + "' radius circle blue"); }
            if (color == "green")
            { console.writeline("it will take " + (area / 90 + 1) + " buckets to paint the " + (radius) + "' radius circle green"); }
            if (color == "yellow")
            { console.writeline("it will take " + (area / 70 + 1) + " buckets to paint the " + (radius) + "' radius circle yellow"); }
        }
    }
}

using System;

namespace Bai1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cylinder = new Cylinder();
            cylinder.Radius = 38.64;
            cylinder.Height = 22.48;
            Console.WriteLine("Enter the dimensions of the cylinder");
            Console.WriteLine($"Height: {cylinder.Height}");
            Console.WriteLine($"Radius: {cylinder.Radius}");
            cylinder.Process();
            cylinder.Result();
        }
        
    }

     class Cylinder 
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double BaseArea { get; set; }
        public double LateralArea { get; set; }
        public double TotalArea { get; set; }
        public double Volume { get; set; }
        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Radius * Height * Math.PI;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics:");
            Console.WriteLine($"Radius: {Radius}, Height: {Height}");
            Console.WriteLine($"Base: {BaseArea}, Lateral: {LateralArea}, Total: {TotalArea}, Volume: {Volume}");
        }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public Cylinder()
        {
        }
    }
    
    
}
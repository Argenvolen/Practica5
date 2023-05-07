using System.Security.Cryptography.X509Certificates;

namespace Praktika5
{
    abstract class Figures
    {
        protected float ParaStorA;
        protected float TriStorA;
        public Figures(float ParaStorA, float TriStorA)
        {
            this.ParaStorA = ParaStorA;
            this.TriStorA = TriStorA;
        }
        public abstract float Area();
        public abstract float Perimeter();
        public abstract float Circumference();
    }
    class Circle : Figures
    {
        float Radius;
        public Circle(float ParaStorA, float TriStorA, float Radius) : base(0, 0)
        {
            this.Radius = Radius;
        }
        public override float Circumference()
        {
            return (float)(2 * Math.PI * this.Radius);
        }
        public override float Area()
        {
            return (float)(Math.PI * Math.Pow(this.Radius, 2));
        }
        public override float Perimeter()
        {
            return 0f;
        }
    }
    class Triangle : Figures
    {
        float TriStorB;
        float TriStorC;
        float TriAh;
        public Triangle(float TriStorA, float TriStorB, float TriStorC, float TriAh) : base(0, TriStorA)
        {
            this.TriStorB = TriStorB;
            this.TriStorC = TriStorC;
            this.TriAh = TriAh;
        }
        public override float Area()
        {
            return 0.5f * this.TriAh * this.TriStorA;
        }
        public override float Perimeter()
        {
            return this.TriStorA + this.TriStorB + this.TriStorC;
        }
        public override float Circumference()
        {
            return 0f;
        }
    }
    class Rectangle : Figures
    {
        float ParaStorB;
        public Rectangle(float ParaStorA, float ParaStorB) : base(ParaStorA, 0)
        {
            this.ParaStorB = ParaStorB;
        }
        public override float Area()
        {
            return this.ParaStorA * this.ParaStorB;
        }
        public override float Perimeter()
        {
            return 2 * this.ParaStorA + 2 * this.ParaStorB;
        }
        public override float Circumference()
        {
            return 0f;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle igrik = new Circle(0, 0, 12);
            Triangle gichik = new Triangle(12, 15, 13, 7);
            Rectangle gugi = new Rectangle(17, 10);
            Console.WriteLine($"Довжина кола: {igrik.Circumference()} \nПлоща: {igrik.Area()}");
            Console.WriteLine($"Площа трикутника: {gichik.Area()} \nПериметр трикутника: {gichik.Perimeter()}");
            Console.WriteLine($"Площа прямокутника: {gugi.Area()} \nПериметр прямокутника: {gugi.Perimeter()}");
            Console.ReadLine();
        }
    }
}
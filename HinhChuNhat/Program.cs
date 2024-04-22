class Program
    {
        static void Main(string[] args)
        {

            System.Console.WriteLine("Enter the width:");
            double width = Double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the height:");
            double height = Double.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(width, height);
            System.Console.WriteLine("Your Rectangle \n" + rectangle.Display());
            System.Console.WriteLine("Perimeter of the Rectangle: " + rectangle.GetPerimeter());
            System.Console.WriteLine("Area of the Rectangle: " + rectangle.GetArea());
        }

    }

    public class Rectangle
    {
        double width, height;

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return this.width * this.height;
        }

        public double GetPerimeter()
        {
            return (this.width + this.height) * 2;
        }

        public String Display()
        {
            return "Rectangle{" + "width=" + width + ", height=" + height + "}";
        }
    }
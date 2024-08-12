namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            var sum = a + b;
            Console.WriteLine($"17+4 is {sum}");
            var difference = a - b;
            Console.WriteLine($"17-4 is {difference}");
            var multiply = a * b;
            Console.WriteLine($"17*4 is {multiply}");
            int quotient = a / b;
            Console.WriteLine($"17/4 is {quotient}");
            var remainder = a % b;
            Console.WriteLine($"17%4 is {quotient} remainder {remainder}");
            
            Console.WriteLine("What is the radius of your circle? ");
            var radius = double.Parse(Console.ReadLine());
            AreaOfCircle(radius);
        }

        public static double AreaOfCircle(double radius)
        {
            var answer = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of a circle with radius of {radius} is {answer}");
            return answer;
        }
    }
}

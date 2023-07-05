namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            var celsius = TempConverter.FahrenheitToCelsius(50.00); 
            var fahrenheit = TempConverter.CelsiusToFahrenheit(100.00);

            Console.WriteLine($"{fahrenheit} degrees fahrenheit");
            Console.WriteLine($"{celsius} degrees celsius");
        }
    }
}

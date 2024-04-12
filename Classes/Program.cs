namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Porshe";
            myCar.Model = "911 GT3 RS";
            myCar.Year = 2020;

            var honda = new Car()
            {
                 Make = "Honda",
                 Model = "Civic Type R",
                 Year = 2024,
            };

            var chevy = new Car("Chevy", "Cammaro", 2016);

            var carList = new List<Car>() { myCar, chevy, honda,}; 

            foreach (var vehicle in carList)
            { 
               Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }


        }
    }
}

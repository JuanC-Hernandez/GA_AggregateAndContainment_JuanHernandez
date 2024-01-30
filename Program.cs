namespace GA_AggregateAndContainment_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Guided Assingment: Aggregation and Containment
        // 01/29/2024

        static List<Engine> _engines; // Declare a list of Engine objects.
        static void Main(string[] args)
        {
            _engines = new List<Engine>(); // Initialize the list of engines.

            GraphicsCard gc = new GraphicsCard(GraphicsCard.Brand.Intel); // Create a GraphicsCard

            Computer comp = new Computer(gc); // Create a Computer object

            Engine fastEngine = new Engine(250); // Create a fast Engine with a power of 250.
            Engine slowerEngine = new Engine(120); // Create a slower Engine with a power of 120.

            _engines.Add(fastEngine); 
            _engines.Add(slowerEngine); 

            Suspension suspension = new Suspension(-.4f, 5, .5f); // Create a Suspension

            Car car = new Car("Ford", "Escort", fastEngine, suspension); // Create a Car object 
            Console.WriteLine(car.ToString()); // Print information about the car.

            Character donkeyKong = new Character(150, "Donkey Kong"); // Create a Character object
            GoKart goKart = new GoKart(donkeyKong); // Create a GoKart object

            Console.WriteLine(goKart); 

            Character toad = new Character(50, "Toad"); // Create another Character object 
            GoKart goKartToad = new GoKart(toad); // Create another GoKart object
            Console.WriteLine(goKartToad); 
            Console.WriteLine("Before our try catch");

            goKartToad.TweakEngine(-50);

            try
            {
                Console.WriteLine("We reached this line of code");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("This is after our try catch");
        }
    }
}// Done
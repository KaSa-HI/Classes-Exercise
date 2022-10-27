namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car aCuteCar = new Car();
            Car aCuteCar2 = new Car();
            Car aCuteCar3 = new Car();

            aCuteCar.Name = "Mini";
            aCuteCar2.Name = "Aceman";
            aCuteCar3.Name = "2022";

            Console.Write(aCuteCar.Name);
            Console.WriteLine(aCuteCar2.Name);
            Console.WriteLine(aCuteCar3.Name);

        }
    }
}

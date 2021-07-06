using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string another = " ";
            do
            {
                Force force = new Force();

                Console.WriteLine("Please enter the mass of the first object in kilograms: ");
                double mass1 = Convert.ToDouble(Console.ReadLine());               

                Console.WriteLine("Please enter the mass of the second object in kilograms: ");
                double mass2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please enter the distance between the two objects in meters: ");
                double distance = Convert.ToDouble(Console.ReadLine());

                
                force.MassOfObject1 = mass1;
                force.MassOfObject2 = mass2;

                force.DistanceBetweenObjects = distance;

                Console.WriteLine("The force is: {0}", force.GravitationalForce);

                Console.WriteLine("Would you like to do another? Please enter yes or no.");
                another = Console.ReadLine();

            } while (another.Equals("yes"));
        }
    }
}

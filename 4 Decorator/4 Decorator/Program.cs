using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public enum ECarType
{
    Basic,
    Acces,
    Ambiance,
    Laureate
}


namespace _4_Decorator
{
    class Program
    {
        static void Main()
        {
            ICar basicCar = new BasicCar();
            Console.WriteLine("Basic Car:");
            basicCar.Assemble();
            Console.WriteLine($"Price: {basicCar.GetPrice()} UM");

            ICar accesCar = new AccesDecorator(new BasicCar());
            Console.WriteLine("\nAcces Car:");
            accesCar.Assemble();
            Console.WriteLine($"Price: {accesCar.GetPrice()} UM");

            ICar ambianceCar = new AmbianceDecorator(new BasicCar());
            Console.WriteLine("\nAmbiance Car:");
            ambianceCar.Assemble();
            Console.WriteLine($"Price: {ambianceCar.GetPrice()} UM");

            ICar laureateCar = new LaureateDecorator(new AmbianceDecorator(new BasicCar()));
            Console.WriteLine("\nLaureate Car:");
            laureateCar.Assemble();
            Console.WriteLine($"Price: {laureateCar.GetPrice()} UM");
        }
    }
}

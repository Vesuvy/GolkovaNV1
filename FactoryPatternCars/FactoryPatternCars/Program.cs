using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPatternCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarFactory carFactory = new CarFactory();
            List<Car> cars = new List<Car>();

            Car sportCar = carFactory.CreateCar("С", "BMW", 35, 50);
            Car electroCar = carFactory.CreateCar("Э", "Tesla X", 20, 40);

            cars.Add(sportCar);
            cars.Add(electroCar);

            Console.WriteLine("Гонка началась...");

            int raceDistance = 1000;

            while (true)
            {
                foreach (Car car in cars)
                {
                    car.Move();
                    Console.WriteLine(car.ToString());
                }

                if (cars.TrueForAll(d => d.Distance >= raceDistance))
                {
                    Console.WriteLine("Гонка закончилась!");
                    cars.Sort((car1, car2) => car2.Distance.CompareTo(car1.Distance));

                    for (int i = 0; i < cars.Count; i++)
                    {
                        Console.WriteLine($"Место {i+1}: {cars[i].Name}");
                    }
                    break;                    
                }
            }
            

        }
    }

    public abstract class Car
    {
        public string Name { get; set; }
        public int MaxSpeed { get; set; }
        public int Acceleration { get; set; } // Ускорение
        public int Deceleration { get; set; } // Замедление
        public int CurrentSpeed { get; set; } // Скорость в данный момент
        public int Distance { get; set; }

        public Car(string name, int acceleration, int deceleration)
        {
            Name = name;
            Acceleration = acceleration;
            Deceleration = deceleration;
            Distance = 0;
            CurrentSpeed = 0;
        }
        abstract public void Move();

        public override string ToString() =>
            $"Машина: {Name} | Текущая скорость: {CurrentSpeed} | Ускорение: {Acceleration} | Замедление: {Deceleration} | " +
            $"Дистанция: {Distance} |.";

    }
    public class SportCar : Car
    {
        public SportCar(string name, int acceleration, int deceleration) : base(name, acceleration, deceleration)
        {
            MaxSpeed = 400;
        }

        public override void Move()
        {
            //ускорение
            while (CurrentSpeed < MaxSpeed)
            {
                CurrentSpeed += Acceleration;
                Distance += CurrentSpeed;
                if (Distance > 1000) break;
            }

            //замедление
            //while (CurrentSpeed > 0)
            //{
            //    CurrentSpeed -= Deceleration;
            //    Distance += CurrentSpeed;
            //    if (Distance > 1000) break;
            //}
        }
    }
    public class ElectroCar : Car
    {
        public ElectroCar(string name, int acceleration, int deceleration) : base(name, acceleration, deceleration)
        {
            MaxSpeed = 250;
        }

        public override void Move()
        {
            //ускорение
            while (CurrentSpeed < MaxSpeed)
            {
                CurrentSpeed += Acceleration;
                Distance += CurrentSpeed;
                if (Distance > 1000) break;
            }

            //замедление
            //while (CurrentSpeed > 0)
            //{
            //    CurrentSpeed -= Deceleration;
            //    Distance += CurrentSpeed;
            //    if (Distance > 1000) break;
            //}
        }
    }
    public class CarFactory
    {
        public Car CreateCar(string carType, string name, int acceleration, int deceleration)
        {
            Car car;

            switch (carType)
            {
                case "С":
                    car = new SportCar(name, acceleration, deceleration);
                    break;
                case "Э":
                    car = new ElectroCar(name, acceleration, deceleration);
                    break;
                default:
                    throw new ArgumentException("Недопустимый тип!");
            }
            return car;
        }
    }
}

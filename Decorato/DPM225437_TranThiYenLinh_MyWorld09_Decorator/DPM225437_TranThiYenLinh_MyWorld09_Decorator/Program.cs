using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld09_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Coffee();
            Console.WriteLine($"{coffee.GetDescription()} giá {coffee.GetCost()} VND");

            // Thêm sữa
            Beverage milkCoffee = new Milk(coffee);
            Console.WriteLine($"{milkCoffee.GetDescription()} giá {milkCoffee.GetCost()} VND");

            // Thêm sữa + đường
            Beverage sweetMilkCoffee = new Sugar(milkCoffee);
            Console.WriteLine($"{sweetMilkCoffee.GetDescription()} giá {sweetMilkCoffee.GetCost()} VND");

            Console.ReadKey();
        }
    }
}

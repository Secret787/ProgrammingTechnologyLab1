using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Burger first_burger = new BaseBurger("Чизбургер");

            Burger first_burger_with_Cutlet = new AddCutlet(first_burger);

            Burger first_burger_with_Salad = new AddSalad(first_burger);

            double Order_cost = Math.Round(
                first_burger.SetPrice() + 
                first_burger_with_Cutlet.SetPrice() + 
                first_burger_with_Salad.SetPrice(), 2);

            Console.WriteLine("Приготовление заказа:");
            Console.WriteLine("Описание: ");
            Console.WriteLine(first_burger.SetSpecification() 
                    + " - " + first_burger.SetPrice());
            Console.WriteLine(first_burger_with_Cutlet.SetSpecification() 
                    + " - " + first_burger_with_Cutlet.SetPrice());
            Console.WriteLine(first_burger_with_Salad.SetSpecification()  
                    + " - " + first_burger_with_Salad.SetPrice());
            Console.WriteLine("Итоговая стоймость заказ : " + Order_cost);

            Console.ReadKey();



        }
    }
}

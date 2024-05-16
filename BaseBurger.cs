using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab1
{
    public class BaseBurger : Burger
    {
        private string BurgerName;

        private CreatePrice cost;
        
        public BaseBurger(string BurgerName) 
        {
            this.BurgerName = BurgerName;
            SetCost();

        }

        private void SetCost()
        {
            switch (BurgerName)
            {
                case "Чизбургер":
                    cost = new Cheeseburger();
                    break;
                case "Чикенбургер":
                    cost = new Chickenburger();
                    break;
                case "Гамбургер":
                    cost = new Hamburger();
                    break;
                case "Бикмак":
                    cost = new BigMac();
                    break;

            }
        }


        public double SetPrice()
        {
            return cost.FinalPrice();
        }
        public string SetSpecification()
        {
            return $"{BurgerName}";
        }
    }
}

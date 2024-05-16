using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab1
{
    public class AddSalad : ConfigBurger
    {
        public AddSalad(Burger burger) : base(burger)
        {

        }

        public override string SetSpecification()
        {
            return base.SetSpecification() + " с дополнительным Салатом";
        }

        public override double SetPrice()
        {
            return base.SetPrice() * 1.3;
        }
    }
}

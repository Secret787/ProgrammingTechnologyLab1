using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab1
{
    public class AddCutlet : ConfigBurger
    {
        public AddCutlet(Burger burger) : base(burger) 
        {

        }

        public override string SetSpecification()
        {
            return base.SetSpecification() + " с дополнительной котлетой";
        }

        public override double SetPrice()
        {
            return base.SetPrice()*1.2; 
        }
    }
}

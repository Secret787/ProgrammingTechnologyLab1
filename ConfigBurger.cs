using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingTechnologyLab1
{
    public abstract class ConfigBurger : Burger
    {
        protected Burger _ConfigBurger;

        public ConfigBurger(Burger burger) 
        {
            this._ConfigBurger = burger;
        }

        public virtual string SetSpecification()
        {
            return _ConfigBurger.SetSpecification();
        }

        public virtual double SetPrice() 
        {
            return _ConfigBurger.SetPrice();
        }
    }
}

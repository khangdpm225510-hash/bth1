using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld
{
    public abstract class Beverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }
        protected void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        protected void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        protected abstract void Brew();             
        protected abstract void AddCondiments();
    }
}

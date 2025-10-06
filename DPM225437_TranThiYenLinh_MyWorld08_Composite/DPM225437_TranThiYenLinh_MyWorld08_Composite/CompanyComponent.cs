using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld08_Composite
{
    public abstract class CompanyComponent
    {
        protected string name;

        public CompanyComponent(string name)
        {
            this.name = name;
        }

        public abstract void Add(CompanyComponent c);
        public abstract void Remove(CompanyComponent c);
        public abstract void Display(int depth);
    }
}

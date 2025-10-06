using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    /// <summary>
    /// The 'Creator' abstract class
    /// </summary>
    internal abstract class Creator
    {
        public abstract Product FactoryMethod();
    }
}

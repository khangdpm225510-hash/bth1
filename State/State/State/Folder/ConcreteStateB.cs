using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

public class ConcreteStateB : Statee
{
    public override void Handle(Context context)
    {
        context.State = new ConcreteStateA();
    }
}

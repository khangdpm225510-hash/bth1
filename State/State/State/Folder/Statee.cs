using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

public abstract class Statee
{
    public abstract void Handle(Context context);
}


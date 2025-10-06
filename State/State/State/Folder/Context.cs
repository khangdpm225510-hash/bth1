using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Context
{
    Statee state;
    // Constructor
    public Context(Statee state)
    {
        this.State = state;
    }
    // Gets or sets the state
    public Statee State
    {
        get { return state; }
        set
        {
            state = value;
            Console.WriteLine("Statee: " + state.GetType().Name);
        }
    }
    public void Request()
    {
        state.Handle(this);
    }
}


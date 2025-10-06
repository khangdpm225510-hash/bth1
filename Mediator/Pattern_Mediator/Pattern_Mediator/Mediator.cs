namespace Pattern_Mediator
{
   
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}

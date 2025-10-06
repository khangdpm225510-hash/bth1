using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern19_observer
{
    namespace pattern19_observer
    {
        public class ConcreteObserver : Observer
        {
            private string name;
            private string observerState;
            private ConcreteSubject subject;

            // ✅ Constructor nhận 2 tham số (ConcreteSubject, string)
            public ConcreteObserver(ConcreteSubject subject, string name)
            {
                this.subject = subject;
                this.name = name;
            }

            public override void Update()
            {
                observerState = subject.SubjectState;
                Console.WriteLine("Observer {0}'s new state is {1}", name, observerState);
            }

            public ConcreteSubject Subject
            {
                get { return subject; }
                set { subject = value; }
            }
        }
    }
}
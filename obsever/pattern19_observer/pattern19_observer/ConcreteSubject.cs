using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern19_observer
{
    namespace pattern19_observer
    {
        public class ConcreteSubject : Subject
        {
            private string subjectState = string.Empty; // tránh lỗi CS8618

            public string SubjectState
            {
                get { return subjectState; }
                set { subjectState = value; }
            }
        }
    }
}

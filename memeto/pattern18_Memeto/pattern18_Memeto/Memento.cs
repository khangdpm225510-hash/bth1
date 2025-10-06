using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern18_Memeto
{
    namespace pattern18_Memeto
    {
        // để public cho các class khác truy cập
        public class Memento
        {
            private string state;

            // Constructor
            public Memento(string state)
            {
                this.state = state;
            }

            // Chỉ cho phép đọc trạng thái, không cho sửa
            public string State
            {
                get { return state; }
            }
        }
    }

}

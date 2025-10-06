using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld08_Composite
{
    public class Employee : CompanyComponent
    {
        public Employee(string name) : base(name) { }

        public override void Add(CompanyComponent c)
        {
            Console.WriteLine("Không thể thêm vào nhân viên.");
        }

        public override void Remove(CompanyComponent c)
        {
            Console.WriteLine("Không thể xóa trong nhân viên.");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + " Nhân viên: " + name);
        }
    }
}
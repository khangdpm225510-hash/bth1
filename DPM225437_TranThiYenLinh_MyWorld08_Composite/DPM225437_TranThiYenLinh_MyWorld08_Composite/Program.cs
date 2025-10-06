using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225437_TranThiYenLinh_MyWorld08_Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Department company = new Department("Công ty ABC");

            // Thêm phòng ban IT
            Department itDept = new Department("Phòng IT");
            itDept.Add(new Employee("Nguyễn Văn A"));
            itDept.Add(new Employee("Trần Thị B"));

            // Thêm phòng ban Kinh doanh
            Department salesDept = new Department("Phòng Kinh doanh");
            salesDept.Add(new Employee("Lê Văn C"));
            salesDept.Add(new Employee("Phạm Thị D"));

            // Thêm phòng ban con vào công ty
            company.Add(itDept);
            company.Add(salesDept);

            // Hiển thị cấu trúc công ty
            company.Display(1);

            Console.ReadKey();
        }
    }
}

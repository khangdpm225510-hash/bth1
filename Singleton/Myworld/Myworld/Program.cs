using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld
{

    public class Program
    {
        public static void Main(string[] args)
        {
            // Tat ca hoc vien deu su dung cung 1 trung tam cau hoi
            QuestionCenter center1 = QuestionCenter.GetInstance();
            QuestionCenter center2 = QuestionCenter.GetInstance();

            if (center1 == center2)
            {
                Console.WriteLine("Chi co 1 trung tam cau hoi duoc tao ra\n");
            }

            // Tao hoc vien va gui cau hoi
            Student s1 = new Student("An");
            Student s2 = new Student("Binh");
            Student s3 = new Student("Cuong");

            s1.SendQuestion("AI la gi?");
            s2.SendQuestion("C# va Java khac nhau the nao?");
            s3.SendQuestion("OOP co nhung dac tinh gi?");

            // Giang vien nhan va tra loi
            Teacher teacher = new Teacher("Thay Nguyen");
            teacher.AnswerQuestions();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld
{
    public class Student
    {
        private string name;

        public Student(string name)
        {
            this.name = name;
        }

        public void SendQuestion(string question)
        {
            QuestionCenter center = QuestionCenter.GetInstance();
            center.AddQuestion($"{name} hoi: {question}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld
{
    public class Teacher
    {
        private string name;

        public Teacher(string name)
        {
            this.name = name;
        }

        public void AnswerQuestions()
        {
            QuestionCenter center = QuestionCenter.GetInstance();
            foreach (var q in center.GetQuestions())
            {
                Console.WriteLine($"{name} tra loi: {q}");
            }
        }
    }
}

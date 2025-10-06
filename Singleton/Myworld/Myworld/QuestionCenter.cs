using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myworld
{
    public class QuestionCenter
    {
        private static QuestionCenter instance;
        private static readonly object locker = new object();

        private List<string> questions = new List<string>();

        // Constructor private
        private QuestionCenter() { }

        public static QuestionCenter GetInstance()
        {
            if (instance == null)
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new QuestionCenter();
                    }
                }
            }
            return instance;
        }

        // Them cau hoi
        public void AddQuestion(string question)
        {
            questions.Add(question);
            Console.WriteLine("Them cau hoi: " + question);
        }

        // Lay danh sach cau hoi
        public List<string> GetQuestions()
        {
            return questions;
        }
    }
}

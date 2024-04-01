using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract4WPF
{
    public class TestClass
    {
        public string name { get; set; }
        public string description { get; set; }
        public string question1 { get; set; }
        public string question2 { get; set; }
        public string question3 { get; set; }
        public AnswerEnum user_answer { get; set; }

        public TestClass(string name, string description, string question1, string question2, string question3, AnswerEnum user_answer)
        {
            this.name = name;
            this.description = description;
            this.question1 = question1;
            this.question2 = question2;
            this.question3 = question3;
            this.user_answer = user_answer;
        }
    }
}

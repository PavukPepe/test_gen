using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests_gen
{

    enum Answers
    {
        Первый = 1,
        Второй = 2,
        Третий = 3,
    }
    internal class Question
    {
        public string name { get; set; }
        public string description { get; set; }
        public string answer_1 { get; set; }
        public string answer_2 { get; set; }
        public string answer_3 { get; set; }
        public Answers right_answ { get; set; }

    }
}

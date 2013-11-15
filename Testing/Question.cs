using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    class Question
    {
        string pict { get; set; }
        int glava { get; set; }
        int number { get; set; }
        List<string> Answers { get; set; }
        int rightanswer { get; set; }
        string vopros { get; set; }

        public void AddAnswers( List<string> list)
        {
            for (int i=0; i<list.Count;i++)
            {
                this.Answers.Add(list[i]); // будет ли работать с этим методом, или нужно прописать код в question
            }
        }

        public void question(string pct, int glv, int nmbr, string que, int right, List<string> str)
        {
            this.pict = pct;
            this.glava = glv;
            this.number = nmbr;
            this.rightanswer = right;
            this.vopros = que;
            this.Answers = new List<string>();
            AddAnswers(str);
            //AddAnswers(str);
            //for (int i = 0; i < str.Count; i++)
            //{
            //    this.Answers.Add(str[i]); // будет ли работать с этим методом, или нужно прописать код в question
            //}
        }
    }
}

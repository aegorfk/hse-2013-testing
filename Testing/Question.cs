using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    public class Question
    {
        string pict;

public string Pict
{
  get { return pict; }
  set { pict = value; }
}
        int glava;
        

public int Glava
{
  get { return glava; }
  set { glava = value; }
}
        int number;

public int Number
{
    get { return number; }
    set { number = value; }
}
        List<string> Answers;

public List<string> answers
{
    get { return Answers; }
    set { Answers = value; }
}
        int rightanswer;

public int Rightanswer
{
    get { return rightanswer; }
    set { rightanswer = value; }
}
        string vopros;

public string Vopros
{
    get { return vopros; }
    set { vopros = value; }
}

        public void AddAnswers( List<string> list)
        {
            for (int i=0; i<list.Count;i++)
            {
                this.Answers.Add(list[i]);
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
        }
    }
}

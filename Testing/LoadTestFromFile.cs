using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    class LoadTestFromFile
    {
        public List<Question> Questions = new List<Question>();
        public bool run(System.IO.StreamReader input)
        {
            if (input != null)
            {
                try
                {
                    loadDataFromFile(input);
                }
                catch { return false; }
                return true;
            }
            return false;
        }

        private void loadDataFromFile(System.IO.StreamReader input)
        {
            int number=0, glava=0, right=0, i=0;
            string vopros="", pict="", check = "/";
            // до этого, создание листа было вот тут, но тогда в нём были ВООБЩЕ ВСЕ эелементы, они не обнулялись от объекта к объекту (
            while (!input.EndOfStream)
            {
                List<string> strg = new List<string>(); // как видно, тут он создаётся при каждом считывании строки
                //но тогда при переходе от 5-ой к 6-ой строке он, собственно, обнуляется. Помогите Т_Т
                string str = input.ReadLine();
                if (i==0)
                {
                    pict = str;
                }
                if (i == 1)
                {
                    glava = Int32.Parse(str);
                }
                if (i == 2)
                {
                    number = Int32.Parse(str);
                }
                if (i == 3)
                {
                    vopros = str;
                }
                if (i == 4)
                {
                    // вот тут бы его создавать (чтобы он обнулялся только тогда, когда это нужно при считывании уже другого вопроса)
                    // но тогда проблемы с вызовом этого листа в следующем условии. Я не помню, как решать такие проблемы с разветвелнием if
                    // может тут switch нужен ??
                    char[] divider = new char[] { '&' };
                    string[] parts = str.Split(divider);
                    foreach (string w in parts)
                    {
                        strg.Add(w);
                    }
                }
                if (i == 5)
                {
                    // вот тут вызывается strg при создании объекта класса question, если создавать лист только в if (i == 4), то проблемы с обращением к нему тут.
                    right = Int32.Parse(str);
                    Question qv = new Question();
                    qv.question(pict, glava, number, vopros, right, strg);
                    Questions.Add(qv);
                }
                i++;
                if (str == check) { i = 0; }
            }
        }
    }
}

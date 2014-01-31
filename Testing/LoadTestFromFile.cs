using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    class LoadTestFromFile
    {
        public static List<Question> Questions = new List<Question>(); 
        public static string Path;
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
            List<string> strg = new List<string>();
            while (!input.EndOfStream)
            {
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
                    char[] divider = new char[] { '&' };
                    string[] parts = str.Split(divider);
                    foreach (string w in parts)
                    {
                        strg.Add(w);
                    }
                }
                if (i == 5)
                {
                    right = Int32.Parse(str);
                    Question qv = new Question();
                    qv.question(pict, glava, number, vopros, right, strg);
                    Questions.Add(qv);
                    strg.Clear();
                }
                i++;
                if (str == check) { i = 0; }
            }
        }
    }
}

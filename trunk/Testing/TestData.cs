using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    class TestData
    {
        public static string SwitchPicture(Question Q)
        {
            string path = LoadTestFromFile.Path + "\\" + Q.Pict + ".jpg";
            return path;
        }

        public static int Glav()
        {
            int glav = 0;
            foreach (Question Q in LoadTestFromFile.Questions)
            {
                if (Q.Glava > glav) glav = Q.Glava;
            }
            return glav;
        }

        public static string Result()
        {
            int verno = 0;
            for (int j = 0; j < Test.VoprosiTesta.Count(); j++)
            {
                if (Test.VoprosiTesta[j].Rightanswer == Test.ChosenAnswers[j]) verno++;
            }
            double percent = (((double) verno / (double) Test.VoprosiTesta.Count()) * 100.0);
            string str = Math.Round(percent, 0).ToString();
            return str;
        }
    }
}

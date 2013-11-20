using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Testing
{
    public partial class Test : Form
    {
        public static List<Question> VoprosiTesta = new List<Question>(); // здесь записаны вопросы, которые пройдены
        public static List<int> ChosenAnswers = new List<int>(); // здесь записаны данные пользователем ответы
        int i = 1; // кол-во вопросов в тесте (кол-во глав)
        public Test()
        {
            InitializeComponent();
            SwitchToNext();
        }

        private void SwitchToNext()
        {
            if (i <= TestData.Glav())
            {
                try
                {
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    List<int> indexes = new List<int>();
                    List<string> otveti = new List<string>();
                    int MainIndex = 0;
                    foreach (Question Q in LoadTestFromFile.Questions)
                    {
                        if (Q.Glava == i)
                        {
                            indexes.Add(MainIndex);
                        }
                        MainIndex++;
                    }
                    Random g = new Random();
                    int index = g.Next(indexes.Count);
                    VoprosiTesta.Add(LoadTestFromFile.Questions[indexes[index]]);
                    Question q = LoadTestFromFile.Questions[indexes[index]];
                    pictureBox1.ImageLocation = TestData.SwitchPicture(q);
                    label1.Text = q.Vopros;
                    otveti = q.answers;
                    int HowMuch = otveti.Count;
                    radioButton1.Text = otveti[0];
                    radioButton2.Text = otveti[1];
                    if (HowMuch >= 3) { radioButton3.Text = otveti[2]; radioButton3.Visible = true; }
                    if (HowMuch >= 4) { radioButton4.Text = otveti[3]; radioButton4.Visible = true; }
                    if (HowMuch == 5) { radioButton5.Text = otveti[4]; radioButton5.Visible = true; }
                    i++;
                }
                catch { MessageBox.Show("произошла ошибка при обработке теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { Result r = new Result(); r.ShowDialog(); this.Close(); }
        }

        private void Answering()
        {
            if (radioButton1.Checked == true) ChosenAnswers.Add(0);
            if (radioButton2.Checked == true) ChosenAnswers.Add(1);
            if (radioButton3.Checked == true) ChosenAnswers.Add(2);
            if (radioButton4.Checked == true) ChosenAnswers.Add(3);
            if (radioButton5.Checked == true) ChosenAnswers.Add(4);
        }
        private void ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nx_Click(object sender, EventArgs e)
        {
            Answering();
            SwitchToNext();
        }
    }
}

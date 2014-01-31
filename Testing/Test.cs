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
        public static string testID;
        public static List<Question> VoprosiTesta = new List<Question>(); // здесь записаны вопросы, которые пройдены
        public static List<int> ChosenAnswers = new List<int>(); // здесь записаны данные пользователем ответы
        int i = 1; // кол-во вопросов в тесте (кол-во глав)
        bool otlozheno = false;
        int otlozhen=0;
        int right = 0;

        public static string getID() {return testID;}
        public void setID(string id) {testID = id;}

        public Test()
        {
            InitializeComponent();
            if (MainForm.CreateTest == false)
                SwitchToNext();
            else 
            {
                pictureBox1.Visible = false;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                ps.Text = "Сохранить тест";
                ps.Enabled = false;
            }
        }

        private bool IsNotItEmpty(TextBox t)
        {
            if (t.Text != "") return true;
            else return false;
        }

        private bool TextsAreOK()
        {

            if (textBox5.Text != "")
            {
                if (textBox4.Text == "") return false;
            }
            if (textBox6.Text != "")
            {
                if (textBox4.Text == "" || textBox5.Text == "") return false;
            }
            return true;
        }

        private bool Parsable()
        {
            try
            {
                int i = int.Parse(textBox8.Text);
                return true;
            }
            catch { return false; }
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
            else 
            {
                ps.Enabled = false;
                otlozheno = false;
                int indexVliste = 0;
                foreach (int p in ChosenAnswers)
                {
                    if (p == 7) { otlozheno = true; otlozhen = indexVliste; break; }
                    indexVliste++;
                }
                if (otlozheno == false)
                {
                    Result r = new Result(); 
                    r.ShowDialog(); 
                    this.Close();
                }
                else
                {
                    radioButton3.Visible = false;
                    radioButton4.Visible = false;
                    radioButton5.Visible = false;
                    List<string> otveti = new List<string>();
                    Question q = VoprosiTesta[otlozhen];
                    pictureBox1.ImageLocation = TestData.SwitchPicture(q);
                    label1.Text = q.Vopros;
                    otveti = q.answers;
                    int HowMuch = otveti.Count;
                    radioButton1.Text = otveti[0];
                    radioButton2.Text = otveti[1];
                    if (HowMuch >= 3) { radioButton3.Text = otveti[2]; radioButton3.Visible = true; }
                    if (HowMuch >= 4) { radioButton4.Text = otveti[3]; radioButton4.Visible = true; }
                    if (HowMuch == 5) { radioButton5.Text = otveti[4]; radioButton5.Visible = true; }
                }
            }
        }

        private void Answering()
        {
            if (MainForm.CreateTest == false)
            {
                if (otlozheno == false)
                {
                    if (radioButton1.Checked == true) ChosenAnswers.Add(0);
                    if (radioButton2.Checked == true) ChosenAnswers.Add(1);
                    if (radioButton3.Checked == true) ChosenAnswers.Add(2);
                    if (radioButton4.Checked == true) ChosenAnswers.Add(3);
                    if (radioButton5.Checked == true) ChosenAnswers.Add(4);
                }
                else
                {
                    if (radioButton1.Checked == true) { ChosenAnswers.RemoveAt(otlozhen); ChosenAnswers.Insert(otlozhen, 0); }
                    if (radioButton2.Checked == true) { ChosenAnswers.RemoveAt(otlozhen); ChosenAnswers.Insert(otlozhen, 1); }
                    if (radioButton3.Checked == true) { ChosenAnswers.RemoveAt(otlozhen); ChosenAnswers.Insert(otlozhen, 2); }
                    if (radioButton4.Checked == true) { ChosenAnswers.RemoveAt(otlozhen); ChosenAnswers.Insert(otlozhen, 3); }
                    if (radioButton5.Checked == true) { ChosenAnswers.RemoveAt(otlozhen); ChosenAnswers.Insert(otlozhen, 4); }
                }
            }
            else
            {
                if (radioButton1.Checked == true) right = 0;
                if (radioButton2.Checked == true) right = 1;
                if (radioButton3.Checked == true) right = 2;
                if (radioButton4.Checked == true) right = 3;
                if (radioButton5.Checked == true) right = 4;
            }
        }
        private void ex_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nx_Click(object sender, EventArgs e)
        {
            if (MainForm.CreateTest == true)
            {
                if (
                        textBox1.Text != "" && textBox2.Text != "" & textBox3.Text != "" && textBox7.Text != "" && textBox8.Text != ""
                        && ( radioButton1.Checked == true || radioButton2.Checked == true || (radioButton3.Checked == IsNotItEmpty(textBox4)) || (radioButton4.Checked == IsNotItEmpty(textBox4) && radioButton4.Checked == IsNotItEmpty(textBox5)) || (radioButton5.Checked == IsNotItEmpty(textBox4) && radioButton5.Checked == IsNotItEmpty(textBox5) && radioButton5.Checked == IsNotItEmpty(textBox6)))
                        && TextsAreOK() == true && Parsable()
                   )
                {
                    try
                    {
                        int nomer = 0;
                        Question q = new Question();
                        foreach (Question p in LoadTestFromFile.Questions)
                        {
                            if (p.Glava == int.Parse(textBox8.Text))
                            {
                                if (nomer < p.Number) nomer = p.Number;
                            }
                        }
                        List<string> str = new List<string>() { textBox2.Text, textBox3.Text };
                        if (textBox4.Text != "") str.Add(textBox4.Text);
                        if (textBox5.Text != "") str.Add(textBox5.Text);
                        if (textBox6.Text != "") str.Add(textBox6.Text);
                        Answering();
                        q.question(textBox7.Text, int.Parse(textBox8.Text), nomer, textBox1.Text, right, str);
                        LoadTestFromFile.Questions.Add(q);
                        textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = "";
                        ps.Enabled = true;
                    }
                    catch { MessageBox.Show("Произошла неизвестная ошибка при создании вопроса. Она даже попала в трайкэтч, проверьте всё ради бога!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else MessageBox.Show("Произошла ошибка при создании вопроса. Пожалуйста, проверьте вводимые значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Answering();
                SwitchToNext();
            }
        }

        private void ps_Click(object sender, EventArgs e)
        {
            if (MainForm.CreateTest == false)
            {
                ChosenAnswers.Add(7);
                SwitchToNext();
            }
            else
            {
                SaveTestToFile data = new SaveTestToFile();
                SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                SaveFileDialog1.Filter = "Text file|*.txt";
                if (SaveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    System.IO.FileStream fs = (System.IO.FileStream)SaveFileDialog1.OpenFile();
                    if (data.Write(fs))
                    {
                        MessageBox.Show("Сохранение прошло успешно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Сохранение не удалось", "Неудача", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }
    }
}

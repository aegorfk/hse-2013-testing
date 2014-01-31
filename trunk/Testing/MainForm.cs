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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        LoadTestFromFile Data = new LoadTestFromFile();
        public static bool CreateTest = false;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                       System.IO.StreamReader(openFileDialog1.FileName, Encoding.Default);
                if (Data.run(sr))
                {
                    button1.Enabled = true;
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    fbd.Description = "Укажите папку с иллюстрациями к тесту";
                    fbd.ShowNewFolderButton = false;
                    if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        LoadTestFromFile.Path = fbd.SelectedPath;
                    }
                }
                else MessageBox.Show("Произошла ошибка при загрузке. Проверьте, что файл имеет расширение .txt", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Вы уверены, что хотите выйти?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateTest = false;
            Test.VoprosiTesta.Clear();
            checkin checkin = new checkin();
            checkin.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CreateTest = true;
            List<Question> support = LoadTestFromFile.Questions;
            LoadTestFromFile.Questions.Clear();
            Test test = new Test();
            test.ShowDialog();
            LoadTestFromFile.Questions = support;
            support.Clear();
        }

        private void информацияОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.ShowDialog();
        }

        private void перейтиНаСайтГАИToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string websiteName = "http://gai.ru/"; 
            System.Diagnostics.Process.Start("iexplore.exe", websiteName);
        }

        private void дорожныеЗнакиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string websiteName = "http://gai.ru/voditelskoe-udostoverenie/dorojnyie-znaki/"; 
            System.Diagnostics.Process.Start("iexplore.exe", websiteName);
        }

        private void правилаЭксплуатцииТСToolStripMenuItem_Click(object sender, EventArgs e)
        {
        string websiteName = "http://xn--80aaagl8ahknbd5b5e.xn--p1ai/tema-25-neispravnosti-i-usloviya-pri-kotoryx-zapreshhaetsya-ekspluatacziya-transportnyx-sredstv"; 
            System.Diagnostics.Process.Start("iexplore.exe", websiteName);
        }

        private void перваяПомощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
        string websiteName = "http://www.1st-aid.ru/"; 
            System.Diagnostics.Process.Start("iexplore.exe", websiteName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string websiteName = "http://hsetesting.url.ph/";
            System.Diagnostics.Process.Start("iexplore.exe", websiteName);
        }
        }
    }


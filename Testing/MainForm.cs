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
            Test test = new Test();
            test.ShowDialog();
        }
    }
}

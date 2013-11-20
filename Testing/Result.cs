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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
            int percent = int.Parse(TestData.Result());
            label1.Text = percent.ToString() + "%";
            if (percent >= 90) { label2.Text = "Вы сдали тест!"; label2.ForeColor = System.Drawing.Color.Green; label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))); }
            else { label2.Text = "Тест не сдан!"; label2.ForeColor = System.Drawing.Color.Red; label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))); }
            Test.ChosenAnswers.Clear(); Test.VoprosiTesta.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

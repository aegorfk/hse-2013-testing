using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
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
            if (percent >= 90) { 
                label2.Text = "Вы сдали тест!"; label2.ForeColor = System.Drawing.Color.Green; label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))); 
            }
            else { 
                label2.Text = "Тест не сдан!"; label2.ForeColor = System.Drawing.Color.Red; label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))); 
            }
            
            string finish = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            getUrl("http://hsetesting.url.ph/", "method=update&id="+ Test.getID() +"&finish="+finish+"&result="+percent.ToString() );

            Test.ChosenAnswers.Clear(); 
            Test.VoprosiTesta.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getUrl(string Url, string Data)
        {
            WebRequest req = WebRequest.Create(Url + "?" + Data);
            WebResponse resp = req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string Out = sr.ReadToEnd();
            sr.Close();
            return Out;
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }
    }
}

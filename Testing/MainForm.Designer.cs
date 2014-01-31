namespace Testing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.перейтиНаСайтГАИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.допМатериалыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дорожныеЗнакиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правилаЭксплуатцииТСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перваяПомощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.информацияОПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(137, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(137, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Выйти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(137, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Выбрать тест";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(137, 157);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 32);
            this.button4.TabIndex = 4;
            this.button4.Text = "Создать тест";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перейтиНаСайтГАИToolStripMenuItem,
            this.допМатериалыToolStripMenuItem,
            this.информацияОПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(437, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // перейтиНаСайтГАИToolStripMenuItem
            // 
            this.перейтиНаСайтГАИToolStripMenuItem.Name = "перейтиНаСайтГАИToolStripMenuItem";
            this.перейтиНаСайтГАИToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.перейтиНаСайтГАИToolStripMenuItem.Text = "Перейти на сайт ГАИ";
            this.перейтиНаСайтГАИToolStripMenuItem.Click += new System.EventHandler(this.перейтиНаСайтГАИToolStripMenuItem_Click);
            // 
            // допМатериалыToolStripMenuItem
            // 
            this.допМатериалыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дорожныеЗнакиToolStripMenuItem,
            this.правилаЭксплуатцииТСToolStripMenuItem,
            this.перваяПомощьToolStripMenuItem});
            this.допМатериалыToolStripMenuItem.Name = "допМатериалыToolStripMenuItem";
            this.допМатериалыToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.допМатериалыToolStripMenuItem.Text = "Доп. материалы";
            // 
            // дорожныеЗнакиToolStripMenuItem
            // 
            this.дорожныеЗнакиToolStripMenuItem.Name = "дорожныеЗнакиToolStripMenuItem";
            this.дорожныеЗнакиToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.дорожныеЗнакиToolStripMenuItem.Text = "Дорожные знаки";
            this.дорожныеЗнакиToolStripMenuItem.Click += new System.EventHandler(this.дорожныеЗнакиToolStripMenuItem_Click);
            // 
            // правилаЭксплуатцииТСToolStripMenuItem
            // 
            this.правилаЭксплуатцииТСToolStripMenuItem.Name = "правилаЭксплуатцииТСToolStripMenuItem";
            this.правилаЭксплуатцииТСToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.правилаЭксплуатцииТСToolStripMenuItem.Text = "Неисправности ТС";
            this.правилаЭксплуатцииТСToolStripMenuItem.Click += new System.EventHandler(this.правилаЭксплуатцииТСToolStripMenuItem_Click);
            // 
            // перваяПомощьToolStripMenuItem
            // 
            this.перваяПомощьToolStripMenuItem.Name = "перваяПомощьToolStripMenuItem";
            this.перваяПомощьToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.перваяПомощьToolStripMenuItem.Text = "Первая помощь";
            this.перваяПомощьToolStripMenuItem.Click += new System.EventHandler(this.перваяПомощьToolStripMenuItem_Click);
            // 
            // информацияОПрограммеToolStripMenuItem
            // 
            this.информацияОПрограммеToolStripMenuItem.Name = "информацияОПрограммеToolStripMenuItem";
            this.информацияОПрограммеToolStripMenuItem.Size = new System.Drawing.Size(169, 20);
            this.информацияОПрограммеToolStripMenuItem.Text = "Информация о программе";
            this.информацияОПрограммеToolStripMenuItem.Click += new System.EventHandler(this.информацияОПрограммеToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(137, 263);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(162, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "Результаты тестирования";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Testing.Properties.Resources.фон;
            this.ClientSize = new System.Drawing.Size(437, 350);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem перейтиНаСайтГАИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem информацияОПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem допМатериалыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дорожныеЗнакиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правилаЭксплуатцииТСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem перваяПомощьToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}
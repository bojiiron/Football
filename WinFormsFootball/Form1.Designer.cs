namespace WinFormsFootball
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new ComboBox();
            natbtn = new Button();
            playerbtn = new Button();
            playertbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dataGridView1 = new DataGridView();
            coachbtn = new Button();
            leaguebtn = new Button();
            label6 = new Label();
            button6 = new Button();
            label7 = new Label();
            button1 = new Button();
            textBox6 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Nationality", "Player", "Player Teams", "League", "Coach" });
            comboBox1.Location = new Point(10, 94);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // natbtn
            // 
            natbtn.Location = new Point(21, 435);
            natbtn.Margin = new Padding(3, 2, 3, 2);
            natbtn.Name = "natbtn";
            natbtn.Size = new Size(85, 22);
            natbtn.TabIndex = 1;
            natbtn.Text = "Nationality";
            natbtn.UseVisualStyleBackColor = true;
            natbtn.Click += button1_Click;
            // 
            // playerbtn
            // 
            playerbtn.Location = new Point(150, 435);
            playerbtn.Margin = new Padding(3, 2, 3, 2);
            playerbtn.Name = "playerbtn";
            playerbtn.Size = new Size(85, 22);
            playerbtn.TabIndex = 4;
            playerbtn.Text = "Player";
            playerbtn.UseVisualStyleBackColor = true;
            playerbtn.Click += button4_Click;
            // 
            // playertbtn
            // 
            playertbtn.Location = new Point(280, 435);
            playertbtn.Margin = new Padding(3, 2, 3, 2);
            playertbtn.Name = "playertbtn";
            playertbtn.Size = new Size(85, 22);
            playertbtn.TabIndex = 5;
            playertbtn.Text = "Player Team";
            playertbtn.UseVisualStyleBackColor = true;
            playertbtn.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(831, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 6;
            label1.Text = "Nationality";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(831, 76);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Player";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(831, 109);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 8;
            label3.Text = "Player Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(831, 139);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 9;
            label4.Text = "League";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(831, 174);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 10;
            label5.Text = "Coach";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(934, 37);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(934, 70);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 23);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(934, 104);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(934, 136);
            textBox4.Margin = new Padding(3, 2, 3, 2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(142, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(934, 170);
            textBox5.Margin = new Padding(3, 2, 3, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(142, 23);
            textBox5.TabIndex = 15;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(533, 243);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(565, 256);
            dataGridView1.TabIndex = 16;
            // 
            // coachbtn
            // 
            coachbtn.Location = new Point(21, 478);
            coachbtn.Margin = new Padding(3, 2, 3, 2);
            coachbtn.Name = "coachbtn";
            coachbtn.Size = new Size(85, 22);
            coachbtn.TabIndex = 17;
            coachbtn.Text = "Coach";
            coachbtn.UseVisualStyleBackColor = true;
            coachbtn.Click += button2_Click;
            // 
            // leaguebtn
            // 
            leaguebtn.Location = new Point(420, 435);
            leaguebtn.Margin = new Padding(3, 2, 3, 2);
            leaguebtn.Name = "leaguebtn";
            leaguebtn.Size = new Size(85, 22);
            leaguebtn.TabIndex = 18;
            leaguebtn.Text = "League";
            leaguebtn.UseVisualStyleBackColor = true;
            leaguebtn.Click += button3_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Segoe UI Symbol", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(280, -4);
            label6.Name = "label6";
            label6.Size = new Size(475, 86);
            label6.TabIndex = 19;
            label6.Text = "Football World";
            // 
            // button6
            // 
            button6.Location = new Point(420, 478);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(85, 22);
            button6.TabIndex = 20;
            button6.Text = "Exit";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(831, 212);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 21;
            label7.Text = "Team";
            // 
            // button1
            // 
            button1.Location = new Point(150, 478);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(85, 22);
            button1.TabIndex = 22;
            button1.Text = "Team";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(934, 206);
            textBox6.Margin = new Padding(3, 2, 3, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(142, 23);
            textBox6.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(230, 299);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(85, 22);
            button2.TabIndex = 24;
            button2.Text = "save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(420, 299);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(85, 22);
            button3.TabIndex = 25;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // button4
            // 
            button4.Location = new Point(10, 299);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(85, 22);
            button4.TabIndex = 26;
            button4.Text = "insert";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.Location = new Point(420, 341);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(85, 22);
            button5.TabIndex = 27;
            button5.Text = "Find";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1110, 510);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox6);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(label6);
            Controls.Add(leaguebtn);
            Controls.Add(coachbtn);
            Controls.Add(dataGridView1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(playertbtn);
            Controls.Add(playerbtn);
            Controls.Add(natbtn);
            Controls.Add(comboBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Button natbtn;
        private Button playerbtn;
        private Button playertbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DataGridView dataGridView1;
        private Button coachbtn;
        private Button leaguebtn;
        private Label label6;
        private Button button6;
        private Label label7;
        private Button button1;
        private TextBox textBox6;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}

namespace MathTeaching
{
    partial class MathTeaching
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            this.label1 = new System.Windows.Forms.Label();
            this.CbMathOption = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbTimeOption = new System.Windows.Forms.ComboBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnRestart = new System.Windows.Forms.Button();
            this.lblMathType = new System.Windows.Forms.Label();
            this.TbAnswer = new System.Windows.Forms.TextBox();
            this.lblNumberOne = new System.Windows.Forms.Label();
            this.lblNumberTwo = new System.Windows.Forms.Label();
            this.BtnValidate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSecondsLeft = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCorrectAnswerd = new System.Windows.Forms.Label();
            this.lblFalseAnswerd = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStreakAnswerd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CbMaxAttempts = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CbDifficulty = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(26, 130);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(58, 13);
            label3.TabIndex = 2;
            label3.Text = "Time Optie";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(26, 175);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(71, 13);
            label10.TabIndex = 2;
            label10.Text = "Max Attempts";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(23, 222);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(51, 13);
            label11.TabIndex = 2;
            label11.Text = "Diffuculty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Millionaire DEMO", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Problem";
            // 
            // CbMathOption
            // 
            this.CbMathOption.FormattingEnabled = true;
            this.CbMathOption.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Mulitiplication",
            "Division"});
            this.CbMathOption.Location = new System.Drawing.Point(26, 100);
            this.CbMathOption.Name = "CbMathOption";
            this.CbMathOption.Size = new System.Drawing.Size(144, 21);
            this.CbMathOption.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Math Optie";
            // 
            // CbTimeOption
            // 
            this.CbTimeOption.FormattingEnabled = true;
            this.CbTimeOption.Items.AddRange(new object[] {
            "240",
            "200",
            "160",
            "120",
            "80",
            "60",
            "40",
            "25",
            "10"});
            this.CbTimeOption.Location = new System.Drawing.Point(29, 148);
            this.CbTimeOption.Name = "CbTimeOption";
            this.CbTimeOption.Size = new System.Drawing.Size(144, 21);
            this.CbTimeOption.TabIndex = 1;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(29, 283);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(141, 103);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnRestart
            // 
            this.BtnRestart.Location = new System.Drawing.Point(29, 393);
            this.BtnRestart.Name = "BtnRestart";
            this.BtnRestart.Size = new System.Drawing.Size(141, 46);
            this.BtnRestart.TabIndex = 4;
            this.BtnRestart.Text = "Restart";
            this.BtnRestart.UseVisualStyleBackColor = true;
            this.BtnRestart.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // lblMathType
            // 
            this.lblMathType.AutoSize = true;
            this.lblMathType.Font = new System.Drawing.Font("Millionaire DEMO", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMathType.Location = new System.Drawing.Point(493, 111);
            this.lblMathType.Name = "lblMathType";
            this.lblMathType.Size = new System.Drawing.Size(57, 58);
            this.lblMathType.TabIndex = 5;
            this.lblMathType.Text = "?";
            // 
            // TbAnswer
            // 
            this.TbAnswer.Location = new System.Drawing.Point(370, 268);
            this.TbAnswer.Name = "TbAnswer";
            this.TbAnswer.Size = new System.Drawing.Size(340, 20);
            this.TbAnswer.TabIndex = 6;
            this.TbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TbAnswer_KeyDown);
            // 
            // lblNumberOne
            // 
            this.lblNumberOne.AutoSize = true;
            this.lblNumberOne.Font = new System.Drawing.Font("Millionaire DEMO", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOne.Location = new System.Drawing.Point(304, 130);
            this.lblNumberOne.Name = "lblNumberOne";
            this.lblNumberOne.Size = new System.Drawing.Size(50, 58);
            this.lblNumberOne.TabIndex = 5;
            this.lblNumberOne.Text = "-";
            this.lblNumberOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberTwo
            // 
            this.lblNumberTwo.AutoSize = true;
            this.lblNumberTwo.Font = new System.Drawing.Font("Millionaire DEMO", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTwo.Location = new System.Drawing.Point(645, 130);
            this.lblNumberTwo.Name = "lblNumberTwo";
            this.lblNumberTwo.Size = new System.Drawing.Size(50, 58);
            this.lblNumberTwo.TabIndex = 5;
            this.lblNumberTwo.Text = "-";
            this.lblNumberTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(370, 295);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(340, 23);
            this.BtnValidate.TabIndex = 7;
            this.BtnValidate.Text = "Validate";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(205, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 10);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Location = new System.Drawing.Point(202, -10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 478);
            this.panel2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Millionaire DEMO", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 44);
            this.label4.TabIndex = 10;
            this.label4.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seconds Left:";
            // 
            // lblSecondsLeft
            // 
            this.lblSecondsLeft.AutoSize = true;
            this.lblSecondsLeft.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondsLeft.Location = new System.Drawing.Point(464, 224);
            this.lblSecondsLeft.Name = "lblSecondsLeft";
            this.lblSecondsLeft.Size = new System.Drawing.Size(47, 29);
            this.lblSecondsLeft.TabIndex = 11;
            this.lblSecondsLeft.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(256, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Correct:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Firebrick;
            this.label7.Location = new System.Drawing.Point(256, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 29);
            this.label7.TabIndex = 11;
            this.label7.Text = "False:";
            // 
            // lblCorrectAnswerd
            // 
            this.lblCorrectAnswerd.AutoSize = true;
            this.lblCorrectAnswerd.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectAnswerd.ForeColor = System.Drawing.Color.Black;
            this.lblCorrectAnswerd.Location = new System.Drawing.Point(393, 382);
            this.lblCorrectAnswerd.Name = "lblCorrectAnswerd";
            this.lblCorrectAnswerd.Size = new System.Drawing.Size(26, 29);
            this.lblCorrectAnswerd.TabIndex = 11;
            this.lblCorrectAnswerd.Text = "0";
            // 
            // lblFalseAnswerd
            // 
            this.lblFalseAnswerd.AutoSize = true;
            this.lblFalseAnswerd.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalseAnswerd.ForeColor = System.Drawing.Color.Black;
            this.lblFalseAnswerd.Location = new System.Drawing.Point(393, 413);
            this.lblFalseAnswerd.Name = "lblFalseAnswerd";
            this.lblFalseAnswerd.Size = new System.Drawing.Size(26, 29);
            this.lblFalseAnswerd.TabIndex = 11;
            this.lblFalseAnswerd.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Goldenrod;
            this.label8.Location = new System.Drawing.Point(256, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Streak:";
            // 
            // lblStreakAnswerd
            // 
            this.lblStreakAnswerd.AutoSize = true;
            this.lblStreakAnswerd.Font = new System.Drawing.Font("Millionaire DEMO", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreakAnswerd.ForeColor = System.Drawing.Color.Black;
            this.lblStreakAnswerd.Location = new System.Drawing.Point(393, 346);
            this.lblStreakAnswerd.Name = "lblStreakAnswerd";
            this.lblStreakAnswerd.Size = new System.Drawing.Size(26, 29);
            this.lblStreakAnswerd.TabIndex = 11;
            this.lblStreakAnswerd.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Location = new System.Drawing.Point(205, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 10);
            this.panel3.TabIndex = 8;
            // 
            // CbMaxAttempts
            // 
            this.CbMaxAttempts.FormattingEnabled = true;
            this.CbMaxAttempts.Items.AddRange(new object[] {
            "100",
            "50",
            "20",
            "10",
            "5",
            "2",
            "1"});
            this.CbMaxAttempts.Location = new System.Drawing.Point(26, 191);
            this.CbMaxAttempts.Name = "CbMaxAttempts";
            this.CbMaxAttempts.Size = new System.Drawing.Size(144, 21);
            this.CbMaxAttempts.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CbDifficulty
            // 
            this.CbDifficulty.FormattingEnabled = true;
            this.CbDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Over 9000",
            "Super Sayen God Goku"});
            this.CbDifficulty.Location = new System.Drawing.Point(26, 238);
            this.CbDifficulty.Name = "CbDifficulty";
            this.CbDifficulty.Size = new System.Drawing.Size(144, 21);
            this.CbDifficulty.TabIndex = 1;
            // 
            // MathTeaching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 453);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblSecondsLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblFalseAnswerd);
            this.Controls.Add(this.lblStreakAnswerd);
            this.Controls.Add(this.lblCorrectAnswerd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnValidate);
            this.Controls.Add(this.TbAnswer);
            this.Controls.Add(this.lblNumberTwo);
            this.Controls.Add(this.lblNumberOne);
            this.Controls.Add(this.lblMathType);
            this.Controls.Add(this.BtnRestart);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(label11);
            this.Controls.Add(label10);
            this.Controls.Add(label3);
            this.Controls.Add(this.CbDifficulty);
            this.Controls.Add(this.CbMaxAttempts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbTimeOption);
            this.Controls.Add(this.CbMathOption);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MathTeaching";
            this.Opacity = 0.95D;
            this.Text = "Math Teaching";
            this.Load += new System.EventHandler(this.MathTeaching_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbMathOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbTimeOption;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnRestart;
        private System.Windows.Forms.Label lblMathType;
        private System.Windows.Forms.TextBox TbAnswer;
        private System.Windows.Forms.Label lblNumberOne;
        private System.Windows.Forms.Label lblNumberTwo;
        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSecondsLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCorrectAnswerd;
        private System.Windows.Forms.Label lblFalseAnswerd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblStreakAnswerd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CbMaxAttempts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox CbDifficulty;
    }
}


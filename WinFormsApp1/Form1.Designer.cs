namespace WinFormsApp1
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
            txtDisplay = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            btnToggleTheme = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            txtDisplay.Location = new Point(54, 32);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(639, 47);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            // 
            // button1
            // 
            button1.Location = new Point(60, 173);
            button1.Name = "button1";
            button1.Size = new Size(109, 54);
            button1.TabIndex = 1;
            button1.Tag = "1";
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnNumber_Click;
            // 
            // button2
            // 
            button2.Location = new Point(60, 233);
            button2.Name = "button2";
            button2.Size = new Size(109, 54);
            button2.TabIndex = 2;
            button2.Tag = "4";
            button2.Text = "4";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnNumber_Click;
            // 
            // button3
            // 
            button3.Location = new Point(175, 173);
            button3.Name = "button3";
            button3.Size = new Size(109, 54);
            button3.TabIndex = 3;
            button3.Tag = "2";
            button3.Text = "2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += BtnNumber_Click;
            // 
            // button4
            // 
            button4.Location = new Point(290, 173);
            button4.Name = "button4";
            button4.Size = new Size(109, 54);
            button4.TabIndex = 4;
            button4.Tag = "3";
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += BtnNumber_Click;
            // 
            // button5
            // 
            button5.Location = new Point(175, 233);
            button5.Name = "button5";
            button5.Size = new Size(109, 54);
            button5.TabIndex = 5;
            button5.Tag = "5";
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += BtnNumber_Click;
            // 
            // button6
            // 
            button6.Location = new Point(290, 233);
            button6.Name = "button6";
            button6.Size = new Size(109, 54);
            button6.TabIndex = 6;
            button6.Tag = "6";
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += BtnNumber_Click;
            // 
            // button7
            // 
            button7.Location = new Point(60, 293);
            button7.Name = "button7";
            button7.Size = new Size(109, 54);
            button7.TabIndex = 7;
            button7.Tag = "7";
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += BtnNumber_Click;
            // 
            // button8
            // 
            button8.Location = new Point(175, 293);
            button8.Name = "button8";
            button8.Size = new Size(109, 54);
            button8.TabIndex = 8;
            button8.Tag = "8";
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += BtnNumber_Click;
            // 
            // button9
            // 
            button9.Location = new Point(290, 293);
            button9.Name = "button9";
            button9.Size = new Size(109, 54);
            button9.TabIndex = 9;
            button9.Tag = "9";
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += BtnNumber_Click;
            // 
            // button0
            // 
            button0.Location = new Point(60, 353);
            button0.Name = "button0";
            button0.Size = new Size(224, 54);
            button0.TabIndex = 10;
            button0.Tag = "0";
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += BtnNumber_Click;
            // 
            // button11
            // 
            button11.Location = new Point(290, 353);
            button11.Name = "button11";
            button11.Size = new Size(109, 54);
            button11.TabIndex = 11;
            button11.Tag = ",";
            button11.Text = ",";
            button11.UseVisualStyleBackColor = true;
            button11.Click += BtnNumber_Click;
            // 
            // button12
            // 
            button12.Location = new Point(419, 173);
            button12.Name = "button12";
            button12.Size = new Size(109, 54);
            button12.TabIndex = 12;
            button12.Tag = "/";
            button12.Text = "/";
            button12.UseVisualStyleBackColor = true;
            button12.Click += BtnOperation_Click;
            // 
            // button13
            // 
            button13.Location = new Point(419, 233);
            button13.Name = "button13";
            button13.Size = new Size(109, 54);
            button13.TabIndex = 13;
            button13.Tag = "*";
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += BtnOperation_Click;
            // 
            // button14
            // 
            button14.Location = new Point(419, 293);
            button14.Name = "button14";
            button14.Size = new Size(109, 54);
            button14.TabIndex = 14;
            button14.Tag = "+";
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += BtnOperation_Click;
            // 
            // button15
            // 
            button15.Location = new Point(544, 263);
            button15.Name = "button15";
            button15.Size = new Size(109, 144);
            button15.TabIndex = 15;
            button15.Tag = "=";
            button15.Text = "=";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button16
            // 
            button16.Location = new Point(60, 94);
            button16.Name = "button16";
            button16.Size = new Size(109, 54);
            button16.TabIndex = 16;
            button16.Tag = "C";
            button16.Text = "C";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(419, 353);
            button17.Name = "button17";
            button17.Size = new Size(109, 54);
            button17.TabIndex = 17;
            button17.Tag = "-";
            button17.Text = "-";
            button17.UseVisualStyleBackColor = true;
            button17.Click += BtnOperation_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(188, 94);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 54);
            btnSave.TabIndex = 18;
            btnSave.Tag = "/";
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += button10_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(318, 94);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(109, 54);
            btnLoad.TabIndex = 19;
            btnLoad.Tag = "/";
            btnLoad.Text = "Загрузить";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += button18_Click;
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Location = new Point(452, 94);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(129, 54);
            btnToggleTheme.TabIndex = 20;
            btnToggleTheme.Tag = "/";
            btnToggleTheme.Text = "Сменить тему";
            btnToggleTheme.UseVisualStyleBackColor = true;
            btnToggleTheme.Click += button19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 452);
            Controls.Add(btnToggleTheme);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button btnSave;
        private Button btnLoad;
        private Button btnToggleTheme;
    }
}

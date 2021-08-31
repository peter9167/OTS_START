namespace OTS_Start
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HumVal = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.HumText = new System.Windows.Forms.Label();
            this.TempVal = new System.Windows.Forms.Label();
            this.TempText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.slbl_date = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.Font = new System.Drawing.Font("Gulim", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(257, 19);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(120, 5, 120, 5);
            this.label1.Size = new System.Drawing.Size(576, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "OTS 모니터링 장치";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.HumVal);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.HumText);
            this.groupBox1.Controls.Add(this.TempVal);
            this.groupBox1.Controls.Add(this.TempText);
            this.groupBox1.Font = new System.Drawing.Font("Gulim", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 470);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[실시간 데이터]";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(18, 421);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(69, 5, 69, 5);
            this.label11.Size = new System.Drawing.Size(164, 34);
            this.label11.TabIndex = 9;
            this.label11.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.MediumVioletRed;
            this.label10.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 383);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(2);
            this.label10.Size = new System.Drawing.Size(164, 28);
            this.label10.TabIndex = 8;
            this.label10.Text = "발생기실 순도";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(18, 340);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(69, 5, 69, 5);
            this.label9.Size = new System.Drawing.Size(164, 34);
            this.label9.TabIndex = 7;
            this.label9.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 303);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(2);
            this.label8.Size = new System.Drawing.Size(164, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "발생기실 순도";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(18, 257);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(69, 5, 69, 5);
            this.label6.Size = new System.Drawing.Size(164, 34);
            this.label6.TabIndex = 5;
            this.label6.Text = "0";
            // 
            // HumVal
            // 
            this.HumVal.BackColor = System.Drawing.Color.White;
            this.HumVal.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HumVal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HumVal.Location = new System.Drawing.Point(18, 172);
            this.HumVal.Margin = new System.Windows.Forms.Padding(0);
            this.HumVal.Name = "HumVal";
            this.HumVal.Size = new System.Drawing.Size(164, 34);
            this.HumVal.TabIndex = 4;
            this.HumVal.Text = "0";
            this.HumVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HumVal.Click += new System.EventHandler(this.HumVal_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 220);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(25, 2, 25, 2);
            this.label7.Size = new System.Drawing.Size(164, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "수조 온도";
            // 
            // HumText
            // 
            this.HumText.AutoSize = true;
            this.HumText.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.HumText.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HumText.ForeColor = System.Drawing.Color.White;
            this.HumText.Location = new System.Drawing.Point(18, 136);
            this.HumText.Name = "HumText";
            this.HumText.Padding = new System.Windows.Forms.Padding(2);
            this.HumText.Size = new System.Drawing.Size(164, 28);
            this.HumText.TabIndex = 2;
            this.HumText.Text = "발생기실 습도";
            // 
            // TempVal
            // 
            this.TempVal.BackColor = System.Drawing.Color.White;
            this.TempVal.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TempVal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TempVal.Location = new System.Drawing.Point(18, 88);
            this.TempVal.Margin = new System.Windows.Forms.Padding(0);
            this.TempVal.Name = "TempVal";
            this.TempVal.Size = new System.Drawing.Size(164, 34);
            this.TempVal.TabIndex = 1;
            this.TempVal.Text = "0";
            this.TempVal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TempVal.Click += new System.EventHandler(this.TempVal_Click);
            // 
            // TempText
            // 
            this.TempText.AutoSize = true;
            this.TempText.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.TempText.Font = new System.Drawing.Font("Headline R", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TempText.ForeColor = System.Drawing.Color.White;
            this.TempText.Location = new System.Drawing.Point(18, 52);
            this.TempText.Name = "TempText";
            this.TempText.Padding = new System.Windows.Forms.Padding(2);
            this.TempText.Size = new System.Drawing.Size(164, 28);
            this.TempText.TabIndex = 0;
            this.TempText.Text = "발생기실 온도";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button1.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(255, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 110);
            this.button1.TabIndex = 4;
            this.button1.Text = "작업시작";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button2.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(255, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 110);
            this.button2.TabIndex = 5;
            this.button2.Text = "작업종료";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(255, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 110);
            this.button3.TabIndex = 6;
            this.button3.Text = "OTS배드";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button4.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(371, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 110);
            this.button4.TabIndex = 7;
            this.button4.Text = "기본점검";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.OliveDrab;
            this.button5.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(487, 140);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 110);
            this.button5.TabIndex = 8;
            this.button5.Text = "헤파교체";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CadetBlue;
            this.button6.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(603, 140);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 110);
            this.button6.TabIndex = 9;
            this.button6.Text = "DO체크";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Indigo;
            this.button7.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(723, 140);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(110, 110);
            this.button7.TabIndex = 10;
            this.button7.Text = "콤프교체";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button8.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(371, 256);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(110, 110);
            this.button8.TabIndex = 11;
            this.button8.Text = "정기점검";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.OliveDrab;
            this.button9.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(487, 256);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(110, 110);
            this.button9.TabIndex = 12;
            this.button9.Text = "수분교체";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.CadetBlue;
            this.button10.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(603, 256);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(110, 110);
            this.button10.TabIndex = 13;
            this.button10.Text = "장비청소";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Indigo;
            this.button11.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(723, 256);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(110, 110);
            this.button11.TabIndex = 14;
            this.button11.Text = "콤프수리";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.MidnightBlue;
            this.button12.Font = new System.Drawing.Font("Gulim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(371, 372);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 110);
            this.button12.TabIndex = 15;
            this.button12.Text = "선바이배드";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.MidnightBlue;
            this.button13.Font = new System.Drawing.Font("Gulim", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(487, 372);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(110, 110);
            this.button13.TabIndex = 16;
            this.button13.Text = "옥서스배드";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button14.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button14.ForeColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(603, 372);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(110, 110);
            this.button14.TabIndex = 17;
            this.button14.Text = "옵션1";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button15.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button15.ForeColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(723, 372);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(110, 110);
            this.button15.TabIndex = 18;
            this.button15.Text = "옵션2";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // slbl_date
            // 
            this.slbl_date.BackColor = System.Drawing.Color.White;
            this.slbl_date.Font = new System.Drawing.Font("Headline R", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.slbl_date.Location = new System.Drawing.Point(349, 80);
            this.slbl_date.Name = "slbl_date";
            this.slbl_date.Size = new System.Drawing.Size(413, 42);
            this.slbl_date.TabIndex = 19;
            this.slbl_date.Text = "0";
            this.slbl_date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.slbl_date.Click += new System.EventHandler(this.slbl_date_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 494);
            this.Controls.Add(this.slbl_date);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label TempText;
        private System.Windows.Forms.Label TempVal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label HumText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label HumVal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label slbl_date;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
    }
}


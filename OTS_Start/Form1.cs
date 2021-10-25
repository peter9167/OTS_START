using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Timers;

namespace OTS_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

            //serialPort1.PortName = "COM7";
            //serialPort1.Open();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
            timer1.Interval = 500; //스케쥴 간격을 0.5초로 준 것이다.
            timer1.Start(); //타이머를 발동시킨다.
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void slbl_date_Click(object sender, EventArgs e)
        {

        }

        private void TempVal_Click(object sender, EventArgs e)
        {
                //string rawdata = serialPort1.ReadLine();

                //string[] data = rawdata.Split(',');
                //TempVal.Text = data[0] + "'c";
        }

        private void HumVal_Click(object sender, EventArgs e)
        {
                //string rawdata = serialPort1.ReadLine();

                //string[] data = rawdata.Split(',');
                //HumVal.Text = data[1] + "%";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
        }
        private void Temp_Print()
        {
            //string rawdata = serialPort1.ReadLine();
            //string[] data = rawdata.Split(',');
            //TempVal.Text = data[0] + "'c";
        }

        private void Hum_Print()
        {
            //string rawdata = serialPort1.ReadLine();
            //string[] data = rawdata.Split(',');
            //HumVal.Text = data[1] + "%";
        }

        private void slbl_date_Print()
        {
            //string nowTime = DateTime.Now.ToString();

            //slbl_date.Text = nowTime;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //slbl_date_Print();
            //Temp_Print();
            //Hum_Print();
        }
    }
}

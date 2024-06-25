using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RobotControl;
using System.Net.Sockets;
using System.Configuration;


namespace Robot_Application
{
    public partial class Form1 : Form
    {

        BrookRobot robot;
        public Form1()
        {
            InitializeComponent();
            robot = new BrookRobot();

            string ip = ConfigurationSettings.AppSettings.Get("ipInfo");
            int port = int.Parse(ConfigurationSettings.AppSettings.Get("portInfo"));
            int retries = int.Parse(ConfigurationSettings.AppSettings.Get("retry"));

            robot.IpAddress = ip;
            robot.Port = port;
            robot.retries = retries;
            robot.RobotStateChanged += robotStateHandler;

            string msg = string.Empty;
            if (robot.createConnection(ref msg))
            {
            }
            else
            {
                MessageBox.Show(msg);
            }
            
        }

        private void robotStateHandler(bool state)
        {
            if (state == false)
            {
                MessageBox.Show("Disconnected");
            }
        }


        private void upButton_Click(object sender, EventArgs e)
        {
            try
            {
                robot.Up();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            try
            {
                robot.Down();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void extendButton_Click(object sender, EventArgs e)
        {
            try
            {
                robot.Extend();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void retractButton_Click(object sender, EventArgs e)
        {
            try
            {
                robot.Retract();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            try
            {
                robot.Home();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                string cmd = messageBox.Text;
                messageBox.Text = "";
                robot.SendCommand(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void messageBox_TextChanged(object sender, EventArgs e)
        {
            //messageBox.AppendText(Environment.NewLine + messageBox.Text);
        }

        private void cmdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            robot.Close();
        }
    }
}

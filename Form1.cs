﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management.Automation;
using System.Collections.ObjectModel;
using System.Net;
using System.IO;

namespace RegressionSuiteTestHarness
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] project = { "PSAudit", "PSClient", "PSClientInstallers", "PSDatabase", "PSHl7", "PSI", "PSIdentityService", "PSMT", "PSMT-Reports", "PSServer", "PSWS" };
            ProjectSelector.DataSource = project;
            APGifZone.Hide();


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                ProjectSuiteSelector.Clear();
                ProjectSuiteSelector.Text = file;
                PutTheGifIn("https://78.media.tumblr.com/tumblr_m7u8dektwm1rbbzboo1_500.gif");
                APFeedbackBox.Show(); 
                APFeedbackBox.Text = "Yeah Baby, great project suite selection"; 
            }
            Console.WriteLine(result);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PutTheGifIn("https://media3.giphy.com/media/XenWVVdSzaxLW/giphy.gif");
            APFeedbackBox.Text = "Great Project Selection"; 
        }


        private void button2_Click(object sender, EventArgs e)
        {
            using (PowerShell shellPower = PowerShell.Create())
            {
                string VersionArg = "NA";
                string BranchArg = "TestHarness";
                string DevArg = "QA";
                string tePath = "C:\\Program Files (x86)\\SmartBear\\TestExecute 12\\Bin\\TestExecute.exe";
                string GUID = null; 
                GUID = Guid.NewGuid().ToString();
                string localIP = GetIP();
                string hostName = Dns.GetHostEntry("localhost").HostName;
                if (!File.Exists(ProjectSuiteSelector.Text))
                {
                    MessageBox.Show("Please Select a Valid Project", "You done messed up now",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!String.IsNullOrWhiteSpace(Branch.Text))
                    
                {
                    BranchArg = QuoteWrap(Branch.Text);
                }
                if (!String.IsNullOrWhiteSpace(Dev.Text))
                {
                    DevArg = QuoteWrap(Dev.Text);
                }
                if (!String.IsNullOrWhiteSpace(VersionBox.Text))
                {
                    VersionArg = QuoteWrap(VersionBox.Text); 
                } 

                
                string arguments = string.Format("&\"{0} \"{1}\"\" /run /project:{2} /exit BULLSHIT {3} {4} {5} {6} {7} {8}\"\"", tePath, ProjectSuiteSelector.Text, ProjectSelector.Text, GUID, localIP, hostName, VersionArg, BranchArg, DevArg);
                shellPower.AddScript(arguments);
                APFeedbackBox.Text = string.Format("Oh Behave baby, suite launched \n Your GUID is {0}", GUID);
                shellPower.Invoke();
                PutTheGifIn("https://www.reactiongifs.us/wp-content/uploads/2014/09/shocked_austin_powers.gif");


            }

        }

        public static string GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Shit broke");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            APGifZone.Hide();
            APFeedbackBox.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public static string QuoteWrap(string input)
        {
            input = "\"" + input + "\""; 
            return input;
        }

        public void PutTheGifIn(string URL)
        {
            APGifZone.ImageLocation = URL;
            APGifZone.SizeMode = PictureBoxSizeMode.StretchImage;
            APGifZone.Show();
        }

        private void Branch_TextChanged(object sender, EventArgs e)
        {
            PutTheGifIn("https://media.giphy.com/media/xUPGcfe7OAEDKUXQPK/giphy.gif");
            APFeedbackBox.Text = "Great Branch Baby"; 
        }

        private void Dev_TextChanged(object sender, EventArgs e)
        {
            PutTheGifIn("https://media.giphy.com/media/l0MYC0LajbaPoEADu/giphy.gif");
            APFeedbackBox.Text = "Great Dev Baby"; 
        }

        private void VersionBox_TextChanged(object sender, EventArgs e)
        {
            PutTheGifIn("https://media.giphy.com/media/l1KVb2dUcmuGG4tby/giphy.gif");
            APFeedbackBox.Text ="Great Version Baby";
        }
    }
}

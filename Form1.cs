using System;
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
            string[] project = { "PSAudit", "PSClient","PSClientInstallers","PSDatabase","PSHl7","PSI","PSIdentityService","PSMT","PSMT-Reports","PSServer","PSWS" };
            ProjectSelector.DataSource = project;
            APFeedbackBox.Hide();
            APGifZone.Hide(); 
            
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); 
            if(result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                ProjectSuiteSelector.Clear();
                ProjectSuiteSelector.Text = file; 
            }
            Console.WriteLine(result); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            using (PowerShell shellPower = PowerShell.Create())
            {
                string tePath = "C:\\Program Files (x86)\\SmartBear\\TestExecute 12\\Bin\\TestExecute.exe";
                string GUID = Guid.NewGuid().ToString();
                string localIP = GetIP();
                string hostName = Dns.GetHostEntry("localhost").HostName;
                if (!File.Exists(ProjectSuiteSelector.Text))
                    {
                    MessageBox.Show("Please Select a Valid Project", "You done messed up now",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                    }
                string arguments = string.Format("&\"{0} \"{1}\"\" /run /project:{2} /exit BULLSHIT {3} {4} {5}\"\"", tePath, ProjectSuiteSelector.Text, ProjectSelector.Text, GUID, localIP, hostName); 
                shellPower.AddScript(arguments);
                APFeedbackBox.Show();
                APFeedbackBox.Text = string.Format("Oh Behave baby, suite lanuched \n Your GUID is {0}", GUID); 
                APGifZone.Show(); 
                shellPower.Invoke(); 

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
    }
}

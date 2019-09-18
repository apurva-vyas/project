using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LU.BusinessLayer;
using System.Configuration;
using System.IO;

namespace LU.UserInterface
{
    public partial class User : Form
    {

        string[] header;
        private string userName;
        string folder;
        Dictionary<string, string> dict;
        public User()
        {
            InitializeComponent();

            string path = ConfigurationManager.AppSettings["formatFile"];
            header = File.ReadAllLines(path);
            //List<string> header = new List<string> { $"Title :","Date And Time Of Creation : " };
            richTextBox1.Text = String.Join(Environment.NewLine, header);
        }
        public User(string userName) : this()
        {
            this.userName = userName;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                //string EditText = "\n Author :" + userName + "\n" + richTextBox1.Text;
                string contents = richTextBox1.Text.ToString();
                dict = new Dictionary<string, string>();
                int pos1 = contents.IndexOf("/*");
                int pos2 = contents.IndexOf("*/");
                contents = contents.Substring(pos1 + 2, pos2 - 2);
                string[] a = contents.Split(new Char[] { ':' });
                for (int j = 0; j < a.Length - 1; j++)
                {
                    dict.Add(a[j].Trim(), null);

                }

                dict["Last Modified By"] = userName;
                dict["Last Modified Date and Time"] = DateTime.Now.ToString();


                //string path = @"C:\Users\Alchemy.DESKTOP-V8A10HM\Desktop\CSharp\New folder\LicenceUpdate";
                var businessObject = new BusinessComponent();
                businessObject.MonitorDirectory(folder, dict, userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderDlg = new FolderBrowserDialog();
                folderDlg.ShowNewFolderButton = true;
                // Show the FolderBrowserDialog.  
                DialogResult result = folderDlg.ShowDialog();
                if (result == DialogResult.OK)
                {
                    textBox1.Text = folderDlg.SelectedPath;
                    Environment.SpecialFolder root = folderDlg.RootFolder;
                    folder = textBox1.Text;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LU.DataAccessLayer;
using LU.Watcher;

namespace LU.UserInterface
{
    public partial class UI : Form
    {
        public UI()
        {
            InitializeComponent();

            List<string> header = new List<string> { $"Title :", "Version: ", "Date And Time Of Creation : " };
            richTextBox1.Text = String.Join(Environment.NewLine, header);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string EditText = richTextBox1.Text;
            string path = @"C:\Users\Alchemy.DESKTOP-V8A10HM\Desktop\CSharp\New folder\LicenceUpdate";
            
            Watcher.Watcher.MonitorDirectory(path);

            

        }
    }
}

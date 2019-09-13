using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeaderEditor
{
    public partial class LicenceUserInterface : Form
      {

        public LicenceUserInterface()
        {
            InitializeComponent();
           
            List<string> header = new List<string> { $"Title :", "Version: ", "Date And Time Of Creation : " };
            richTextBox1.Text = String.Join(Environment.NewLine, header); 

        }
       
        

        private void Save_Click(object sender, EventArgs e)
        {
            string EditText = richTextBox1.Text;
        }
    }
}

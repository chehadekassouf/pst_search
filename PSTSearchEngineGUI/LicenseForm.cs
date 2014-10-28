using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSTSearchEngineGUI
{
    public partial class LicenseForm : Form
    {
        public LicenseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 5)
            {
                Properties.Settings.Default.SoftwareLicense= new Licencing.Licencing().GenerateUserLicense(textBox1.Text);
                Properties.Settings.Default.Save();
                System.Windows.Forms.MessageBox.Show("Kindly Ensure to send the following text:\n"+textBox1.Text +"\n via email to snkassouf@yahoo.com in order to receive the licence file");
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Empty name or less than 5 charachter");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Licencing.Licencing("chehade.kassouf",this.textBox1.Text);
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            if (Environment.UserName.ToLower() == "chehade.kassouf")
            {
                this.button3.Visible = true;
            }
        }
    }
}

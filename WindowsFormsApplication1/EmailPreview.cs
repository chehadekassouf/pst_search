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
    public partial class EmailPreview : Form
    {
        public EmailPreview(string[] input)
        {
            InitializeComponent();
            int i = 0;
            this.textBoxFrom.Text = input[i++];
            this.textBoxTo.Text = input[i++];
            this.textBoxCC.Text = input[i++];
            this.textBoxSubject.Text =  input[i++];
            this.textBoxDate.Text =  input[i++];
            this.textBoxTime.Text =  input[i++];
            this.textBoxPath.Text = input[i++];
            this.textBoxBody.Text =  input[i++];
            this.textBoxAttachments.Text = input[i++];
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

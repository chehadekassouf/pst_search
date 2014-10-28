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
    public partial class ProgressForm : Form
    {
        public System.Windows.Forms.Label currentFile
        {
            get { return this.label1; }
        }
        public System.Windows.Forms.Label totalFile
        {
            get { return this.label2; }
        }
        public System.Windows.Forms.Label totalEmails
        {
            get { return this.label3; }
        }
        public System.Windows.Forms.ProgressBar progressFile
        {
            get { return this.progressBar1; }
        }
        public ProgressForm()
        {
            InitializeComponent();
        }
    }
}

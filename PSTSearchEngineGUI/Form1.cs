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
    public partial class Form1 : Form
    {
        private DataTable BaseTable;
        private string CataloguesPath;
        private string PSTPath;
        private bool loaded=false;
        private bool validlicense = false;
        public Form1()
        {

            
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CheckLicence();
            try
            {
                if (Properties.Settings.Default.CataloguePath.Trim().Length>0)
                {
                    this.CataloguesPath = Properties.Settings.Default.CataloguePath;
                    this.toolStripStatusLabel1.Text = "OSE Path: "+this.CataloguesPath;
                }
                else
                {
                   System.IO.DirectoryInfo di =new System.IO.DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
                   System.IO.DirectoryInfo osedi= di.CreateSubdirectory("PSTSearchEngine").CreateSubdirectory("OSECatalogue");
                   Properties.Settings.Default.CataloguePath = osedi.FullName;
                   Properties.Settings.Default.Save();
                   this.CataloguesPath = Properties.Settings.Default.CataloguePath;
                   this.toolStripStatusLabel1.Text = "OSE Path: " + this.CataloguesPath;

                    /*
                    DialogResult dr = MessageBox.Show("Do You Want To Select Catalogue Folder?", "Catalogue Folder Alert", MessageBoxButtons.YesNoCancel);
                    if (dr == DialogResult.Yes)
                    {
                        FolderBrowserDialog fbd = new FolderBrowserDialog();
                        fbd.Description = "Select Catalogue Folder";
                        if (fbd.ShowDialog() == DialogResult.OK)
                        {

                            Properties.Settings.Default.CataloguePath = fbd.SelectedPath;
                            Properties.Settings.Default.Save();
                            this.CataloguesPath = Properties.Settings.Default.CataloguePath;

                        }
                        else
                        {
                            this.Close();
                            return;
                        }
                    }
                    else
                    {
                        this.Close();
                        return;
                    }*/
                }
                this.PSTPath = Properties.Settings.Default.PSTPath;
            }
            catch 
            { 
            }
            
        }

        private void findMails(bool refine)
        {
            
            if (!loaded)
            {
                BaseTable = new GMS.OutlookSearcher().ReadCatalogue(this.CataloguesPath).BaseTable;
                loaded = true;
            }
            System.Data.DataTable dt = this.dataGridView1.DataSource != null && refine ? (DataTable)this.dataGridView1.DataSource : BaseTable;
            if (this.textBox1.Text.Trim().Length > 0)
            {
                try
                {
                    //BaseTable = new GMS.OutlookSearcher().ReadCatalogue(this.CataloguesPath,this.textBox1.Text.Replace(":", " Like '").Replace(";", "' and ").Replace("*", "%") + "'").BaseTable;

                    this.dataGridView1.DataSource = GMS.MailTable.getTable(dt, this.textBox1.Text.Replace(":", " Like '").Replace(";", "' and ").Replace("*", "%") + "'", "maildate desc,mailtime desc", this.validlicense);
                   
                    this.label1.Text=((DataTable)this.dataGridView1.DataSource).Rows.Count.ToString();
                }
                catch 
                {
                    try
                    {
                        string searchstring = "";
                        foreach (string astring in this.textBox1.Text.Split(' '))
                        {
                            if (searchstring.Length == 0)
                            {
                                searchstring = "from+tocc+subject+body like '%" +astring + "%'";
                            }
                            else
                            {
                                searchstring = searchstring + " and " + "from+tocc+subject+body like '%" + astring + "%'";
                            }
                        }
                        this.dataGridView1.DataSource = GMS.MailTable.getTable(dt, searchstring, "maildate desc,mailtime desc", this.validlicense);
                        this.highlightDataGrid(this.textBox1.Text);
                        this.label1.Text = ((DataTable)this.dataGridView1.DataSource).Rows.Count.ToString();
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("the search is not correct");
                    }
                }
                
               
            }
            else
            {
                 //BaseTable = new GMS.OutlookSearcher().ReadCatalogue(this.CataloguesPath).BaseTable;
                this.dataGridView1.DataSource = GMS.MailTable.getTable(dt, "", "maildate desc ,mailtime desc", this.validlicense);
                this.label1.Text = BaseTable.Rows.Count.ToString();
            }
        }
        
       


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string mid = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnMailID"].Value.ToString();
            string sid = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnStoreID"].Value.ToString();
            
            try
            {

                GMS.OutlookSearcher.openEmail(mid, sid);
            }
            catch
            {
                try 
                {
                    string currentPSTPath = GMS.OutlookSearcher.getPSTPath(sid);
                    System.IO.FileInfo fi = new System.IO.FileInfo(currentPSTPath);
                    string newPSTpath = this.PSTPath + "\\" + fi.Name;
                    string newstoreid = GMS.OutlookSearcher.replacePSTPath(sid, newPSTpath);
                    string newpath = GMS.OutlookSearcher.getPSTPath(newstoreid);
                    GMS.OutlookSearcher.openEmail(mid, newstoreid);
                }
                catch
                {
                    int i = 0;
                    string[] input = new string[9];
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnFrom"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnTo"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnCC"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnSubject"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnMailDate"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnMailTime"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnFullFolderPath"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnBody"].Value.ToString();
                    input[i++] = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnAttachmentsName"].Value.ToString();
                    new EmailPreview(input).Show();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        public void UpdateThread()
        {
            GMS.MailTable mt = new GMS.OutlookSearcher().IndexSinglePst();
            //this.BaseTable = mt.BaseTable;
            //this.dataGridView1.DataSource = GMS.MailTable.getTable(BaseTable, BaseTable.Select());
            //this.label1.Text = BaseTable.Rows.Count.ToString();
            new GMS.Serializer().SerializeObject(this.CataloguesPath, mt);
            System.Windows.Forms.MessageBox.Show("Done");
            this.loaded = false;
 
        }
        public void SynchronizeThread()
        {
            ProgressForm  fr = new ProgressForm();
            fr.Show();
            this.loaded =new GMS.OutlookSearcher().BuildCatalogue(this.CataloguesPath);
            
            fr.Close();
          
        }
       
        private void CheckLicence()
        {
            this.validlicense = true;
           
        }

        private void changeCatalogueFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {

            System.Threading.Thread trd = new System.Threading.Thread(new System.Threading.ThreadStart(UpdateThread));
            trd.Start();

        }

       private void changeCataloguePathToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Current Folder Path:"+this.CataloguesPath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.CataloguePath = fbd.SelectedPath;
                Properties.Settings.Default.Save();

                this.CataloguesPath = Properties.Settings.Default.CataloguePath;
                this.toolStripStatusLabel1.Text = "OSE Path: " + this.CataloguesPath;
                

            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

      

        private void conceptAndSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("help.htm");
        }

        private void filterConversationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string conversationIndex = this.dataGridView1.Rows[this.dataGridView1.SelectedCells[0].RowIndex].Cells["ColumnConversationIndex"].Value.ToString();
            if (conversationIndex.Length >= 30)
            {
                this.dataGridView1.DataSource = GMS.MailTable.getTable(BaseTable, "ConversationIndex like '" + conversationIndex.Substring(0, 30) + "%'", "maildate desc,mailtime desc", this.validlicense);
                this.label1.Text = ((DataTable)this.dataGridView1.DataSource).Rows.Count.ToString();
            }
        }
        private void highlightDataGrid(string searchstring)
        {
            if (searchstring == null || searchstring.Length == 0)
            {
                return;
            }
            if (searchstring.Contains(':'))
            {
                return;
            }
                foreach (DataGridViewRow arow in this.dataGridView1.Rows)
                {
                    foreach (DataGridViewCell acell in arow.Cells)
                    {
                        if (acell.Value != null)
                        {
                            try
                            {
                                int i = 1;
                                int k=1;
                                foreach (string val in searchstring.Split(' '))
                                {
                                    if (acell.Value.ToString().ToUpper().Contains(val.ToUpper()))
                                    {
                                        i++;
                                    }
                                    k++;
                                }
                                if (i == k)
                                {
                                    acell.Style.BackColor = Color.Khaki;
                                }
                                else if (i > 1)
                                {
                                    acell.Style.BackColor = Color.WhiteSmoke;
                                }
                            }
                            catch
                            {

                            }
                        }
                    }

                }
            
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
             System.Threading.Thread trd = new System.Threading.Thread(new System.Threading.ThreadStart(SynchronizeThread));
             trd.Start();
        }

        private void buttonRefine_Click(object sender, EventArgs e)
        {
            this.buildExpression();
            this.findMails(true);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            this.buildExpression();
            this.findMails(false);
        }
        private void buildExpression()
        {
            if (this.tabControl1.SelectedIndex == 1)
            {
                string filter = this.textBoxFrom.Text.Trim().Length > 0 ? "from:*" + this.textBoxFrom.Text.Trim() + "*" : "";
                filter = this.textBoxTo.Text.Trim().Length > 0 ? filter + ";to:*" + this.textBoxTo.Text.Trim() + "*" : filter;
                filter = this.textBoxCC.Text.Trim().Length > 0 ? filter + ";cc:*" + this.textBoxCC.Text.Trim() + "*" : filter;
                filter = this.textBoxSubject.Text.Trim().Length > 0 ? filter + ";subject:*" + this.textBoxSubject.Text.Trim() + "*" : filter;
                filter = this.textBoxBody.Text.Trim().Length > 0 ? filter + ";body:*" + this.textBoxBody.Text.Trim() + "*" : filter;
                filter = this.textBoxAttachment.Text.Trim().Length > 0 ? filter + ";attachmentsname:*" + this.textBoxAttachment.Text.Trim() + "*" : filter;
                filter = filter.StartsWith(";") ? filter.Substring(1) : filter;
                this.textBox1.Text = filter;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void changePSTPathToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Current Folder Path:" + this.PSTPath;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.PSTPath = fbd.SelectedPath;
                Properties.Settings.Default.Save();

                this.PSTPath = Properties.Settings.Default.PSTPath;


            }
        }


        
    }
}

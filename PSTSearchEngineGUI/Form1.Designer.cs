namespace PSTSearchEngineGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefine = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAttachment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMailTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMailDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAttachmentsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullFolderPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnToCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAttchmentsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConversationIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStoreID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCatalogueFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeCataloguePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePSTPathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptAndSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(906, 274);
            this.splitContainer1.SplitterDistance = 94;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer2.Location = new System.Drawing.Point(0, 11);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.buttonFind);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.buttonRefine);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer2.Size = new System.Drawing.Size(906, 83);
            this.splitContainer2.SplitterDistance = 123;
            this.splitContainer2.TabIndex = 7;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(3, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(44, 20);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = " ";
            // 
            // buttonRefine
            // 
            this.buttonRefine.Location = new System.Drawing.Point(3, 25);
            this.buttonRefine.Name = "buttonRefine";
            this.buttonRefine.Size = new System.Drawing.Size(49, 20);
            this.buttonRefine.TabIndex = 5;
            this.buttonRefine.Text = "Refine";
            this.buttonRefine.UseVisualStyleBackColor = true;
            this.buttonRefine.Click += new System.EventHandler(this.buttonRefine_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 83);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(771, 57);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Custom Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(637, 20);
            this.textBox1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBoxAttachment);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBoxCC);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.textBoxBody);
            this.tabPage2.Controls.Add(this.textBoxSubject);
            this.tabPage2.Controls.Add(this.textBoxTo);
            this.tabPage2.Controls.Add(this.textBoxFrom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(771, 57);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Field Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(614, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Attachements";
            // 
            // textBoxAttachment
            // 
            this.textBoxAttachment.Location = new System.Drawing.Point(614, 11);
            this.textBoxAttachment.Name = "textBoxAttachment";
            this.textBoxAttachment.Size = new System.Drawing.Size(151, 20);
            this.textBoxAttachment.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "CC";
            // 
            // textBoxCC
            // 
            this.textBoxCC.Location = new System.Drawing.Point(192, 11);
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.Size = new System.Drawing.Size(89, 20);
            this.textBoxCC.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Body";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(443, 11);
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(151, 20);
            this.textBoxBody.TabIndex = 4;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(287, 11);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(150, 20);
            this.textBoxSubject.TabIndex = 3;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(97, 11);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(89, 20);
            this.textBoxTo.TabIndex = 1;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(3, 11);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(89, 20);
            this.textBoxFrom.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFrom,
            this.ColumnTo,
            this.ColumnSubject,
            this.ColumnCC,
            this.ColumnMailTime,
            this.ColumnMailDate,
            this.ColumnBody,
            this.ColumnAttachmentsName,
            this.ColumnFullFolderPath,
            this.ColumnToCC,
            this.ColumnAttchmentsCount,
            this.ColumnConversationIndex,
            this.ColumnMailID,
            this.ColumnStoreID});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Size = new System.Drawing.Size(906, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnFrom
            // 
            this.ColumnFrom.DataPropertyName = "From";
            this.ColumnFrom.HeaderText = "From";
            this.ColumnFrom.Name = "ColumnFrom";
            this.ColumnFrom.Width = 55;
            // 
            // ColumnTo
            // 
            this.ColumnTo.DataPropertyName = "To";
            this.ColumnTo.HeaderText = "To";
            this.ColumnTo.Name = "ColumnTo";
            this.ColumnTo.Width = 200;
            // 
            // ColumnSubject
            // 
            this.ColumnSubject.DataPropertyName = "Subject";
            this.ColumnSubject.HeaderText = "Subject";
            this.ColumnSubject.Name = "ColumnSubject";
            this.ColumnSubject.Width = 200;
            // 
            // ColumnCC
            // 
            this.ColumnCC.DataPropertyName = "CC";
            this.ColumnCC.HeaderText = "CC";
            this.ColumnCC.Name = "ColumnCC";
            // 
            // ColumnMailTime
            // 
            this.ColumnMailTime.DataPropertyName = "MailTime";
            this.ColumnMailTime.HeaderText = "MailTime";
            this.ColumnMailTime.Name = "ColumnMailTime";
            // 
            // ColumnMailDate
            // 
            this.ColumnMailDate.DataPropertyName = "MailDate";
            this.ColumnMailDate.HeaderText = "MailDate";
            this.ColumnMailDate.Name = "ColumnMailDate";
            // 
            // ColumnBody
            // 
            this.ColumnBody.DataPropertyName = "Body";
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnBody.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnBody.HeaderText = "Body";
            this.ColumnBody.Name = "ColumnBody";
            this.ColumnBody.Width = 200;
            // 
            // ColumnAttachmentsName
            // 
            this.ColumnAttachmentsName.DataPropertyName = "AttachmentsName";
            this.ColumnAttachmentsName.HeaderText = "AttachementsName";
            this.ColumnAttachmentsName.Name = "ColumnAttachmentsName";
            // 
            // ColumnFullFolderPath
            // 
            this.ColumnFullFolderPath.DataPropertyName = "FullFolderPath";
            this.ColumnFullFolderPath.HeaderText = "FullFolderPath";
            this.ColumnFullFolderPath.Name = "ColumnFullFolderPath";
            // 
            // ColumnToCC
            // 
            this.ColumnToCC.DataPropertyName = "ToCC";
            this.ColumnToCC.HeaderText = "ToCC";
            this.ColumnToCC.MinimumWidth = 2;
            this.ColumnToCC.Name = "ColumnToCC";
            this.ColumnToCC.Width = 2;
            // 
            // ColumnAttchmentsCount
            // 
            this.ColumnAttchmentsCount.DataPropertyName = "AttachmentsCount";
            this.ColumnAttchmentsCount.HeaderText = "AttachementsCount";
            this.ColumnAttchmentsCount.MinimumWidth = 2;
            this.ColumnAttchmentsCount.Name = "ColumnAttchmentsCount";
            this.ColumnAttchmentsCount.Width = 2;
            // 
            // ColumnConversationIndex
            // 
            this.ColumnConversationIndex.DataPropertyName = "ConversationIndex";
            this.ColumnConversationIndex.HeaderText = "ConversationIndex";
            this.ColumnConversationIndex.MinimumWidth = 2;
            this.ColumnConversationIndex.Name = "ColumnConversationIndex";
            this.ColumnConversationIndex.Width = 2;
            // 
            // ColumnMailID
            // 
            this.ColumnMailID.DataPropertyName = "MailID";
            this.ColumnMailID.HeaderText = "MailID";
            this.ColumnMailID.MinimumWidth = 2;
            this.ColumnMailID.Name = "ColumnMailID";
            this.ColumnMailID.Width = 2;
            // 
            // ColumnStoreID
            // 
            this.ColumnStoreID.DataPropertyName = "StoreID";
            this.ColumnStoreID.HeaderText = "StoreID";
            this.ColumnStoreID.MinimumWidth = 2;
            this.ColumnStoreID.Name = "ColumnStoreID";
            this.ColumnStoreID.Width = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.filterConversationToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem1.Text = "Open Email";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // filterConversationToolStripMenuItem
            // 
            this.filterConversationToolStripMenuItem.Name = "filterConversationToolStripMenuItem";
            this.filterConversationToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.filterConversationToolStripMenuItem.Text = "Filter Conversation";
            this.filterConversationToolStripMenuItem.Click += new System.EventHandler(this.filterConversationToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeCatalogueFolderToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.changeCataloguePathToolStripMenuItem,
            this.changePSTPathToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // changeCatalogueFolderToolStripMenuItem
            // 
            this.changeCatalogueFolderToolStripMenuItem.Name = "changeCatalogueFolderToolStripMenuItem";
            this.changeCatalogueFolderToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.changeCatalogueFolderToolStripMenuItem.Text = "Index Single PST";
            this.changeCatalogueFolderToolStripMenuItem.Click += new System.EventHandler(this.changeCatalogueFolderToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.refreshToolStripMenuItem.Text = "Refresh All Loaded PSTs";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // changeCataloguePathToolStripMenuItem
            // 
            this.changeCataloguePathToolStripMenuItem.Name = "changeCataloguePathToolStripMenuItem";
            this.changeCataloguePathToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.changeCataloguePathToolStripMenuItem.Text = "Change Catalogue Path";
            this.changeCataloguePathToolStripMenuItem.Click += new System.EventHandler(this.changeCataloguePathToolStripMenuItem_Click);
            // 
            // changePSTPathToolStripMenuItem
            // 
            this.changePSTPathToolStripMenuItem.Name = "changePSTPathToolStripMenuItem";
            this.changePSTPathToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.changePSTPathToolStripMenuItem.Text = "Change PST Path";
            this.changePSTPathToolStripMenuItem.Click += new System.EventHandler(this.changePSTPathToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conceptAndSetupToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // conceptAndSetupToolStripMenuItem
            // 
            this.conceptAndSetupToolStripMenuItem.Name = "conceptAndSetupToolStripMenuItem";
            this.conceptAndSetupToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.conceptAndSetupToolStripMenuItem.Text = "Concept and Setup";
            this.conceptAndSetupToolStripMenuItem.Click += new System.EventHandler(this.conceptAndSetupToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(175, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(906, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 320);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "PST Search Engine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCatalogueFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeCataloguePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptAndSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem filterConversationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.Button buttonRefine;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMailTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMailDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAttachmentsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullFolderPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnToCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAttchmentsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConversationIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStoreID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAttachment;
        private System.Windows.Forms.ToolStripMenuItem changePSTPathToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}


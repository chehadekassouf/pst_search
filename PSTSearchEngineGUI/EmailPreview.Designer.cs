namespace PSTSearchEngineGUI
{
    partial class EmailPreview
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
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelCC = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxCC = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.labelAttachement = new System.Windows.Forms.Label();
            this.textBoxAttachments = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.BackColor = System.Drawing.SystemColors.Control;
            this.labelFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrom.Location = new System.Drawing.Point(14, 13);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(33, 13);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.BackColor = System.Drawing.SystemColors.Control;
            this.labelTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTo.Location = new System.Drawing.Point(14, 36);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(23, 13);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "To:";
            // 
            // labelCC
            // 
            this.labelCC.AutoSize = true;
            this.labelCC.BackColor = System.Drawing.SystemColors.Control;
            this.labelCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCC.Location = new System.Drawing.Point(14, 58);
            this.labelCC.Name = "labelCC";
            this.labelCC.Size = new System.Drawing.Size(24, 13);
            this.labelCC.TabIndex = 2;
            this.labelCC.Text = "CC:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.BackColor = System.Drawing.SystemColors.Control;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(13, 79);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 3;
            this.labelSubject.Text = "Subject";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBody.Location = new System.Drawing.Point(0, 0);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBody.Size = new System.Drawing.Size(605, 332);
            this.textBoxBody.TabIndex = 4;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.SystemColors.Control;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(306, 10);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(33, 13);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.SystemColors.Control;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(440, 10);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 13);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Time:";
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.SystemColors.Control;
            this.labelPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPath.Location = new System.Drawing.Point(306, 36);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(32, 13);
            this.labelPath.TabIndex = 7;
            this.labelPath.Text = "Path:";
            this.labelPath.Click += new System.EventHandler(this.label7_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxAttachments);
            this.splitContainer1.Panel1.Controls.Add(this.labelAttachement);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxPath);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTime);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxDate);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSubject);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxFrom);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxCC);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTo);
            this.splitContainer1.Panel1.Controls.Add(this.labelPath);
            this.splitContainer1.Panel1.Controls.Add(this.labelFrom);
            this.splitContainer1.Panel1.Controls.Add(this.labelTime);
            this.splitContainer1.Panel1.Controls.Add(this.labelTo);
            this.splitContainer1.Panel1.Controls.Add(this.labelDate);
            this.splitContainer1.Panel1.Controls.Add(this.labelCC);
            this.splitContainer1.Panel1.Controls.Add(this.labelSubject);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxBody);
            this.splitContainer1.Size = new System.Drawing.Size(605, 471);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 8;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(347, 36);
            this.textBoxPath.Multiline = true;
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPath.Size = new System.Drawing.Size(221, 20);
            this.textBoxPath.TabIndex = 14;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(481, 13);
            this.textBoxTime.Multiline = true;
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTime.Size = new System.Drawing.Size(87, 20);
            this.textBoxTime.TabIndex = 13;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(347, 13);
            this.textBoxDate.Multiline = true;
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDate.Size = new System.Drawing.Size(87, 20);
            this.textBoxDate.TabIndex = 12;
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(62, 79);
            this.textBoxSubject.Multiline = true;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSubject.Size = new System.Drawing.Size(506, 20);
            this.textBoxSubject.TabIndex = 11;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(62, 13);
            this.textBoxFrom.Multiline = true;
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFrom.Size = new System.Drawing.Size(238, 20);
            this.textBoxFrom.TabIndex = 10;
            // 
            // textBoxCC
            // 
            this.textBoxCC.Location = new System.Drawing.Point(62, 58);
            this.textBoxCC.Multiline = true;
            this.textBoxCC.Name = "textBoxCC";
            this.textBoxCC.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCC.Size = new System.Drawing.Size(238, 20);
            this.textBoxCC.TabIndex = 9;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(62, 36);
            this.textBoxTo.Multiline = true;
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTo.Size = new System.Drawing.Size(238, 20);
            this.textBoxTo.TabIndex = 8;
            // 
            // labelAttachement
            // 
            this.labelAttachement.AutoSize = true;
            this.labelAttachement.Location = new System.Drawing.Point(14, 106);
            this.labelAttachement.Name = "labelAttachement";
            this.labelAttachement.Size = new System.Drawing.Size(67, 13);
            this.labelAttachement.TabIndex = 15;
            this.labelAttachement.Text = "Attachement";
            // 
            // textBoxAttachments
            // 
            this.textBoxAttachments.Location = new System.Drawing.Point(85, 106);
            this.textBoxAttachments.Name = "textBoxAttachments";
            this.textBoxAttachments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxAttachments.Size = new System.Drawing.Size(483, 20);
            this.textBoxAttachments.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(481, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 15);
            this.button1.TabIndex = 17;
            this.button1.TabStop = false;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(605, 471);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EmailPreview";
            this.Text = "EmailPreview";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelCC;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxCC;
        private System.Windows.Forms.TextBox textBoxAttachments;
        private System.Windows.Forms.Label labelAttachement;
        private System.Windows.Forms.Button button1;
    }
}
namespace Purge
{
    partial class Akamai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Akamai));
            this.button_purge = new System.Windows.Forms.Button();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.label_filePath = new System.Windows.Forms.Label();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_quite = new System.Windows.Forms.Button();
            this.dataGridView_XL = new System.Windows.Forms.DataGridView();
            this.button_xlFile = new System.Windows.Forms.Button();
            this.button_Choose = new System.Windows.Forms.Button();
            this.textBox_Choose = new System.Windows.Forms.TextBox();
            this.textBox_Load = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label_Load = new System.Windows.Forms.Label();
            this.label_Choose = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.radioButton_Purge = new System.Windows.Forms.RadioButton();
            this.radioButton_Invalidate = new System.Windows.Forms.RadioButton();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.button_Clear2 = new System.Windows.Forms.Button();
            this.panel_Path = new System.Windows.Forms.Panel();
            this.panel_Invalidate = new System.Windows.Forms.Panel();
            this.textBox_Email2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Submit = new System.Windows.Forms.Button();
            this.textBox_Choose_File = new System.Windows.Forms.TextBox();
            this.button_Choose_File = new System.Windows.Forms.Button();
            this.radioButton_Production = new System.Windows.Forms.RadioButton();
            this.radioButton_Staging = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel_Path.SuspendLayout();
            this.panel_Invalidate.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_purge
            // 
            this.button_purge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_purge.Location = new System.Drawing.Point(423, 128);
            this.button_purge.Name = "button_purge";
            this.button_purge.Size = new System.Drawing.Size(67, 27);
            this.button_purge.TabIndex = 0;
            this.button_purge.Text = "Submit";
            this.button_purge.UseVisualStyleBackColor = false;
            this.button_purge.Click += new System.EventHandler(this.button_purge_Click);
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.AllowDrop = true;
            this.textBox_filePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox_filePath.Location = new System.Drawing.Point(143, 60);
            this.textBox_filePath.Multiline = true;
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_filePath.Size = new System.Drawing.Size(347, 56);
            this.textBox_filePath.TabIndex = 1;
            this.textBox_filePath.TextChanged += new System.EventHandler(this.textBox_filePath_TextChanged);
            // 
            // label_filePath
            // 
            this.label_filePath.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label_filePath.AutoSize = true;
            this.label_filePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_filePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_filePath.Location = new System.Drawing.Point(70, 60);
            this.label_filePath.Name = "label_filePath";
            this.label_filePath.Size = new System.Drawing.Size(67, 17);
            this.label_filePath.TabIndex = 2;
            this.label_filePath.Text = "File Path:";
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Red;
            this.button_clear.Location = new System.Drawing.Point(493, 24);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(22, 22);
            this.button_clear.TabIndex = 3;
            this.button_clear.Text = "X";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_quite
            // 
            this.button_quite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_quite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_quite.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_quite.Location = new System.Drawing.Point(680, 439);
            this.button_quite.Name = "button_quite";
            this.button_quite.Size = new System.Drawing.Size(69, 44);
            this.button_quite.TabIndex = 4;
            this.button_quite.Text = "Quit";
            this.button_quite.UseVisualStyleBackColor = false;
            this.button_quite.Click += new System.EventHandler(this.button_quite_Click);
            // 
            // dataGridView_XL
            // 
            this.dataGridView_XL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_XL.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_XL.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_XL.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView_XL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_XL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_XL.Location = new System.Drawing.Point(12, 381);
            this.dataGridView_XL.Name = "dataGridView_XL";
            this.dataGridView_XL.RowHeadersVisible = false;
            this.dataGridView_XL.Size = new System.Drawing.Size(131, 112);
            this.dataGridView_XL.TabIndex = 6;
            // 
            // button_xlFile
            // 
            this.button_xlFile.Location = new System.Drawing.Point(301, 33);
            this.button_xlFile.Name = "button_xlFile";
            this.button_xlFile.Size = new System.Drawing.Size(104, 23);
            this.button_xlFile.TabIndex = 7;
            this.button_xlFile.Text = "Load Excel Sheet";
            this.button_xlFile.UseVisualStyleBackColor = true;
            this.button_xlFile.Click += new System.EventHandler(this.button_xlFile_Click);
            // 
            // button_Choose
            // 
            this.button_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.button_Choose.Location = new System.Drawing.Point(276, 4);
            this.button_Choose.Name = "button_Choose";
            this.button_Choose.Size = new System.Drawing.Size(31, 23);
            this.button_Choose.TabIndex = 8;
            this.button_Choose.Text = "...";
            this.button_Choose.UseVisualStyleBackColor = true;
            this.button_Choose.Click += new System.EventHandler(this.button_Choose_Click);
            // 
            // textBox_Choose
            // 
            this.textBox_Choose.Location = new System.Drawing.Point(10, 4);
            this.textBox_Choose.Name = "textBox_Choose";
            this.textBox_Choose.Size = new System.Drawing.Size(260, 20);
            this.textBox_Choose.TabIndex = 9;
            // 
            // textBox_Load
            // 
            this.textBox_Load.Location = new System.Drawing.Point(10, 32);
            this.textBox_Load.Name = "textBox_Load";
            this.textBox_Load.Size = new System.Drawing.Size(260, 20);
            this.textBox_Load.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.splitContainer1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Location = new System.Drawing.Point(12, 248);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label_Load);
            this.splitContainer1.Panel1.Controls.Add(this.label_Choose);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_xlFile);
            this.splitContainer1.Panel2.Controls.Add(this.button_Choose);
            this.splitContainer1.Panel2.Controls.Add(this.button_Reset);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Choose);
            this.splitContainer1.Panel2.Controls.Add(this.textBox_Load);
            this.splitContainer1.Size = new System.Drawing.Size(560, 86);
            this.splitContainer1.SplitterDistance = 158;
            this.splitContainer1.TabIndex = 11;
            // 
            // label_Load
            // 
            this.label_Load.AutoSize = true;
            this.label_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_Load.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Load.Location = new System.Drawing.Point(3, 35);
            this.label_Load.Name = "label_Load";
            this.label_Load.Size = new System.Drawing.Size(138, 17);
            this.label_Load.TabIndex = 15;
            this.label_Load.Text = "Choose Excel Sheet:";
            // 
            // label_Choose
            // 
            this.label_Choose.AutoSize = true;
            this.label_Choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_Choose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Choose.Location = new System.Drawing.Point(3, 6);
            this.label_Choose.Name = "label_Choose";
            this.label_Choose.Size = new System.Drawing.Size(119, 17);
            this.label_Choose.TabIndex = 0;
            this.label_Choose.Text = "Choose File Path:";
            // 
            // button_Reset
            // 
            this.button_Reset.BackColor = System.Drawing.Color.Red;
            this.button_Reset.Location = new System.Drawing.Point(275, 32);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(20, 23);
            this.button_Reset.TabIndex = 14;
            this.button_Reset.Text = "X";
            this.button_Reset.UseVisualStyleBackColor = false;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // radioButton_Purge
            // 
            this.radioButton_Purge.AutoSize = true;
            this.radioButton_Purge.Checked = true;
            this.radioButton_Purge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton_Purge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton_Purge.Location = new System.Drawing.Point(587, 131);
            this.radioButton_Purge.Name = "radioButton_Purge";
            this.radioButton_Purge.Size = new System.Drawing.Size(62, 20);
            this.radioButton_Purge.TabIndex = 14;
            this.radioButton_Purge.TabStop = true;
            this.radioButton_Purge.Text = "Purge";
            this.radioButton_Purge.UseVisualStyleBackColor = true;
            this.radioButton_Purge.CheckedChanged += new System.EventHandler(this.radioButton_Purge_CheckedChanged);
            // 
            // radioButton_Invalidate
            // 
            this.radioButton_Invalidate.AutoSize = true;
            this.radioButton_Invalidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.radioButton_Invalidate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton_Invalidate.Location = new System.Drawing.Point(587, 157);
            this.radioButton_Invalidate.Name = "radioButton_Invalidate";
            this.radioButton_Invalidate.Size = new System.Drawing.Size(87, 20);
            this.radioButton_Invalidate.TabIndex = 15;
            this.radioButton_Invalidate.Text = "Invalidate ";
            this.radioButton_Invalidate.UseVisualStyleBackColor = true;
            this.radioButton_Invalidate.CheckedChanged += new System.EventHandler(this.radioButton_Invalidate_CheckedChanged);
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(143, 24);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(347, 20);
            this.textBox_Email.TabIndex = 16;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_Email.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Email.Location = new System.Drawing.Point(8, 27);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(134, 17);
            this.label_Email.TabIndex = 17;
            this.label_Email.Text = "Confermation Email:";
            // 
            // button_Clear2
            // 
            this.button_Clear2.BackColor = System.Drawing.Color.Red;
            this.button_Clear2.Location = new System.Drawing.Point(493, 60);
            this.button_Clear2.Name = "button_Clear2";
            this.button_Clear2.Size = new System.Drawing.Size(23, 20);
            this.button_Clear2.TabIndex = 18;
            this.button_Clear2.Text = "X";
            this.button_Clear2.UseVisualStyleBackColor = false;
            this.button_Clear2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_Path
            // 
            this.panel_Path.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_Path.BackColor = System.Drawing.Color.LightGray;
            this.panel_Path.Controls.Add(this.textBox_Email);
            this.panel_Path.Controls.Add(this.button_Clear2);
            this.panel_Path.Controls.Add(this.textBox_filePath);
            this.panel_Path.Controls.Add(this.label_Email);
            this.panel_Path.Controls.Add(this.label_filePath);
            this.panel_Path.Controls.Add(this.button_clear);
            this.panel_Path.Controls.Add(this.button_purge);
            this.panel_Path.Location = new System.Drawing.Point(1, 1);
            this.panel_Path.Name = "panel_Path";
            this.panel_Path.Size = new System.Drawing.Size(560, 157);
            this.panel_Path.TabIndex = 19;
            // 
            // panel_Invalidate
            // 
            this.panel_Invalidate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel_Invalidate.BackColor = System.Drawing.Color.LightGray;
            this.panel_Invalidate.Controls.Add(this.textBox_Email2);
            this.panel_Invalidate.Controls.Add(this.label1);
            this.panel_Invalidate.Controls.Add(this.button1);
            this.panel_Invalidate.Controls.Add(this.button_Submit);
            this.panel_Invalidate.Controls.Add(this.textBox_Choose_File);
            this.panel_Invalidate.Controls.Add(this.button_Choose_File);
            this.panel_Invalidate.Location = new System.Drawing.Point(0, 3);
            this.panel_Invalidate.Name = "panel_Invalidate";
            this.panel_Invalidate.Size = new System.Drawing.Size(556, 157);
            this.panel_Invalidate.TabIndex = 21;
            // 
            // textBox_Email2
            // 
            this.textBox_Email2.Location = new System.Drawing.Point(162, 38);
            this.textBox_Email2.Name = "textBox_Email2";
            this.textBox_Email2.Size = new System.Drawing.Size(347, 20);
            this.textBox_Email2.TabIndex = 20;
            this.textBox_Email2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Confermation Email:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(512, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button_Submit.Location = new System.Drawing.Point(442, 117);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(67, 27);
            this.button_Submit.TabIndex = 18;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            this.button_Submit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_Choose_File
            // 
            this.textBox_Choose_File.Location = new System.Drawing.Point(162, 77);
            this.textBox_Choose_File.Name = "textBox_Choose_File";
            this.textBox_Choose_File.Size = new System.Drawing.Size(347, 20);
            this.textBox_Choose_File.TabIndex = 1;
            // 
            // button_Choose_File
            // 
            this.button_Choose_File.Location = new System.Drawing.Point(73, 77);
            this.button_Choose_File.Name = "button_Choose_File";
            this.button_Choose_File.Size = new System.Drawing.Size(75, 23);
            this.button_Choose_File.TabIndex = 0;
            this.button_Choose_File.Text = "Choose File";
            this.button_Choose_File.UseVisualStyleBackColor = true;
            this.button_Choose_File.Click += new System.EventHandler(this.button_Choose_File_Click);
            // 
            // radioButton_Production
            // 
            this.radioButton_Production.AutoSize = true;
            this.radioButton_Production.Checked = true;
            this.radioButton_Production.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButton_Production.Location = new System.Drawing.Point(583, 34);
            this.radioButton_Production.Name = "radioButton_Production";
            this.radioButton_Production.Size = new System.Drawing.Size(94, 21);
            this.radioButton_Production.TabIndex = 1;
            this.radioButton_Production.TabStop = true;
            this.radioButton_Production.Text = "Production";
            this.radioButton_Production.UseVisualStyleBackColor = true;
            // 
            // radioButton_Staging
            // 
            this.radioButton_Staging.AutoSize = true;
            this.radioButton_Staging.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.radioButton_Staging.Location = new System.Drawing.Point(583, 62);
            this.radioButton_Staging.Name = "radioButton_Staging";
            this.radioButton_Staging.Size = new System.Drawing.Size(74, 21);
            this.radioButton_Staging.TabIndex = 0;
            this.radioButton_Staging.Text = "Staging";
            this.radioButton_Staging.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(560, 184);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel_Path);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(552, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel_Invalidate);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(552, 158);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Akamai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(754, 485);
            this.Controls.Add(this.radioButton_Invalidate);
            this.Controls.Add(this.radioButton_Purge);
            this.Controls.Add(this.radioButton_Staging);
            this.Controls.Add(this.radioButton_Production);
            this.Controls.Add(this.button_quite);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.dataGridView_XL);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Akamai";
            this.Text = "Akamai Purger ";
            this.Load += new System.EventHandler(this.Akamai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_XL)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel_Path.ResumeLayout(false);
            this.panel_Path.PerformLayout();
            this.panel_Invalidate.ResumeLayout(false);
            this.panel_Invalidate.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_purge;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Label label_filePath;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_quite;
        private System.Windows.Forms.DataGridView dataGridView_XL;
        private System.Windows.Forms.Button button_xlFile;
        private System.Windows.Forms.Button button_Choose;
        private System.Windows.Forms.TextBox textBox_Choose;
        private System.Windows.Forms.TextBox textBox_Load;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Label label_Load;
        private System.Windows.Forms.Label label_Choose;
        private System.Windows.Forms.RadioButton radioButton_Purge;
        private System.Windows.Forms.RadioButton radioButton_Invalidate;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Button button_Clear2;
        private System.Windows.Forms.Panel panel_Path;
        private System.Windows.Forms.Panel panel_Invalidate;
        private System.Windows.Forms.Button button_Choose_File;
        private System.Windows.Forms.RadioButton radioButton_Production;
        private System.Windows.Forms.RadioButton radioButton_Staging;
        private System.Windows.Forms.TextBox textBox_Choose_File;
        private System.Windows.Forms.TextBox textBox_Email2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}


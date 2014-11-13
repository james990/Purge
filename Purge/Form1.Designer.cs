namespace Purge
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
            this.button_purge = new System.Windows.Forms.Button();
            this.textBox_filePath = new System.Windows.Forms.TextBox();
            this.label_filePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_purge
            // 
            this.button_purge.Location = new System.Drawing.Point(343, 197);
            this.button_purge.Name = "button_purge";
            this.button_purge.Size = new System.Drawing.Size(80, 27);
            this.button_purge.TabIndex = 0;
            this.button_purge.Text = "Purge";
            this.button_purge.UseVisualStyleBackColor = true;
            this.button_purge.Click += new System.EventHandler(this.button_purge_Click);
            // 
            // textBox_filePath
            // 
            this.textBox_filePath.Location = new System.Drawing.Point(119, 155);
            this.textBox_filePath.Name = "textBox_filePath";
            this.textBox_filePath.Size = new System.Drawing.Size(304, 20);
            this.textBox_filePath.TabIndex = 1;
            this.textBox_filePath.TextChanged += new System.EventHandler(this.textBox_filePath_TextChanged);
            // 
            // label_filePath
            // 
            this.label_filePath.AutoSize = true;
            this.label_filePath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label_filePath.Location = new System.Drawing.Point(54, 158);
            this.label_filePath.Name = "label_filePath";
            this.label_filePath.Size = new System.Drawing.Size(48, 13);
            this.label_filePath.TabIndex = 2;
            this.label_filePath.Text = "File Path";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(480, 252);
            this.Controls.Add(this.label_filePath);
            this.Controls.Add(this.textBox_filePath);
            this.Controls.Add(this.button_purge);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_purge;
        private System.Windows.Forms.TextBox textBox_filePath;
        private System.Windows.Forms.Label label_filePath;
    }
}


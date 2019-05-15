namespace _2.Ödev
{
    partial class Form3
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
            this.kayitListele = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // kayitListele
            // 
            this.kayitListele.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.kayitListele.Location = new System.Drawing.Point(302, 371);
            this.kayitListele.Name = "kayitListele";
            this.kayitListele.Size = new System.Drawing.Size(205, 48);
            this.kayitListele.TabIndex = 1;
            this.kayitListele.Text = "KAYITLARI LİSTELE";
            this.kayitListele.UseVisualStyleBackColor = false;
            this.kayitListele.Click += new System.EventHandler(this.kayitListele_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(273, 407);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(519, 431);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.kayitListele);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button kayitListele;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
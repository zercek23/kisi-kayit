namespace _2.Ödev
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
            this.KayitEkle = new System.Windows.Forms.Button();
            this.KayitList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KayitEkle
            // 
            this.KayitEkle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KayitEkle.Location = new System.Drawing.Point(32, 78);
            this.KayitEkle.Name = "KayitEkle";
            this.KayitEkle.Size = new System.Drawing.Size(100, 111);
            this.KayitEkle.TabIndex = 0;
            this.KayitEkle.Text = "KAYIT EKLE";
            this.KayitEkle.UseVisualStyleBackColor = false;
            this.KayitEkle.Click += new System.EventHandler(this.KayitEkle_Click);
            // 
            // KayitList
            // 
            this.KayitList.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.KayitList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.KayitList.Location = new System.Drawing.Point(138, 78);
            this.KayitList.Name = "KayitList";
            this.KayitList.Size = new System.Drawing.Size(100, 111);
            this.KayitList.TabIndex = 1;
            this.KayitList.Text = "KAYIT LİSTELE";
            this.KayitList.UseVisualStyleBackColor = false;
            this.KayitList.Click += new System.EventHandler(this.KayitList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 262);
            this.Controls.Add(this.KayitList);
            this.Controls.Add(this.KayitEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KayitEkle;
        private System.Windows.Forms.Button KayitList;
    }
}


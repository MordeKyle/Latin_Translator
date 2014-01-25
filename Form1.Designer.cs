namespace Latin_Translator
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
            this.sinister = new System.Windows.Forms.Button();
            this.dexter = new System.Windows.Forms.Button();
            this.medium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sinister
            // 
            this.sinister.Location = new System.Drawing.Point(113, 47);
            this.sinister.Name = "sinister";
            this.sinister.Size = new System.Drawing.Size(75, 23);
            this.sinister.TabIndex = 0;
            this.sinister.Text = "Sinister";
            this.sinister.UseVisualStyleBackColor = true;
            // 
            // dexter
            // 
            this.dexter.Location = new System.Drawing.Point(113, 76);
            this.dexter.Name = "dexter";
            this.dexter.Size = new System.Drawing.Size(75, 23);
            this.dexter.TabIndex = 1;
            this.dexter.Text = "Dexter";
            this.dexter.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.Location = new System.Drawing.Point(113, 105);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(75, 23);
            this.medium.TabIndex = 2;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.medium);
            this.Controls.Add(this.dexter);
            this.Controls.Add(this.sinister);
            this.Name = "Form1";
            this.Text = "Latin Translator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sinister;
        private System.Windows.Forms.Button dexter;
        private System.Windows.Forms.Button medium;
    }
}


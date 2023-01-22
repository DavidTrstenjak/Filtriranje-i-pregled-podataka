namespace bibliotekaDavid
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
            this.btnUpis = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpis
            // 
            this.btnUpis.Location = new System.Drawing.Point(12, 12);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(226, 96);
            this.btnUpis.TabIndex = 0;
            this.btnUpis.Text = "UPIS";
            this.btnUpis.UseVisualStyleBackColor = true;
            this.btnUpis.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.Location = new System.Drawing.Point(12, 123);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(226, 96);
            this.btnPregled.TabIndex = 1;
            this.btnPregled.Text = "PREGLED";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(12, 236);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(226, 96);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "PRETRAGA";
            this.btnPretraga.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 347);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnUpis);
            this.Name = "Form1";
            this.Text = "BIBLIOTEKA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnPretraga;
    }
}


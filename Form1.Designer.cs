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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnUpis = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpis
            // 
            this.btnUpis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnUpis.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpis.Location = new System.Drawing.Point(773, 212);
            this.btnUpis.Name = "btnUpis";
            this.btnUpis.Size = new System.Drawing.Size(375, 173);
            this.btnUpis.TabIndex = 0;
            this.btnUpis.Text = "REGISTRIRAJ KORISNIKA";
            this.btnUpis.UseVisualStyleBackColor = false;
            this.btnUpis.Click += new System.EventHandler(this.btnUpis_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPregled.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPregled.Location = new System.Drawing.Point(773, 443);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(375, 173);
            this.btnPregled.TabIndex = 1;
            this.btnPregled.Text = "PREGLED";
            this.btnPregled.UseVisualStyleBackColor = false;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPretraga.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPretraga.Location = new System.Drawing.Point(773, 676);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(375, 173);
            this.btnPretraga.TabIndex = 2;
            this.btnPretraga.Text = "POSUDI KNJIGU";
            this.btnPretraga.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(758, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 90);
            this.label1.TabIndex = 3;
            this.label1.Text = "Book Helper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnUpis);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BOOK HELPER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpis;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label1;
    }
}


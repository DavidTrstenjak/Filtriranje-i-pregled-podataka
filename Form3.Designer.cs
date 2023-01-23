namespace bibliotekaDavid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.richTextBoxIspisKorisnik = new System.Windows.Forms.RichTextBox();
            this.textBoxIDkorisnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUcitajKorisnik = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIDknjige = new System.Windows.Forms.TextBox();
            this.richTextBoxIspisKnjiga = new System.Windows.Forms.RichTextBox();
            this.buttonUcitajKnjiga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxIspisKorisnik
            // 
            this.richTextBoxIspisKorisnik.Location = new System.Drawing.Point(12, 104);
            this.richTextBoxIspisKorisnik.Name = "richTextBoxIspisKorisnik";
            this.richTextBoxIspisKorisnik.Size = new System.Drawing.Size(211, 186);
            this.richTextBoxIspisKorisnik.TabIndex = 0;
            this.richTextBoxIspisKorisnik.Text = "";
            // 
            // textBoxIDkorisnika
            // 
            this.textBoxIDkorisnika.Location = new System.Drawing.Point(13, 73);
            this.textBoxIDkorisnika.Name = "textBoxIDkorisnika";
            this.textBoxIDkorisnika.Size = new System.Drawing.Size(210, 20);
            this.textBoxIDkorisnika.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upiši ime korisnika : ";
            // 
            // buttonUcitajKorisnik
            // 
            this.buttonUcitajKorisnik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUcitajKorisnik.Location = new System.Drawing.Point(32, 296);
            this.buttonUcitajKorisnik.Name = "buttonUcitajKorisnik";
            this.buttonUcitajKorisnik.Size = new System.Drawing.Size(154, 62);
            this.buttonUcitajKorisnik.TabIndex = 3;
            this.buttonUcitajKorisnik.Text = "PRONAĐI KORISNIKA";
            this.buttonUcitajKorisnik.UseVisualStyleBackColor = false;
            this.buttonUcitajKorisnik.Click += new System.EventHandler(this.buttonUcitajKorisnik_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upiši naziv knjige :";
            // 
            // textBoxIDknjige
            // 
            this.textBoxIDknjige.Location = new System.Drawing.Point(322, 73);
            this.textBoxIDknjige.Name = "textBoxIDknjige";
            this.textBoxIDknjige.Size = new System.Drawing.Size(211, 20);
            this.textBoxIDknjige.TabIndex = 5;
            // 
            // richTextBoxIspisKnjiga
            // 
            this.richTextBoxIspisKnjiga.Location = new System.Drawing.Point(322, 104);
            this.richTextBoxIspisKnjiga.Name = "richTextBoxIspisKnjiga";
            this.richTextBoxIspisKnjiga.Size = new System.Drawing.Size(211, 186);
            this.richTextBoxIspisKnjiga.TabIndex = 6;
            this.richTextBoxIspisKnjiga.Text = "";
            // 
            // buttonUcitajKnjiga
            // 
            this.buttonUcitajKnjiga.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUcitajKnjiga.Location = new System.Drawing.Point(349, 296);
            this.buttonUcitajKnjiga.Name = "buttonUcitajKnjiga";
            this.buttonUcitajKnjiga.Size = new System.Drawing.Size(154, 62);
            this.buttonUcitajKnjiga.TabIndex = 7;
            this.buttonUcitajKnjiga.Text = "PRONAĐI KNJIGU";
            this.buttonUcitajKnjiga.UseVisualStyleBackColor = false;
            this.buttonUcitajKnjiga.Click += new System.EventHandler(this.buttonUcitajKnjiga_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 450);
            this.Controls.Add(this.buttonUcitajKnjiga);
            this.Controls.Add(this.richTextBoxIspisKnjiga);
            this.Controls.Add(this.textBoxIDknjige);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUcitajKorisnik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDkorisnika);
            this.Controls.Add(this.richTextBoxIspisKorisnik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "PREGLED";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxIspisKorisnik;
        private System.Windows.Forms.TextBox textBoxIDkorisnika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUcitajKorisnik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIDknjige;
        private System.Windows.Forms.RichTextBox richTextBoxIspisKnjiga;
        private System.Windows.Forms.Button buttonUcitajKnjiga;
    }
}
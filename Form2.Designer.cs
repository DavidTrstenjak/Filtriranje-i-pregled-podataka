namespace bibliotekaDavid
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxImeKorisnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxIDkorisnika = new System.Windows.Forms.TextBox();
            this.textBoxIDknjige = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUnesiPodatke = new System.Windows.Forms.Button();
            this.buttonPosudiKnjigu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "NOVI KORISNIK",
            "STARI KORISNIK"});
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime korisnika :";
            this.label1.Visible = false;
            // 
            // textBoxImeKorisnika
            // 
            this.textBoxImeKorisnika.Location = new System.Drawing.Point(12, 120);
            this.textBoxImeKorisnika.Name = "textBoxImeKorisnika";
            this.textBoxImeKorisnika.Size = new System.Drawing.Size(173, 20);
            this.textBoxImeKorisnika.TabIndex = 2;
            this.textBoxImeKorisnika.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime korisnika :";
            this.label2.Visible = false;
            // 
            // textBoxPrezimeKorisnika
            // 
            this.textBoxPrezimeKorisnika.Location = new System.Drawing.Point(12, 184);
            this.textBoxPrezimeKorisnika.Name = "textBoxPrezimeKorisnika";
            this.textBoxPrezimeKorisnika.Size = new System.Drawing.Size(170, 20);
            this.textBoxPrezimeKorisnika.TabIndex = 4;
            this.textBoxPrezimeKorisnika.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Datum posuđivanja :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(323, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(554, 120);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum vraćanja :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID korisnika :";
            // 
            // textBoxIDkorisnika
            // 
            this.textBoxIDkorisnika.Location = new System.Drawing.Point(12, 247);
            this.textBoxIDkorisnika.Name = "textBoxIDkorisnika";
            this.textBoxIDkorisnika.Size = new System.Drawing.Size(170, 20);
            this.textBoxIDkorisnika.TabIndex = 10;
            // 
            // textBoxIDknjige
            // 
            this.textBoxIDknjige.Location = new System.Drawing.Point(12, 321);
            this.textBoxIDknjige.Name = "textBoxIDknjige";
            this.textBoxIDknjige.Size = new System.Drawing.Size(170, 20);
            this.textBoxIDknjige.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID knjige :";
            // 
            // buttonUnesiPodatke
            // 
            this.buttonUnesiPodatke.Location = new System.Drawing.Point(467, 286);
            this.buttonUnesiPodatke.Name = "buttonUnesiPodatke";
            this.buttonUnesiPodatke.Size = new System.Drawing.Size(133, 57);
            this.buttonUnesiPodatke.TabIndex = 13;
            this.buttonUnesiPodatke.Text = "REGISTRIRAJ KORISNIKA";
            this.buttonUnesiPodatke.UseVisualStyleBackColor = true;
            this.buttonUnesiPodatke.Visible = false;
            this.buttonUnesiPodatke.Click += new System.EventHandler(this.buttonUnesiPodatke_Click);
            // 
            // buttonPosudiKnjigu
            // 
            this.buttonPosudiKnjigu.Location = new System.Drawing.Point(621, 286);
            this.buttonPosudiKnjigu.Name = "buttonPosudiKnjigu";
            this.buttonPosudiKnjigu.Size = new System.Drawing.Size(133, 55);
            this.buttonPosudiKnjigu.TabIndex = 14;
            this.buttonPosudiKnjigu.Text = "POSUDI KNJIGU";
            this.buttonPosudiKnjigu.UseVisualStyleBackColor = true;
            this.buttonPosudiKnjigu.Click += new System.EventHandler(this.buttonPosudiKnjigu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 355);
            this.Controls.Add(this.buttonPosudiKnjigu);
            this.Controls.Add(this.buttonUnesiPodatke);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxIDknjige);
            this.Controls.Add(this.textBoxIDkorisnika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPrezimeKorisnika);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxImeKorisnika);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "UPIS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxImeKorisnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezimeKorisnika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxIDkorisnika;
        private System.Windows.Forms.TextBox textBoxIDknjige;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUnesiPodatke;
        private System.Windows.Forms.Button buttonPosudiKnjigu;
    }
}
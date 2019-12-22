namespace Pole
{
    partial class Color
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
            this.btmzamk1 = new System.Windows.Forms.Button();
            this.btmzamk2 = new System.Windows.Forms.Button();
            this.labelkomunikat = new System.Windows.Forms.Label();
            this.labelbok = new System.Windows.Forms.Label();
            this.btmpokaz = new System.Windows.Forms.Button();
            this.txtbok = new System.Windows.Forms.TextBox();
            this.btmkolor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btmzamk1
            // 
            this.btmzamk1.Location = new System.Drawing.Point(31, 303);
            this.btmzamk1.Name = "btmzamk1";
            this.btmzamk1.Size = new System.Drawing.Size(99, 35);
            this.btmzamk1.TabIndex = 0;
            this.btmzamk1.Text = "Zamknij";
            this.btmzamk1.UseVisualStyleBackColor = true;
            this.btmzamk1.Click += new System.EventHandler(this.btmzamk1_Click);
            // 
            // btmzamk2
            // 
            this.btmzamk2.Location = new System.Drawing.Point(320, 303);
            this.btmzamk2.Name = "btmzamk2";
            this.btmzamk2.Size = new System.Drawing.Size(103, 35);
            this.btmzamk2.TabIndex = 1;
            this.btmzamk2.Text = "Zamknij Aplikacje";
            this.btmzamk2.UseVisualStyleBackColor = true;
            this.btmzamk2.Click += new System.EventHandler(this.btmzamk2_Click);
            // 
            // labelkomunikat
            // 
            this.labelkomunikat.AutoSize = true;
            this.labelkomunikat.ForeColor = System.Drawing.Color.Red;
            this.labelkomunikat.Location = new System.Drawing.Point(28, 46);
            this.labelkomunikat.Name = "labelkomunikat";
            this.labelkomunikat.Size = new System.Drawing.Size(0, 13);
            this.labelkomunikat.TabIndex = 2;
            this.labelkomunikat.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelbok
            // 
            this.labelbok.AutoSize = true;
            this.labelbok.Location = new System.Drawing.Point(49, 85);
            this.labelbok.Name = "labelbok";
            this.labelbok.Size = new System.Drawing.Size(26, 13);
            this.labelbok.TabIndex = 3;
            this.labelbok.Text = "Bok";
            // 
            // btmpokaz
            // 
            this.btmpokaz.Location = new System.Drawing.Point(90, 118);
            this.btmpokaz.Name = "btmpokaz";
            this.btmpokaz.Size = new System.Drawing.Size(100, 23);
            this.btmpokaz.TabIndex = 4;
            this.btmpokaz.Text = "Pokaz / Ukryj";
            this.btmpokaz.UseVisualStyleBackColor = true;
            // 
            // txtbok
            // 
            this.txtbok.Location = new System.Drawing.Point(90, 82);
            this.txtbok.Name = "txtbok";
            this.txtbok.Size = new System.Drawing.Size(100, 20);
            this.txtbok.TabIndex = 5;
            this.txtbok.TextChanged += new System.EventHandler(this.txtbok_TextChanged);
            // 
            // btmkolor
            // 
            this.btmkolor.Location = new System.Drawing.Point(90, 157);
            this.btmkolor.Name = "btmkolor";
            this.btmkolor.Size = new System.Drawing.Size(100, 23);
            this.btmkolor.TabIndex = 6;
            this.btmkolor.Text = "Zmien kolor";
            this.btmkolor.UseVisualStyleBackColor = true;
            this.btmkolor.Click += new System.EventHandler(this.btmkolor_Click);
            // 
            // panel1
            // 
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(223, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(0, 0);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 384);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btmkolor);
            this.Controls.Add(this.txtbok);
            this.Controls.Add(this.btmpokaz);
            this.Controls.Add(this.labelbok);
            this.Controls.Add(this.labelkomunikat);
            this.Controls.Add(this.btmzamk2);
            this.Controls.Add(this.btmzamk1);
            this.Name = "Color";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmzamk1;
        private System.Windows.Forms.Button btmzamk2;
        private System.Windows.Forms.Label labelkomunikat;
        private System.Windows.Forms.Label labelbok;
        private System.Windows.Forms.Button btmpokaz;
        private System.Windows.Forms.TextBox txtbok;
        private System.Windows.Forms.Button btmkolor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}
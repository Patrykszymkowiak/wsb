namespace Pole
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelbok = new System.Windows.Forms.Label();
            this.labelpole = new System.Windows.Forms.Label();
            this.labelobwod = new System.Windows.Forms.Label();
            this.labelkomunikat = new System.Windows.Forms.Label();
            this.btmclear = new System.Windows.Forms.Button();
            this.btmzamknij = new System.Windows.Forms.Button();
            this.txtbok = new System.Windows.Forms.TextBox();
            this.txtpole = new System.Windows.Forms.TextBox();
            this.txtobwod = new System.Windows.Forms.TextBox();
            this.btmkolor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelbok
            // 
            this.labelbok.AutoSize = true;
            this.labelbok.Location = new System.Drawing.Point(27, 47);
            this.labelbok.Name = "labelbok";
            this.labelbok.Size = new System.Drawing.Size(26, 13);
            this.labelbok.TabIndex = 0;
            this.labelbok.Text = "Bok";
            this.labelbok.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelpole
            // 
            this.labelpole.AutoSize = true;
            this.labelpole.Location = new System.Drawing.Point(27, 104);
            this.labelpole.Name = "labelpole";
            this.labelpole.Size = new System.Drawing.Size(28, 13);
            this.labelpole.TabIndex = 1;
            this.labelpole.Text = "Pole";
            this.labelpole.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelobwod
            // 
            this.labelobwod.AutoSize = true;
            this.labelobwod.Location = new System.Drawing.Point(27, 164);
            this.labelobwod.Name = "labelobwod";
            this.labelobwod.Size = new System.Drawing.Size(41, 13);
            this.labelobwod.TabIndex = 2;
            this.labelobwod.Text = "Obwod";
            // 
            // labelkomunikat
            // 
            this.labelkomunikat.AutoSize = true;
            this.labelkomunikat.ForeColor = System.Drawing.Color.Red;
            this.labelkomunikat.Location = new System.Drawing.Point(213, 47);
            this.labelkomunikat.Name = "labelkomunikat";
            this.labelkomunikat.Size = new System.Drawing.Size(0, 13);
            this.labelkomunikat.TabIndex = 3;
            // 
            // btmclear
            // 
            this.btmclear.Location = new System.Drawing.Point(30, 249);
            this.btmclear.Name = "btmclear";
            this.btmclear.Size = new System.Drawing.Size(75, 23);
            this.btmclear.TabIndex = 5;
            this.btmclear.Text = "Wyczysc";
            this.btmclear.UseVisualStyleBackColor = true;
            this.btmclear.Click += new System.EventHandler(this.btmclear_Click);
            // 
            // btmzamknij
            // 
            this.btmzamknij.Location = new System.Drawing.Point(169, 249);
            this.btmzamknij.Name = "btmzamknij";
            this.btmzamknij.Size = new System.Drawing.Size(75, 23);
            this.btmzamknij.TabIndex = 6;
            this.btmzamknij.Text = "Zamknij";
            this.btmzamknij.UseVisualStyleBackColor = true;
            this.btmzamknij.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbok
            // 
            this.txtbok.Location = new System.Drawing.Point(85, 40);
            this.txtbok.Name = "txtbok";
            this.txtbok.Size = new System.Drawing.Size(100, 20);
            this.txtbok.TabIndex = 7;
            this.txtbok.TextChanged += new System.EventHandler(this.txtbok_TextChanged);
            // 
            // txtpole
            // 
            this.txtpole.Location = new System.Drawing.Point(85, 101);
            this.txtpole.Name = "txtpole";
            this.txtpole.Size = new System.Drawing.Size(100, 20);
            this.txtpole.TabIndex = 8;
            this.txtpole.TextChanged += new System.EventHandler(this.txtpole_TextChanged);
            // 
            // txtobwod
            // 
            this.txtobwod.Location = new System.Drawing.Point(85, 157);
            this.txtobwod.Name = "txtobwod";
            this.txtobwod.Size = new System.Drawing.Size(100, 20);
            this.txtobwod.TabIndex = 9;
            this.txtobwod.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btmkolor
            // 
            this.btmkolor.Location = new System.Drawing.Point(85, 193);
            this.btmkolor.Name = "btmkolor";
            this.btmkolor.Size = new System.Drawing.Size(100, 23);
            this.btmkolor.TabIndex = 10;
            this.btmkolor.Text = "Kolor";
            this.btmkolor.UseVisualStyleBackColor = true;
            this.btmkolor.Click += new System.EventHandler(this.btmkolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 470);
            this.Controls.Add(this.btmkolor);
            this.Controls.Add(this.txtobwod);
            this.Controls.Add(this.txtpole);
            this.Controls.Add(this.txtbok);
            this.Controls.Add(this.btmzamknij);
            this.Controls.Add(this.btmclear);
            this.Controls.Add(this.labelkomunikat);
            this.Controls.Add(this.labelobwod);
            this.Controls.Add(this.labelpole);
            this.Controls.Add(this.labelbok);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pole i obwod";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelbok;
        private System.Windows.Forms.Label labelpole;
        private System.Windows.Forms.Label labelobwod;
        private System.Windows.Forms.Label labelkomunikat;
        private System.Windows.Forms.Button btmclear;
        private System.Windows.Forms.Button btmzamknij;
        private System.Windows.Forms.TextBox txtbok;
        private System.Windows.Forms.TextBox txtpole;
        private System.Windows.Forms.TextBox txtobwod;
        private System.Windows.Forms.Button btmkolor;
    }
}


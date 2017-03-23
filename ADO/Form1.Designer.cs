namespace ADO
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCO = new System.Windows.Forms.Button();
            this.buttonSQL = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxAnzeige = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxArtikelGruppe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCO
            // 
            this.buttonCO.Location = new System.Drawing.Point(21, 27);
            this.buttonCO.Name = "buttonCO";
            this.buttonCO.Size = new System.Drawing.Size(173, 46);
            this.buttonCO.TabIndex = 0;
            this.buttonCO.Text = "Connection öffnen";
            this.buttonCO.UseVisualStyleBackColor = true;
            this.buttonCO.Click += new System.EventHandler(this.buttonCO_Click);
            // 
            // buttonSQL
            // 
            this.buttonSQL.Location = new System.Drawing.Point(21, 88);
            this.buttonSQL.Name = "buttonSQL";
            this.buttonSQL.Size = new System.Drawing.Size(174, 40);
            this.buttonSQL.TabIndex = 1;
            this.buttonSQL.Text = "SQL - Command";
            this.buttonSQL.UseVisualStyleBackColor = true;
            this.buttonSQL.Click += new System.EventHandler(this.buttonSQL_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(21, 144);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(173, 37);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "auslesen";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxAnzeige
            // 
            this.listBoxAnzeige.FormattingEnabled = true;
            this.listBoxAnzeige.Location = new System.Drawing.Point(24, 214);
            this.listBoxAnzeige.Name = "listBoxAnzeige";
            this.listBoxAnzeige.Size = new System.Drawing.Size(281, 134);
            this.listBoxAnzeige.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Artikelgruppe";
            // 
            // textBoxArtikelGruppe
            // 
            this.textBoxArtikelGruppe.Location = new System.Drawing.Point(218, 88);
            this.textBoxArtikelGruppe.Name = "textBoxArtikelGruppe";
            this.textBoxArtikelGruppe.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtikelGruppe.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 369);
            this.Controls.Add(this.textBoxArtikelGruppe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxAnzeige);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonSQL);
            this.Controls.Add(this.buttonCO);
            this.Name = "Form1";
            this.Text = "ADO Beispiel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCO;
        private System.Windows.Forms.Button buttonSQL;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxAnzeige;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxArtikelGruppe;
    }
}


namespace Gonella
{
    partial class frmGonella
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGonella = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtAnnoProduzione = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTelaio = new System.Windows.Forms.ComboBox();
            this.cmbCilindrata = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInserisci = new System.Windows.Forms.Button();
            this.btnVendi = new System.Windows.Forms.Button();
            this.btnTotale = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBici = new System.Windows.Forms.RadioButton();
            this.rdbMoto = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGonella)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGonella
            // 
            this.dgvGonella.AllowUserToAddRows = false;
            this.dgvGonella.AllowUserToDeleteRows = false;
            this.dgvGonella.AllowUserToResizeColumns = false;
            this.dgvGonella.AllowUserToResizeRows = false;
            this.dgvGonella.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGonella.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGonella.Location = new System.Drawing.Point(296, 12);
            this.dgvGonella.Name = "dgvGonella";
            this.dgvGonella.Size = new System.Drawing.Size(492, 426);
            this.dgvGonella.TabIndex = 0;
            this.dgvGonella.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGonella_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(55, 12);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 20);
            this.txtMarca.TabIndex = 2;
            // 
            // txtAnnoProduzione
            // 
            this.txtAnnoProduzione.Location = new System.Drawing.Point(106, 48);
            this.txtAnnoProduzione.Name = "txtAnnoProduzione";
            this.txtAnnoProduzione.Size = new System.Drawing.Size(100, 20);
            this.txtAnnoProduzione.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anno Produzione";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(53, 85);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 20);
            this.txtCosto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telaio";
            // 
            // cmbTelaio
            // 
            this.cmbTelaio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTelaio.FormattingEnabled = true;
            this.cmbTelaio.Location = new System.Drawing.Point(53, 122);
            this.cmbTelaio.Name = "cmbTelaio";
            this.cmbTelaio.Size = new System.Drawing.Size(121, 21);
            this.cmbTelaio.TabIndex = 8;
            // 
            // cmbCilindrata
            // 
            this.cmbCilindrata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCilindrata.FormattingEnabled = true;
            this.cmbCilindrata.Location = new System.Drawing.Point(68, 149);
            this.cmbCilindrata.Name = "cmbCilindrata";
            this.cmbCilindrata.Size = new System.Drawing.Size(121, 21);
            this.cmbCilindrata.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cilindrata";
            // 
            // btnInserisci
            // 
            this.btnInserisci.Location = new System.Drawing.Point(12, 269);
            this.btnInserisci.Name = "btnInserisci";
            this.btnInserisci.Size = new System.Drawing.Size(75, 23);
            this.btnInserisci.TabIndex = 11;
            this.btnInserisci.Text = "Inserisci";
            this.btnInserisci.UseVisualStyleBackColor = true;
            this.btnInserisci.Click += new System.EventHandler(this.btnInserisci_Click);
            // 
            // btnVendi
            // 
            this.btnVendi.Location = new System.Drawing.Point(99, 269);
            this.btnVendi.Name = "btnVendi";
            this.btnVendi.Size = new System.Drawing.Size(75, 23);
            this.btnVendi.TabIndex = 12;
            this.btnVendi.Text = "Vendi";
            this.btnVendi.UseVisualStyleBackColor = true;
            this.btnVendi.Click += new System.EventHandler(this.btnVendi_Click);
            // 
            // btnTotale
            // 
            this.btnTotale.Location = new System.Drawing.Point(190, 269);
            this.btnTotale.Name = "btnTotale";
            this.btnTotale.Size = new System.Drawing.Size(75, 23);
            this.btnTotale.TabIndex = 13;
            this.btnTotale.Text = "Totale";
            this.btnTotale.UseVisualStyleBackColor = true;
            this.btnTotale.Click += new System.EventHandler(this.btnTotale_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMoto);
            this.groupBox1.Controls.Add(this.rdbBici);
            this.groupBox1.Location = new System.Drawing.Point(15, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(78, 72);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo";
            // 
            // rdbBici
            // 
            this.rdbBici.AutoSize = true;
            this.rdbBici.Checked = true;
            this.rdbBici.Location = new System.Drawing.Point(13, 19);
            this.rdbBici.Name = "rdbBici";
            this.rdbBici.Size = new System.Drawing.Size(42, 17);
            this.rdbBici.TabIndex = 0;
            this.rdbBici.TabStop = true;
            this.rdbBici.Text = "Bici";
            this.rdbBici.UseVisualStyleBackColor = true;
            // 
            // rdbMoto
            // 
            this.rdbMoto.AutoSize = true;
            this.rdbMoto.Location = new System.Drawing.Point(13, 42);
            this.rdbMoto.Name = "rdbMoto";
            this.rdbMoto.Size = new System.Drawing.Size(49, 17);
            this.rdbMoto.TabIndex = 1;
            this.rdbMoto.Text = "Moto";
            this.rdbMoto.UseVisualStyleBackColor = true;
            // 
            // frmGonella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTotale);
            this.Controls.Add(this.btnVendi);
            this.Controls.Add(this.btnInserisci);
            this.Controls.Add(this.cmbCilindrata);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTelaio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAnnoProduzione);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvGonella);
            this.Name = "frmGonella";
            this.Text = "GONELLA";
            this.Load += new System.EventHandler(this.frmGonella_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGonella)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGonella;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtAnnoProduzione;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTelaio;
        private System.Windows.Forms.ComboBox cmbCilindrata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnInserisci;
        private System.Windows.Forms.Button btnVendi;
        private System.Windows.Forms.Button btnTotale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMoto;
        private System.Windows.Forms.RadioButton rdbBici;
    }
}


namespace SQLiteToEntitiesMapper
{
    partial class Form1
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
            this.button_sel_file = new System.Windows.Forms.Button();
            this.label_file = new System.Windows.Forms.Label();
            this.label_cartella = new System.Windows.Forms.Label();
            this.button_sel_cartella = new System.Windows.Forms.Button();
            this.label_namespace = new System.Windows.Forms.Label();
            this.textBox_namespace = new System.Windows.Forms.TextBox();
            this.button_genera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sel_file
            // 
            this.button_sel_file.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sel_file.Location = new System.Drawing.Point(362, 33);
            this.button_sel_file.Name = "button_sel_file";
            this.button_sel_file.Size = new System.Drawing.Size(86, 27);
            this.button_sel_file.TabIndex = 0;
            this.button_sel_file.Text = "Seleziona";
            this.button_sel_file.UseVisualStyleBackColor = true;
            this.button_sel_file.Click += new System.EventHandler(this.button_sel_file_Click);
            // 
            // label_file
            // 
            this.label_file.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_file.Location = new System.Drawing.Point(24, 33);
            this.label_file.Name = "label_file";
            this.label_file.Size = new System.Drawing.Size(272, 40);
            this.label_file.TabIndex = 1;
            this.label_file.Text = "Seleziona file database SQLite";
            // 
            // label_cartella
            // 
            this.label_cartella.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_cartella.Location = new System.Drawing.Point(24, 73);
            this.label_cartella.Name = "label_cartella";
            this.label_cartella.Size = new System.Drawing.Size(272, 40);
            this.label_cartella.TabIndex = 3;
            this.label_cartella.Text = "Seleziona cartella di output";
            // 
            // button_sel_cartella
            // 
            this.button_sel_cartella.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sel_cartella.Location = new System.Drawing.Point(362, 73);
            this.button_sel_cartella.Name = "button_sel_cartella";
            this.button_sel_cartella.Size = new System.Drawing.Size(86, 27);
            this.button_sel_cartella.TabIndex = 2;
            this.button_sel_cartella.Text = "Seleziona";
            this.button_sel_cartella.UseVisualStyleBackColor = true;
            this.button_sel_cartella.Click += new System.EventHandler(this.button_sel_cartella_Click);
            // 
            // label_namespace
            // 
            this.label_namespace.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_namespace.Location = new System.Drawing.Point(24, 113);
            this.label_namespace.Name = "label_namespace";
            this.label_namespace.Size = new System.Drawing.Size(295, 40);
            this.label_namespace.TabIndex = 5;
            this.label_namespace.Text = "Seleziona namespace (opzionale)";
            // 
            // textBox_namespace
            // 
            this.textBox_namespace.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_namespace.Location = new System.Drawing.Point(337, 113);
            this.textBox_namespace.Name = "textBox_namespace";
            this.textBox_namespace.Size = new System.Drawing.Size(136, 33);
            this.textBox_namespace.TabIndex = 6;
            // 
            // button_genera
            // 
            this.button_genera.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_genera.Location = new System.Drawing.Point(399, 164);
            this.button_genera.Name = "button_genera";
            this.button_genera.Size = new System.Drawing.Size(90, 32);
            this.button_genera.TabIndex = 7;
            this.button_genera.Text = "Genera";
            this.button_genera.UseVisualStyleBackColor = true;
            this.button_genera.Click += new System.EventHandler(this.button_genera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(518, 203);
            this.Controls.Add(this.button_genera);
            this.Controls.Add(this.textBox_namespace);
            this.Controls.Add(this.label_namespace);
            this.Controls.Add(this.label_cartella);
            this.Controls.Add(this.button_sel_cartella);
            this.Controls.Add(this.label_file);
            this.Controls.Add(this.button_sel_file);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_sel_file;
        private System.Windows.Forms.Label label_file;
        private System.Windows.Forms.Label label_cartella;
        private System.Windows.Forms.Button button_sel_cartella;
        private System.Windows.Forms.Label label_namespace;
        private System.Windows.Forms.TextBox textBox_namespace;
        private System.Windows.Forms.Button button_genera;
    }
}


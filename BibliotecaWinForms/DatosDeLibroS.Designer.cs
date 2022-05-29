namespace BibliotecaWinForms
{
    partial class DatosDeLibroS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAgregarDatos = new CustomControls.RJControls.RJButton();
            this.btnCancelar = new CustomControls.RJControls.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(684, 188);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnAgregarDatos
            // 
            this.btnAgregarDatos.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarDatos.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnAgregarDatos.BorderColor = System.Drawing.Color.LightGray;
            this.btnAgregarDatos.BorderRadius = 20;
            this.btnAgregarDatos.BorderSize = 0;
            this.btnAgregarDatos.FlatAppearance.BorderSize = 0;
            this.btnAgregarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarDatos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregarDatos.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarDatos.Location = new System.Drawing.Point(440, 206);
            this.btnAgregarDatos.Name = "btnAgregarDatos";
            this.btnAgregarDatos.Size = new System.Drawing.Size(125, 41);
            this.btnAgregarDatos.TabIndex = 12;
            this.btnAgregarDatos.Text = "ACEPTAR";
            this.btnAgregarDatos.TextColor = System.Drawing.Color.Black;
            this.btnAgregarDatos.UseVisualStyleBackColor = false;
            this.btnAgregarDatos.Click += new System.EventHandler(this.btnAgregarDatos_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancelar.BorderRadius = 20;
            this.btnCancelar.BorderSize = 0;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(571, 205);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 41);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "CANCELAR\r\n";
            this.btnCancelar.TextColor = System.Drawing.Color.Black;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // DatosDeLibroS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 258);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DatosDeLibroS";
            this.Text = "DatosDeLibro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DatosDeLibroS_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.RJControls.RJButton btnAgregarDatos;
        public System.Windows.Forms.DataGridView dataGridView1;
        private CustomControls.RJControls.RJButton btnCancelar;
    }
}
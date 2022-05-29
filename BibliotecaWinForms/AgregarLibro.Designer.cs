namespace BibliotecaWinForms
{
    partial class AgregarLibro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreL = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAñoP = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.btnAgregarL = new CustomControls.RJControls.RJButton();
            this.btnCerrar = new CustomControls.RJControls.RJButton();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE DEL LIBRO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "AUTOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "GENERO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "AÑO DE PUBICACION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 267);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 4;
            // 
            // txtNombreL
            // 
            this.txtNombreL.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtNombreL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombreL.Location = new System.Drawing.Point(23, 40);
            this.txtNombreL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreL.Name = "txtNombreL";
            this.txtNombreL.Size = new System.Drawing.Size(201, 30);
            this.txtNombreL.TabIndex = 5;
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAutor.Location = new System.Drawing.Point(23, 105);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(201, 30);
            this.txtAutor.TabIndex = 6;
            // 
            // txtAñoP
            // 
            this.txtAñoP.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtAñoP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAñoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAñoP.Location = new System.Drawing.Point(23, 229);
            this.txtAñoP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAñoP.Name = "txtAñoP";
            this.txtAñoP.Size = new System.Drawing.Size(201, 30);
            this.txtAñoP.TabIndex = 8;
            // 
            // cbGenero
            // 
            this.cbGenero.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.cbGenero.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbGenero.Items.AddRange(new object[] {
            "CIENCIA Y TEGNOLOGIA",
            "ROMANCE",
            "TERROR"});
            this.cbGenero.Location = new System.Drawing.Point(23, 164);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(201, 31);
            this.cbGenero.TabIndex = 10;
            // 
            // btnAgregarL
            // 
            this.btnAgregarL.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregarL.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnAgregarL.BorderColor = System.Drawing.Color.LightGray;
            this.btnAgregarL.BorderRadius = 20;
            this.btnAgregarL.BorderSize = 0;
            this.btnAgregarL.FlatAppearance.BorderSize = 0;
            this.btnAgregarL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarL.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarL.Location = new System.Drawing.Point(2, 338);
            this.btnAgregarL.Name = "btnAgregarL";
            this.btnAgregarL.Size = new System.Drawing.Size(118, 39);
            this.btnAgregarL.TabIndex = 11;
            this.btnAgregarL.Text = "AGREGAR";
            this.btnAgregarL.TextColor = System.Drawing.Color.Black;
            this.btnAgregarL.UseVisualStyleBackColor = false;
            this.btnAgregarL.Click += new System.EventHandler(this.btnAgregarL_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.LightGray;
            this.btnCerrar.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnCerrar.BorderColor = System.Drawing.Color.LightGray;
            this.btnCerrar.BorderRadius = 20;
            this.btnCerrar.BorderSize = 0;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(126, 338);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(118, 39);
            this.btnCerrar.TabIndex = 12;
            this.btnCerrar.Text = "CERRAR";
            this.btnCerrar.TextColor = System.Drawing.Color.Black;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.txtUrl.Location = new System.Drawing.Point(23, 302);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(201, 30);
            this.txtUrl.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(23, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "URL DE IMAGEN";
            // 
            // AgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 389);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAgregarL);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.txtAñoP);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtNombreL);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AgregarLibro";
            this.Text = "AgregarLibro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AgregarLibro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreL;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAñoP;
        private CustomControls.RJControls.RJButton btnAgregarL;
        private CustomControls.RJControls.RJButton btnCerrar;
        public System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label6;
    }
}
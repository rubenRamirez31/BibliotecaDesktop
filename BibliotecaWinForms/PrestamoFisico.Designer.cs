namespace BibliotecaWinForms
{
    partial class PrestamoFisico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamoFisico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPrestamoPrecencial = new System.Windows.Forms.PictureBox();
            this.pbEnvios = new System.Windows.Forms.PictureBox();
            this.pbSolicitudes = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtColonia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAceptarLibro = new CustomControls.RJControls.RJButton();
            this.lblID = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rjButton2 = new CustomControls.RJControls.RJButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarPres = new CustomControls.RJControls.RJButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamoPrecencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPrestamoPrecencial);
            this.panel1.Controls.Add(this.pbEnvios);
            this.panel1.Controls.Add(this.pbSolicitudes);
            this.panel1.Controls.Add(this.pbMenu);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 185);
            this.panel1.TabIndex = 1;
            // 
            // pbPrestamoPrecencial
            // 
            this.pbPrestamoPrecencial.Image = global::BibliotecaWinForms.Properties.Resources.PrestamoPresencial;
            this.pbPrestamoPrecencial.Location = new System.Drawing.Point(3, 135);
            this.pbPrestamoPrecencial.Name = "pbPrestamoPrecencial";
            this.pbPrestamoPrecencial.Size = new System.Drawing.Size(49, 38);
            this.pbPrestamoPrecencial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrestamoPrecencial.TabIndex = 3;
            this.pbPrestamoPrecencial.TabStop = false;
            // 
            // pbEnvios
            // 
            this.pbEnvios.Image = global::BibliotecaWinForms.Properties.Resources.Envios;
            this.pbEnvios.Location = new System.Drawing.Point(3, 91);
            this.pbEnvios.Name = "pbEnvios";
            this.pbEnvios.Size = new System.Drawing.Size(40, 38);
            this.pbEnvios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEnvios.TabIndex = 2;
            this.pbEnvios.TabStop = false;
            // 
            // pbSolicitudes
            // 
            this.pbSolicitudes.Image = global::BibliotecaWinForms.Properties.Resources.Solicitudes;
            this.pbSolicitudes.Location = new System.Drawing.Point(3, 47);
            this.pbSolicitudes.Name = "pbSolicitudes";
            this.pbSolicitudes.Size = new System.Drawing.Size(40, 38);
            this.pbSolicitudes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSolicitudes.TabIndex = 1;
            this.pbSolicitudes.TabStop = false;
            this.pbSolicitudes.Click += new System.EventHandler(this.pbSolicitudes_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Image = global::BibliotecaWinForms.Properties.Resources.menu;
            this.pbMenu.Location = new System.Drawing.Point(3, 3);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(40, 38);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.pbMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "PRESTAMO PRESENCIAL";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnRegistrarPres);
            this.panel2.Controls.Add(this.txtNumero);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtColonia);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtContacto);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtCalle);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(60, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 272);
            this.panel2.TabIndex = 7;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNumero.Location = new System.Drawing.Point(337, 151);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(125, 30);
            this.txtNumero.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(337, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 23);
            this.label13.TabIndex = 15;
            this.label13.Text = "NUMERO:";
            // 
            // txtColonia
            // 
            this.txtColonia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtColonia.Location = new System.Drawing.Point(337, 225);
            this.txtColonia.Name = "txtColonia";
            this.txtColonia.Size = new System.Drawing.Size(209, 30);
            this.txtColonia.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(337, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 23);
            this.label12.TabIndex = 13;
            this.label12.Text = "COLONIA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(337, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 23);
            this.label11.TabIndex = 12;
            this.label11.Text = "CALLE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "CONTACTO:";
            // 
            // txtContacto
            // 
            this.txtContacto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtContacto.Location = new System.Drawing.Point(6, 199);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(161, 30);
            this.txtContacto.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(337, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "DATOS DE DIRECCION";
            // 
            // txtCalle
            // 
            this.txtCalle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCalle.Location = new System.Drawing.Point(337, 72);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(206, 30);
            this.txtCalle.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "NOMBRE COMPLETO:";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombre.Location = new System.Drawing.Point(5, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "AÑADIR SOLICITANTE";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnAceptarLibro);
            this.panel3.Controls.Add(this.lblID);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.rjButton2);
            this.panel3.Controls.Add(this.lblGenero);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.lblAño);
            this.panel3.Controls.Add(this.lblAutor);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(60, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 206);
            this.panel3.TabIndex = 8;
            // 
            // btnAceptarLibro
            // 
            this.btnAceptarLibro.BackColor = System.Drawing.Color.LightGray;
            this.btnAceptarLibro.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnAceptarLibro.BorderColor = System.Drawing.Color.LightGray;
            this.btnAceptarLibro.BorderRadius = 20;
            this.btnAceptarLibro.BorderSize = 0;
            this.btnAceptarLibro.FlatAppearance.BorderSize = 0;
            this.btnAceptarLibro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarLibro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAceptarLibro.ForeColor = System.Drawing.Color.Black;
            this.btnAceptarLibro.Location = new System.Drawing.Point(552, 155);
            this.btnAceptarLibro.Name = "btnAceptarLibro";
            this.btnAceptarLibro.Size = new System.Drawing.Size(188, 41);
            this.btnAceptarLibro.TabIndex = 16;
            this.btnAceptarLibro.Text = "ACEPTAR LIBRO";
            this.btnAceptarLibro.TextColor = System.Drawing.Color.Black;
            this.btnAceptarLibro.UseVisualStyleBackColor = false;
            this.btnAceptarLibro.Click += new System.EventHandler(this.btnAceptarLibro_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblID.Location = new System.Drawing.Point(5, 188);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 16);
            this.lblID.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(5, 164);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "ID:";
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.LightGray;
            this.rjButton2.BackgroundColor = System.Drawing.Color.LightGray;
            this.rjButton2.BorderColor = System.Drawing.Color.LightGray;
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjButton2.ForeColor = System.Drawing.Color.Black;
            this.rjButton2.Location = new System.Drawing.Point(295, 155);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(231, 41);
            this.rjButton2.TabIndex = 13;
            this.rjButton2.Text = "SELECCIONAR LIBRO";
            this.rjButton2.TextColor = System.Drawing.Color.Black;
            this.rjButton2.UseVisualStyleBackColor = false;
            this.rjButton2.Click += new System.EventHandler(this.rjButton2_Click);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblGenero.Location = new System.Drawing.Point(295, 76);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(45, 23);
            this.lblGenero.TabIndex = 12;
            this.lblGenero.Text = "-----";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(295, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 24);
            this.label14.TabIndex = 11;
            this.label14.Text = "GENERO:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAño.Location = new System.Drawing.Point(5, 132);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(45, 23);
            this.lblAño.TabIndex = 10;
            this.lblAño.Text = "-----";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblAutor.Location = new System.Drawing.Point(70, 132);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(45, 23);
            this.lblAutor.TabIndex = 9;
            this.lblAutor.Text = "-----";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblNombre.Location = new System.Drawing.Point(5, 77);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(45, 23);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "-----";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(5, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "AÑO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(70, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "AUTOR:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(5, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOMBRE DE LA OBRA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(5, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(221, 27);
            this.label7.TabIndex = 1;
            this.label7.Text = "DATOS DEL LIBRO";
            // 
            // btnRegistrarPres
            // 
            this.btnRegistrarPres.BackColor = System.Drawing.Color.LightGray;
            this.btnRegistrarPres.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnRegistrarPres.BorderColor = System.Drawing.Color.LightGray;
            this.btnRegistrarPres.BorderRadius = 20;
            this.btnRegistrarPres.BorderSize = 0;
            this.btnRegistrarPres.FlatAppearance.BorderSize = 0;
            this.btnRegistrarPres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPres.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrarPres.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarPres.Location = new System.Drawing.Point(605, 219);
            this.btnRegistrarPres.Name = "btnRegistrarPres";
            this.btnRegistrarPres.Size = new System.Drawing.Size(150, 41);
            this.btnRegistrarPres.TabIndex = 10;
            this.btnRegistrarPres.Text = "REGISTRAR";
            this.btnRegistrarPres.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarPres.UseVisualStyleBackColor = false;
            this.btnRegistrarPres.Click += new System.EventHandler(this.btnRegistrarPres_Click);
            // 
            // PrestamoFisico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(832, 535);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PrestamoFisico";
            this.Text = "PrestamoPresencial";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamoPrecencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPrestamoPrecencial;
        private System.Windows.Forms.PictureBox pbEnvios;
        private System.Windows.Forms.PictureBox pbSolicitudes;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private CustomControls.RJControls.RJButton rjButton2;
        public System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lblAño;
        public System.Windows.Forms.Label lblAutor;
        public System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label10;
        public CustomControls.RJControls.RJButton btnRegistrarPres;
        private CustomControls.RJControls.RJButton btnAceptarLibro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtColonia;
        private System.Windows.Forms.Label label12;
    }
}
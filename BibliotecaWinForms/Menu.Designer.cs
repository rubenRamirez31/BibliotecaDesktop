namespace BibliotecaWinForms
{
    partial class Menu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbPrestamoPrecencial = new System.Windows.Forms.PictureBox();
            this.pbEnvios = new System.Windows.Forms.PictureBox();
            this.pbSolicitudes = new System.Windows.Forms.PictureBox();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new CustomControls.RJControls.RJButton();
            this.btnEliminar = new CustomControls.RJControls.RJButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamoPrecencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPrestamoPrecencial);
            this.panel1.Controls.Add(this.pbEnvios);
            this.panel1.Controls.Add(this.pbSolicitudes);
            this.panel1.Controls.Add(this.pbMenu);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 185);
            this.panel1.TabIndex = 0;
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
            this.pbPrestamoPrecencial.Click += new System.EventHandler(this.pbPrestamoPrecencial_Click);
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
            this.pbEnvios.Click += new System.EventHandler(this.pbEnvios_Click);
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
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BibliotecaWinForms.Properties.Resources.cerrarsesion;
            this.pictureBox1.Location = new System.Drawing.Point(3, 410);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(745, 400);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "MENU";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGray;
            this.btnAgregar.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnAgregar.BorderColor = System.Drawing.Color.LightGray;
            this.btnAgregar.BorderRadius = 20;
            this.btnAgregar.BorderSize = 0;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(834, 319);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextColor = System.Drawing.Color.Black;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightGray;
            this.btnEliminar.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnEliminar.BorderColor = System.Drawing.Color.LightGray;
            this.btnEliminar.BorderRadius = 20;
            this.btnEliminar.BorderSize = 0;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(834, 380);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(125, 41);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextColor = System.Drawing.Color.Black;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(803, 47);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 241);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamoPrecencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbPrestamoPrecencial;
        private System.Windows.Forms.PictureBox pbEnvios;
        private System.Windows.Forms.PictureBox pbSolicitudes;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton btnAgregar;
        private CustomControls.RJControls.RJButton btnEliminar;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
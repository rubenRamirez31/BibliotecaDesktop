namespace BibliotecaWinForms
{
    partial class SolicitudesDePrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamoPrecencial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbPrestamoPrecencial);
            this.panel1.Controls.Add(this.pbEnvios);
            this.panel1.Controls.Add(this.pbSolicitudes);
            this.panel1.Controls.Add(this.pbMenu);
            this.panel1.Location = new System.Drawing.Point(1, 1);
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
            this.pbMenu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbMenu_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "SOLICITUDES DE PRESTAMOS";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(55, 37);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 401);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // SolicitudesDePrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "SolicitudesDePrestamo";
            this.Text = "SolicitudesDePrestamo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrestamoPrecencial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnvios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSolicitudes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
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
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
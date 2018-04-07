namespace Metal_Warriors
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.IniciarBoton = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.AcercadeBoton = new System.Windows.Forms.PictureBox();
            this.SalirBoton = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.IniciarBoton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcercadeBoton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirBoton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // IniciarBoton
            // 
            this.IniciarBoton.BackColor = System.Drawing.Color.Transparent;
            this.IniciarBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IniciarBoton.Image = global::Metal_Warriors.Properties.Resources.IniciarBoton;
            this.IniciarBoton.Location = new System.Drawing.Point(304, 347);
            this.IniciarBoton.Name = "IniciarBoton";
            this.IniciarBoton.Size = new System.Drawing.Size(297, 37);
            this.IniciarBoton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IniciarBoton.TabIndex = 1;
            this.IniciarBoton.TabStop = false;
            this.IniciarBoton.Click += new System.EventHandler(this.IniciarBoton_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = global::Metal_Warriors.Properties.Resources.Logo;
            this.Logo.Location = new System.Drawing.Point(241, 36);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(441, 236);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // AcercadeBoton
            // 
            this.AcercadeBoton.BackColor = System.Drawing.Color.Transparent;
            this.AcercadeBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AcercadeBoton.Image = global::Metal_Warriors.Properties.Resources.AcercaDeBoton;
            this.AcercadeBoton.Location = new System.Drawing.Point(360, 390);
            this.AcercadeBoton.Name = "AcercadeBoton";
            this.AcercadeBoton.Size = new System.Drawing.Size(195, 37);
            this.AcercadeBoton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AcercadeBoton.TabIndex = 3;
            this.AcercadeBoton.TabStop = false;
            this.AcercadeBoton.Click += new System.EventHandler(this.AcercadeBoton_Click);
            // 
            // SalirBoton
            // 
            this.SalirBoton.BackColor = System.Drawing.Color.Transparent;
            this.SalirBoton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SalirBoton.Image = global::Metal_Warriors.Properties.Resources.SalirBoton;
            this.SalirBoton.Location = new System.Drawing.Point(404, 433);
            this.SalirBoton.Name = "SalirBoton";
            this.SalirBoton.Size = new System.Drawing.Size(110, 37);
            this.SalirBoton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SalirBoton.TabIndex = 4;
            this.SalirBoton.TabStop = false;
            this.SalirBoton.Click += new System.EventHandler(this.SalirBoton_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(873, 505);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metal_Warriors.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.SalirBoton);
            this.Controls.Add(this.AcercadeBoton);
            this.Controls.Add(this.IniciarBoton);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.IniciarBoton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AcercadeBoton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalirBoton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox IniciarBoton;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.PictureBox AcercadeBoton;
        private System.Windows.Forms.PictureBox SalirBoton;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}


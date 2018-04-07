namespace Metal_Warriors
{
    partial class AcercaDe
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
            this.Regresar = new System.Windows.Forms.PictureBox();
            this.DesarrolladoPor = new System.Windows.Forms.PictureBox();
            this.Nombre = new System.Windows.Forms.PictureBox();
            this.Link = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesarrolladoPor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link)).BeginInit();
            this.SuspendLayout();
            // 
            // Regresar
            // 
            this.Regresar.BackColor = System.Drawing.Color.Transparent;
            this.Regresar.Image = global::Metal_Warriors.Properties.Resources.regresarBoton;
            this.Regresar.Location = new System.Drawing.Point(12, 25);
            this.Regresar.Name = "Regresar";
            this.Regresar.Size = new System.Drawing.Size(122, 22);
            this.Regresar.TabIndex = 0;
            this.Regresar.TabStop = false;
            this.Regresar.Click += new System.EventHandler(this.Juego_Click);
            // 
            // DesarrolladoPor
            // 
            this.DesarrolladoPor.BackColor = System.Drawing.Color.Transparent;
            this.DesarrolladoPor.Image = global::Metal_Warriors.Properties.Resources.DesarrolladoPor;
            this.DesarrolladoPor.Location = new System.Drawing.Point(246, 61);
            this.DesarrolladoPor.Name = "DesarrolladoPor";
            this.DesarrolladoPor.Size = new System.Drawing.Size(488, 51);
            this.DesarrolladoPor.TabIndex = 1;
            this.DesarrolladoPor.TabStop = false;
            this.DesarrolladoPor.Click += new System.EventHandler(this.DesarrolladoPor_Click);
            // 
            // Nombre
            // 
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Image = global::Metal_Warriors.Properties.Resources.Nombre;
            this.Nombre.Location = new System.Drawing.Point(403, 175);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(181, 170);
            this.Nombre.TabIndex = 2;
            this.Nombre.TabStop = false;
            this.Nombre.Click += new System.EventHandler(this.Nombre_Click);
            // 
            // Link
            // 
            this.Link.BackColor = System.Drawing.Color.Transparent;
            this.Link.Image = global::Metal_Warriors.Properties.Resources.VerjuegoBoton;
            this.Link.Location = new System.Drawing.Point(379, 418);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(218, 84);
            this.Link.TabIndex = 3;
            this.Link.TabStop = false;
            this.Link.Click += new System.EventHandler(this.Link_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metal_Warriors.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.DesarrolladoPor);
            this.Controls.Add(this.Regresar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaDe";
            ((System.ComponentModel.ISupportInitialize)(this.Regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesarrolladoPor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Link)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Regresar;
        private System.Windows.Forms.PictureBox DesarrolladoPor;
        private System.Windows.Forms.PictureBox Nombre;
        private System.Windows.Forms.PictureBox Link;
    }
}
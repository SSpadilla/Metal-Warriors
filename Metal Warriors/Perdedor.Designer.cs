namespace Metal_Warriors
{
    partial class Perdedor
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
            this.perdedor3 = new System.Windows.Forms.PictureBox();
            this.perdedor2 = new System.Windows.Forms.PictureBox();
            this.Perdedor1 = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.perdedor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdedor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perdedor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // perdedor3
            // 
            this.perdedor3.BackColor = System.Drawing.Color.Transparent;
            this.perdedor3.Image = global::Metal_Warriors.Properties.Resources.Perdedor;
            this.perdedor3.Location = new System.Drawing.Point(261, 156);
            this.perdedor3.Name = "perdedor3";
            this.perdedor3.Size = new System.Drawing.Size(428, 70);
            this.perdedor3.TabIndex = 0;
            this.perdedor3.TabStop = false;
            this.perdedor3.Click += new System.EventHandler(this.perdedor3_Click);
            // 
            // perdedor2
            // 
            this.perdedor2.BackColor = System.Drawing.Color.Transparent;
            this.perdedor2.Image = global::Metal_Warriors.Properties.Resources.Perdedor;
            this.perdedor2.Location = new System.Drawing.Point(261, 232);
            this.perdedor2.Name = "perdedor2";
            this.perdedor2.Size = new System.Drawing.Size(428, 70);
            this.perdedor2.TabIndex = 1;
            this.perdedor2.TabStop = false;
            this.perdedor2.Click += new System.EventHandler(this.perdedor2_Click);
            // 
            // Perdedor1
            // 
            this.Perdedor1.BackColor = System.Drawing.Color.Transparent;
            this.Perdedor1.Image = global::Metal_Warriors.Properties.Resources.Perdedor;
            this.Perdedor1.Location = new System.Drawing.Point(261, 308);
            this.Perdedor1.Name = "Perdedor1";
            this.Perdedor1.Size = new System.Drawing.Size(428, 70);
            this.Perdedor1.TabIndex = 2;
            this.Perdedor1.TabStop = false;
            this.Perdedor1.Click += new System.EventHandler(this.Perdedor1_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Image = global::Metal_Warriors.Properties.Resources.SalirBoton;
            this.Salir.Location = new System.Drawing.Point(413, 487);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(113, 41);
            this.Salir.TabIndex = 3;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Perdedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metal_Warriors.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Perdedor1);
            this.Controls.Add(this.perdedor2);
            this.Controls.Add(this.perdedor3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Perdedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perdedor";
            ((System.ComponentModel.ISupportInitialize)(this.perdedor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perdedor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Perdedor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox perdedor3;
        private System.Windows.Forms.PictureBox perdedor2;
        private System.Windows.Forms.PictureBox Perdedor1;
        private System.Windows.Forms.PictureBox Salir;
    }
}
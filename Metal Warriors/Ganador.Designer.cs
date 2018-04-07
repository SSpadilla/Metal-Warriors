namespace Metal_Warriors
{
    partial class Ganador
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
            this.Ganador3 = new System.Windows.Forms.PictureBox();
            this.Ganador2 = new System.Windows.Forms.PictureBox();
            this.Ganador1 = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ganador3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ganador2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ganador1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.SuspendLayout();
            // 
            // Ganador3
            // 
            this.Ganador3.BackColor = System.Drawing.Color.Transparent;
            this.Ganador3.Image = global::Metal_Warriors.Properties.Resources.Ganador;
            this.Ganador3.Location = new System.Drawing.Point(280, 166);
            this.Ganador3.Name = "Ganador3";
            this.Ganador3.Size = new System.Drawing.Size(363, 66);
            this.Ganador3.TabIndex = 0;
            this.Ganador3.TabStop = false;
            this.Ganador3.Click += new System.EventHandler(this.Ganador3_Click);
            // 
            // Ganador2
            // 
            this.Ganador2.BackColor = System.Drawing.Color.Transparent;
            this.Ganador2.Image = global::Metal_Warriors.Properties.Resources.Ganador;
            this.Ganador2.Location = new System.Drawing.Point(280, 238);
            this.Ganador2.Name = "Ganador2";
            this.Ganador2.Size = new System.Drawing.Size(363, 66);
            this.Ganador2.TabIndex = 1;
            this.Ganador2.TabStop = false;
            this.Ganador2.Click += new System.EventHandler(this.Ganador2_Click);
            // 
            // Ganador1
            // 
            this.Ganador1.BackColor = System.Drawing.Color.Transparent;
            this.Ganador1.Image = global::Metal_Warriors.Properties.Resources.Ganador;
            this.Ganador1.Location = new System.Drawing.Point(280, 310);
            this.Ganador1.Name = "Ganador1";
            this.Ganador1.Size = new System.Drawing.Size(363, 66);
            this.Ganador1.TabIndex = 2;
            this.Ganador1.TabStop = false;
            this.Ganador1.Click += new System.EventHandler(this.Ganador1_Click);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.Color.Transparent;
            this.Salir.Image = global::Metal_Warriors.Properties.Resources.SalirBoton;
            this.Salir.Location = new System.Drawing.Point(404, 464);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(107, 35);
            this.Salir.TabIndex = 3;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Ganador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Metal_Warriors.Properties.Resources.Fondo;
            this.ClientSize = new System.Drawing.Size(960, 540);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.Ganador1);
            this.Controls.Add(this.Ganador2);
            this.Controls.Add(this.Ganador3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ganador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ganador";
            ((System.ComponentModel.ISupportInitialize)(this.Ganador3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ganador2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ganador1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ganador3;
        private System.Windows.Forms.PictureBox Ganador2;
        private System.Windows.Forms.PictureBox Ganador1;
        private System.Windows.Forms.PictureBox Salir;
    }
}
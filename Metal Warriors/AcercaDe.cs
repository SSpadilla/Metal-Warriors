using System;
using System.Media;
using System.Windows.Forms;

namespace Metal_Warriors
{
    public partial class AcercaDe : Form
    {

        public SoundPlayer SeleccionSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Select.wav");
        private void DesarrolladoPor_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            
        }
        private void Nombre_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            System.Diagnostics.Process.Start("https://twitter.com/SamPadillaC");
        }
        private void Juego_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            this.Close();
        }
        private void Link_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            System.Diagnostics.Process.Start("https://github.com/SSpadilla");
        }
        public AcercaDe()
        {
            InitializeComponent();
        }
    }
}

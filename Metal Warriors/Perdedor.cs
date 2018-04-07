using System;
using System.Windows.Forms;
using System.Media;
namespace Metal_Warriors
{
    public partial class Perdedor : Form
    {
        public SoundPlayer SeleccionSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Select.wav");
        public SoundPlayer PerdedorSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Derrota.wav"); 

        private void perdedor3_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
        }

        private void perdedor2_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
        }

        private void Perdedor1_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            Application.Exit();
        }
        public Perdedor()
        {
            InitializeComponent();
            PerdedorSound.Play();
        }
    }
}

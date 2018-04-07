using System.Windows.Forms;
using System.Media;
namespace Metal_Warriors
{
    public partial class Ganador : Form
    {
        public SoundPlayer SeleccionSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Select.wav");
        public SoundPlayer GanadorSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Victoria.wav");
        private void Ganador3_Click(object sender, System.EventArgs e)
        {
            SeleccionSound.Play();
        }
        private void Ganador2_Click(object sender, System.EventArgs e)
        {
            SeleccionSound.Play();
        }
        private void Ganador1_Click(object sender, System.EventArgs e)
        {
            SeleccionSound.Play();
        }
        private void Salir_Click(object sender, System.EventArgs e)
        {
            SeleccionSound.Play();
            Application.Exit();
        }
        public Ganador()
        {
            InitializeComponent();
            GanadorSound.Play();
        }
    }
}

using System;
using System.Windows.Forms;
using System.Media;


namespace Metal_Warriors
{

    public partial class Inicio : Form
    {
        //Archivo de audio
        public SoundPlayer SeleccionSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Select.wav");

        //Botones
        private void IniciarBoton_Click(object sender, EventArgs e)
        {
           SeleccionSound.Play();
            Selección selección = new Selección();
            selección.Show();
        }
        private void SalirBoton_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            Application.Exit();
            
        }
        private void AcercadeBoton_Click(object sender, EventArgs e)
        {
           SeleccionSound.Play();
            AcercaDe acercaDe = new AcercaDe();
            acercaDe.Show();
        
        }

        //constructo
        public Inicio()
        {
            InitializeComponent();

        }
    }
}

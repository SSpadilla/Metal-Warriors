using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Media;
namespace Metal_Warriors
{
    public partial class Selección : Form
    {
        public SoundPlayer SeleccionSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Select.wav");
        public SoundPlayer SeleccionWarriorSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\SelectWarrior.wav");
        public List<int> WarriorSelect { get; set; } = new List<int>();
        private List<int> LocalWarriorSelect { get; set; } // Guarda los numeros aleatorios que indican (equivalente a numero de warrior)

        private bool NitroSelector = false, PrometheusSelector = false, HavocSelector = false, BallisticSelector = false, DracheSelector = false, SpiderSelector = false;


        //botones
        private void RegresarBoton_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            this.Close();
        }
        private void ContinuarBoton_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            LocalWarriorSelect = new List<int>();
            int valor = 0;
            bool selector;

            //genera los numeros aleatrois para los warriors locales
            Random random = new Random();
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    selector = false;
                    valor = random.Next(1, 6);

                    for (int j = 0; j < LocalWarriorSelect.Count; j++)
                    {
                        if (valor == LocalWarriorSelect[j])
                        {
                            selector = true;
                        }

                    }
                } while (selector == true);
                LocalWarriorSelect.Add(valor);
            }
            

            Posicionar posicionar = new Posicionar();
            posicionar.CargaSeleccionVisitante(WarriorSelect);//carga los warriors seleccionados
            posicionar.CargaSeleccionLocal(LocalWarriorSelect);//carga los warrior locales
            posicionar.CargaPartida();//prepara el campo y la partida
            posicionar.Show();
            
        }

        //Acciones al seleccionarWarrior
        private void SpiderSelector_Click(object sender, EventArgs e)
        {
            if (WarriorSelect.Count < 4)
            {
                if (SpiderSelector == false)
                {
                    SeleccionWarriorSound.Play();
                }
                
            }
            
            if (SpiderSelector == true)
            {

                SeleccionWarriorSound.Play();
                SpiderSelector = false;
                for (int i = 0; i < WarriorSelect.Count; i++)
                {

                    if (WarriorSelect[i] == 6)
                    {
                        WarriorSelect.Remove(WarriorSelect[i]);
                    }

                }
                spiderSelector.Image = Metal_Warriors.Properties.Resources.Spider;
            }
            else if (WarriorSelect.Count < 4)
            {
                SpiderSelector = true;
                spiderSelector.Image = Metal_Warriors.Properties.Resources.SpiderSelect;
                WarriorSelect.Add(6);
               
            }
            
            if (WarriorSelect.Count == 4)
            {
                continuarBoton.Show();
            }
            else
            {
                continuarBoton.Hide();
            }
        }
        private void DracheSelector_Click(object sender, EventArgs e)
        {
            if (WarriorSelect.Count < 4)
            {
                if (DracheSelector == false)
                {
                    SeleccionWarriorSound.Play();
                }

            }
            if (DracheSelector == true)
            {
                SeleccionWarriorSound.Play();
                DracheSelector = false;
                for (int i = 0; i < WarriorSelect.Count; i++)
                {

                    if (WarriorSelect[i] == 5)
                    {
                        WarriorSelect.Remove(WarriorSelect[i]);
                    }
                }
                dracheSelector.Image = Metal_Warriors.Properties.Resources.Drache;
            }
            else if (WarriorSelect.Count < 4)
            {
                DracheSelector = true;
                dracheSelector.Image = Metal_Warriors.Properties.Resources.DracheSelect;
                WarriorSelect.Add(5);
            }
            
            if (WarriorSelect.Count == 4)
            {
                continuarBoton.Show();
            }
            else
            {
                continuarBoton.Hide();
            }

        }
        private void BallisticSelector_Click(object sender, EventArgs e)
        {
            if (WarriorSelect.Count < 4)
            {
                if (BallisticSelector == false)
                {
                    SeleccionWarriorSound.Play();
                }

            }
            if (BallisticSelector == true)
            {
                SeleccionWarriorSound.Play();
                BallisticSelector = false;
                for (int i = 0; i < WarriorSelect.Count; i++)
                {
                    if (WarriorSelect[i] == 4)
                    {
                        WarriorSelect.Remove(WarriorSelect[i]);
                    }
                }
                ballisticSelector.Image = Metal_Warriors.Properties.Resources.Ballistic;
            }
            else if (WarriorSelect.Count < 4)
            {
                SeleccionWarriorSound.Play();
                BallisticSelector = true;
                ballisticSelector.Image = Metal_Warriors.Properties.Resources.BallisticSelect;
                WarriorSelect.Add(4); 
            }
            
            if (WarriorSelect.Count == 4)
            {
                continuarBoton.Show();
            }
            else
            {
                continuarBoton.Hide();
            }
        }
        private void HavocSelector_Click(object sender, EventArgs e)
        {
            if (WarriorSelect.Count < 4)
            {
                if (HavocSelector == false)
                {
                    SeleccionWarriorSound.Play();
                }

            }

            if (HavocSelector == true)
            {
                SeleccionWarriorSound.Play();
                HavocSelector = false;
                for (int i = 0; i < WarriorSelect.Count; i++)
                {
                    if (WarriorSelect[i] == 3)
                    {
                        WarriorSelect.Remove(WarriorSelect[i]);
                    }
                }
                havocSelector.Image = Metal_Warriors.Properties.Resources.Havoc;
            }
            else if (WarriorSelect.Count < 4)
            {
                SeleccionWarriorSound.Play();
                HavocSelector = true;
                havocSelector.Image = Metal_Warriors.Properties.Resources.HavocSelect;
                WarriorSelect.Add(3);
               
            }
            if (WarriorSelect.Count == 4)
            {
                continuarBoton.Show();
            }
            else
            {
                continuarBoton.Hide();
            }
        }
        private void PrometheusSelector_Click(object sender, EventArgs e)
        {
            if (WarriorSelect.Count < 4)
            {
                if (PrometheusSelector == false)
                {
                    SeleccionWarriorSound.Play();
                }

            }
            if (PrometheusSelector == true)
            {
                SeleccionWarriorSound.Play();
                PrometheusSelector = false;
                for (int i = 0; i < WarriorSelect.Count; i++)
                {
                    if (WarriorSelect[i] == 2)
                    {
                        WarriorSelect.Remove(WarriorSelect[i]);
                    }
                }
                prometheusSelector.Image = Metal_Warriors.Properties.Resources.Prometheus;
            }
            else if (WarriorSelect.Count < 4)
            {
                SeleccionWarriorSound.Play();
                PrometheusSelector = true;
                prometheusSelector.Image = Metal_Warriors.Properties.Resources.PrometheusSelect;
                WarriorSelect.Add(2);  
            }
            
            if (WarriorSelect.Count == 4)
            {
                continuarBoton.Show();
            }
            else
            {
                continuarBoton.Hide();
            }
        }
        private void NitroSelector_Click(object sender, EventArgs e)
        {
            if (WarriorSelect.Count < 4)
            {
                if (NitroSelector == false)
                {
                    SeleccionWarriorSound.Play();
                }

            }
            if (NitroSelector == true)
            {
                SeleccionWarriorSound.Play();
                NitroSelector = false;
                for (int i = 0; i < WarriorSelect.Count; i++)
                {
                    if (WarriorSelect[i] == 1)
                    {
                        WarriorSelect.Remove(WarriorSelect[i]);
                    }
                }
                nitroSelector.Image = Metal_Warriors.Properties.Resources.Nitro;
            }
            else if (WarriorSelect.Count < 4)
            {
                
                NitroSelector = true;
                nitroSelector.Image = Metal_Warriors.Properties.Resources.NitroSelect;
                WarriorSelect.Add(1);
            }

            if(WarriorSelect.Count == 4)
            {
                continuarBoton.Show();
            }
            else
            {
                continuarBoton.Hide();
            }
        }

        //al cargar form
        private void Selección_Load(object sender, EventArgs e)
        {
            WarriorSelect.Clear();
            continuarBoton.Hide();
        }

        //constructor
        public Selección()
        {
            InitializeComponent();

        }
    }
}

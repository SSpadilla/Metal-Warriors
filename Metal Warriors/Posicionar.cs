using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using WMPLib;
namespace Metal_Warriors
{
    public partial class Posicionar : Form
    {
        //WindowsMediaPlayer BattleSound = new WindowsMediaPlayer();

        WindowsMediaPlayer BattleSound = new WindowsMediaPlayer();//para la cancion de batalla
        //----------------------------------------------------Clases y Variables------------------------------------------------

        //Archivos de audio
        public SoundPlayer SeleccionSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Select.wav");
        public SoundPlayer SeleccionWarriorSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\SelectWarrior.wav");
        public SoundPlayer DañadoSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Dañado.wav");
        public SoundPlayer DestruidoSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Destruido.wav");
        public SoundPlayer FailureSound { get; set; } = new SoundPlayer(@"C:\Users\ss.padilla\source\repos\Metal Warriors\Sounds\Failure.wav");

        //Clases
        //Genera la clase donde se almacenaran los datos de los warriors
        public class Warriors
        {

            public bool Posicionado { get; set; }
            public int[,] Posiciones { get; set; } = new int[8, 8] ;
            public int VecesDañado { get; set; }
            public System.Drawing.Bitmap LocacionImagen { get; set; }
            public System.Drawing.Bitmap LocacionImagenSeleccionado { get; set; }
            public System.Drawing.Bitmap LocacionImagenPosicionado { get; set; }
            public System.Drawing.Bitmap LocacionImagenDañado { get; set; }
            public System.Drawing.Bitmap LocacionImagenDestruido { get; set; }
            public System.Drawing.Bitmap LocacionImagenLucha { get; set; }
        }

        //Listas 
        private List<Warriors> LocalWarrior { get; set; } = new List<Warriors>(); //almacena la imagen y nombre de los Warriors de la máquina
        private List<Warriors> VisitanteWarrior { get; set; } = new List<Warriors>();//almacena la imagen y nombre de los Warriors del jugador


        //Variables Dibujo
        public Pen lapiz = new Pen(Color.DarkGray);
        public SolidBrush pincel = new SolidBrush(Color.DarkBlue);


        //variables de tablero-----------------------------------------------------
        int PosicionX = 0, PosicionY = 0, PosicionTamaño = 4,PosicionOrientacion = 0, PosicionMostrar = 0; //utilizadas para tamaño de las celdas, posiciones a calcular

        //Obtiene la posicion en x y en y actuales
        public int eX { get; set; } = 0;
        public int eY { get; set; } = 0;

        public int[,] VisitanteTablero { get; set; } = new int[8, 8];
        public bool[,] VisitanteTableroComprobador { get; set; } = new bool[8, 8];//guarda si la celdadel visitante esta ocupada o no
        public int[,] LocalTablero { get; set; } = new int[8, 8];
        public bool[,] LocalTableroComprobador { get; set; } = new bool[8, 8];//guarda si la celda local esta ocupada o no
        public bool ComenzarDuelo { get; set; } = false;
        public int Ganador { get; set; } = 0; //indica quien ha ganado la partida
        Random random = new Random();

        //Para el posicionamiento de warriors
        public int WarriorActual { get; set; }
        public int warriorcreado { get; set; } = 0;

        //----------------------------------------------------Metodos------------------------------------------------

        //-----------------------Botones-----------------------

        //Prepara para la batalla
        private void ComenzarBoton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Metal_Warriors.Properties.Resources.FondoBatalla;
            BattleSound.URL = "Batalla.wav";

            SeleccionSound.Play();
            BattleSound.controls.play();
            ComenzarDuelo = true;
            ComenzarBoton.Hide();
            this.Refresh();
        }

        private void RotarBoton_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            if (PosicionOrientacion == 0) PosicionOrientacion = 1; else PosicionOrientacion = 0;
        }

        //Acciones al Clickear 1 Warrior
        private void warrior1_Click(object sender, EventArgs e)
        {

            WarriorActual = 0;
            visitanteImagen.Refresh();

            if (!VisitanteWarrior[0].Posicionado)
            {
                SeleccionWarriorSound.Play();
                RotarBoton.Show();
                WarriorActual = 1;
                warrior1.Image = VisitanteWarrior[0].LocacionImagenSeleccionado;
                if (!VisitanteWarrior[1].Posicionado) warrior2.Image = VisitanteWarrior[1].LocacionImagen;
                if (!VisitanteWarrior[2].Posicionado) warrior3.Image = VisitanteWarrior[2].LocacionImagen;
                if (!VisitanteWarrior[3].Posicionado) warrior4.Image = VisitanteWarrior[3].LocacionImagen;
            }
            else { MessageBox.Show(" Ya ha sido posicionado", "Incorrecto"); }

        }
        private void warrior2_Click(object sender, EventArgs e)
        {

            WarriorActual = 0;
            visitanteImagen.Refresh();
            if (!VisitanteWarrior[1].Posicionado)
            {
                SeleccionWarriorSound.Play();
                RotarBoton.Show();
                WarriorActual = 2;
                warrior2.Image = VisitanteWarrior[1].LocacionImagenSeleccionado;
                if (!VisitanteWarrior[0].Posicionado) warrior1.Image = VisitanteWarrior[0].LocacionImagen;
                if (!VisitanteWarrior[2].Posicionado) warrior3.Image = VisitanteWarrior[2].LocacionImagen;
                if (!VisitanteWarrior[3].Posicionado) warrior4.Image = VisitanteWarrior[3].LocacionImagen;
            }
            else { MessageBox.Show(" Ya ha sido posicionado", "Incorrecto"); }
        }
        private void warrior3_Click(object sender, EventArgs e)
        {

            WarriorActual = 0;
            visitanteImagen.Refresh();
            if (!VisitanteWarrior[2].Posicionado)
            {
                SeleccionWarriorSound.Play();
                RotarBoton.Show();
                WarriorActual = 3;
                warrior3.Image = VisitanteWarrior[2].LocacionImagenSeleccionado;
                if (!VisitanteWarrior[0].Posicionado) warrior1.Image = VisitanteWarrior[0].LocacionImagen;
                if (!VisitanteWarrior[1].Posicionado) warrior2.Image = VisitanteWarrior[1].LocacionImagen;
                if (!VisitanteWarrior[3].Posicionado) warrior4.Image = VisitanteWarrior[3].LocacionImagen;
            }
            else { MessageBox.Show(" Ya ha sido posicionado", "Incorrecto"); }
        }
        private void warrior4_Click(object sender, EventArgs e)
        {

            WarriorActual = 0;
            visitanteImagen.Refresh();

            if (!VisitanteWarrior[3].Posicionado)
            {
                SeleccionWarriorSound.Play();
                RotarBoton.Show();
                WarriorActual = 4;
                warrior4.Image = VisitanteWarrior[3].LocacionImagenSeleccionado;
                if (!VisitanteWarrior[0].Posicionado) warrior1.Image = VisitanteWarrior[0].LocacionImagen;
                if (!VisitanteWarrior[1].Posicionado) warrior2.Image = VisitanteWarrior[1].LocacionImagen;
                if (!VisitanteWarrior[2].Posicionado) warrior3.Image = VisitanteWarrior[2].LocacionImagen;

            }
            else { MessageBox.Show(" Ya ha sido posicionado", "Incorrecto"); }
        }
        //Regresa al form anterior
        private void RegresarBoton_Click(object sender, EventArgs e)
        {
            SeleccionSound.Play();
            this.Close();
        }
        //Hace que desaparezca lo anterior posicionado

        //-----------------------Juego----------------------

        //(Métodos de Verificación)Verifica si se puede colocar un barco en dicha celda y/o posicion
        public bool CeldaValida(int y, int x)
        {
            if (x < 0) return false; if (y < 0) return false; if (x >= 8) return false; if (y >= 8) return false;

            return true; 
        }
        public bool PosicionValida(int[,] tablero, int y,  int x, int orientacion)
        {
            int dx = 0, dy = 0;

            if (orientacion == 1) { dy = 1; } else { dx = 1; }

            for (int i = x; i <= x + (dx * ( PosicionTamaño-1)) ; i++)
            {
                for (int j = y; j <= y + (dy * (PosicionTamaño - 1)); j++) 
                {
                    if (!CeldaValida(j,i))
                    { 
                        return false;
                    }
                }
            }

            for (int j = y - 1; j <= y + 1 + ( dy * PosicionTamaño ); j++)
            {
                for (int i = x - 1; i <= x + 1 + (dx * PosicionTamaño ); i++)
                {
                    if (CeldaValida(j,i))
                    {
                        if (tablero[j,i] != 0)
                        {                         
                            return false;   
                        }
                    }
                }
            }

            return true;
        }
        public bool PosicionValida()
        {
            return PosicionValida(VisitanteTablero, PosicionY, PosicionX, PosicionOrientacion);
        } //acorta el metodo Posicion valida
        
        //Evita que el warrior salga de la pantalla
        private void LimitarWarrior()
        {
            int dy = 0, dx = 0;
            if (PosicionOrientacion == 1) { dy = 1; } else { dx = 1; }

            if (PosicionY + PosicionTamaño * dy >= 8)
            {
                PosicionY = 8 - PosicionTamaño * dy;
            }

            if (PosicionX + PosicionTamaño * dx >= 8)
            {
                PosicionX = 8 - PosicionTamaño * dx;
            }
        }


        //Muestra las posibles posiciones si se han cumplido los metodos de verificación
        public void ColocarWarrior(int[,] tablero)
        {
            
            int warriorguardar = 0;
            int x, y, orientacion;
            int dx = 0, dy = 0;
            do
            {
                x = random.Next(8);
                y = random.Next(8);
                orientacion = random.Next(2);
            } while (!PosicionValida(tablero,y, x, orientacion));

            warriorcreado ++; 
            switch (warriorcreado)
            {
                case 1:
                    warriorguardar = 0;
                    break;
                case 2:
                    warriorguardar = 1;
                    break;
                case 3:
                    warriorguardar = 2;
                    break;
                case 4:
                    warriorguardar = 3;
                    break;
            }

            if (orientacion == 1) { dy = 1; } else { dx = 1; }

            for (int j = y; j <= y + (PosicionTamaño - 1) * dy; j++)
            {
                for (int i = x; i <= x + (PosicionTamaño - 1) * dx; i++)
                {
                    tablero[j, i] = PosicionTamaño;
                    LocalWarrior[warriorguardar].Posiciones[j, i] = PosicionTamaño;
                }
            }
        }

        //para que no se muestre la posicion fuera del tablero
        private void Posicionar_MouseMove(object sender, MouseEventArgs e)
        {
            PosicionMostrar = 0;
            visitanteImagen.Refresh();
        }


        //Determina un Ganador
        public bool victoria(int[,] tablero, bool[,] tablerocomprobador)
        {
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (tablerocomprobador[j, i] == false && tablero[j, i] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }        
        
        //Genera un disparo despues que el visitante ataque
        private void DisparoLocal()
        {
            int y = 0, x = 0;
            do
            {
                y = random.Next(8);
                x = random.Next(8);
            } while (VisitanteTableroComprobador[y, x] == true);
            VisitanteTableroComprobador[y, x] = true;

            visitanteImagen.Refresh();
        }

        //Determina las imagenes y funciones del tablero
        public void WarriorAtacado(int k, bool estado, bool listado)
        {
            // estado true == destruido, listado true == visitante,
            switch (listado)
            {
                case false:
                    switch (estado)
                    {
                        case true:
                            switch (k)
                            {
                                case 0:
                                    Localwarrior1.Image = LocalWarrior[0].LocacionImagenDestruido;
                                    DestruidoSound.Play();
                                    break;
                                case 1:
                                    Localwarrior2.Image = LocalWarrior[1].LocacionImagenDestruido;
                                    DestruidoSound.Play();
                                    break;
                                case 2:
                                    Localwarrior3.Image = LocalWarrior[2].LocacionImagenDestruido;
                                    DestruidoSound.Play();
                                    break;
                                case 3:
                                    Localwarrior4.Image = LocalWarrior[3].LocacionImagenDestruido;
                                    DestruidoSound.Play();
                                    break;
                            }
                            break;
                        case false:
                            switch (k)
                            {
                                case 0:
                                    Localwarrior1.Image = LocalWarrior[0].LocacionImagenDañado;
                                    LocalWarrior[0].VecesDañado++;
                                    DañadoSound.Play();
                                    break;
                                case 1:
                                    Localwarrior2.Image = LocalWarrior[1].LocacionImagenDañado;
                                    LocalWarrior[1].VecesDañado++;
                                    DañadoSound.Play();
                                    break;
                                case 2:
                                    Localwarrior3.Image = LocalWarrior[2].LocacionImagenDañado;
                                    LocalWarrior[2].VecesDañado++;
                                    DañadoSound.Play();
                                    break;
                                case 3:
                                    Localwarrior4.Image = LocalWarrior[3].LocacionImagenDañado;
                                    LocalWarrior[3].VecesDañado++;
                                    DañadoSound.Play();
                                    break;
                            }
                            break;
                    }
                    break;
                case true:
                    switch (estado)
                    {
                        case true:
                            switch (k)
                            {
                                case 0:
                                    warrior1.Image = VisitanteWarrior[0].LocacionImagenDestruido;
                                    break;
                                case 1:
                                    warrior2.Image = VisitanteWarrior[1].LocacionImagenDestruido;
                                    break;
                                case 2:
                                    warrior3.Image = VisitanteWarrior[2].LocacionImagenDestruido;
                                    break;
                                case 3:
                                    warrior4.Image = VisitanteWarrior[3].LocacionImagenDestruido;
                                    break;
                            }
                            break;
                        case false:
                            switch (k)
                            {
                                case 0:
                                    warrior1.Image = VisitanteWarrior[0].LocacionImagenDañado;
                                    VisitanteWarrior[0].VecesDañado++;
                                    break;
                                case 1:
                                    warrior2.Image = VisitanteWarrior[1].LocacionImagenDañado;
                                    VisitanteWarrior[1].VecesDañado++;
                                    break;
                                case 2:
                                    warrior3.Image = VisitanteWarrior[2].LocacionImagenDañado;
                                    VisitanteWarrior[2].VecesDañado++;
                                    break;
                                case 3:
                                    warrior4.Image = VisitanteWarrior[3].LocacionImagenDañado;
                                    VisitanteWarrior[3].VecesDañado++;
                                    break;
                            }
                            break;
                    }
                    break;
            }


        }

        //Brindan toda la informacion al tablero
        private void LocalImagen_Click(object sender, EventArgs e)
        {

            if (ComenzarDuelo)
            {

                int x = eX;
                int y = eY;

                if (x >= 0 && y >= 0 && x < 40 * 8 && y < 40 * 8)
                {

                    int posicionY = eX / 40;
                    int posicionX = eY / 40;
                    if (PosicionX != posicionX || PosicionY != posicionY)
                    {
                        PosicionX = posicionX;
                        PosicionY = posicionY;

                        if (LocalTableroComprobador[posicionY, posicionX] == false)
                        {
                            LocalTableroComprobador[posicionY, posicionX] = true;

                            if (victoria(VisitanteTablero, VisitanteTableroComprobador))
                            {
                                Ganador = 1;
                            }
                            DisparoLocal();
                            if (victoria(LocalTablero, LocalTableroComprobador))
                            {
                                Ganador = 2;
                            }
                            LocalImagen.Refresh();
                        }

                    }
                }
            }

        } 
        private void LocalImagen_MouseMove(object sender, MouseEventArgs e)
        {

            eX = e.X;
            eY = e.Y;
        }
        private void visitanteImagen_Click(object sender, EventArgs e)
        {
            int warriorguardar = 0;
            if (WarriorActual != 0)
            {

                if (PosicionValida())
                {
                    SeleccionSound.Play();
                    warriorcreado++;
                    switch (WarriorActual)
                    {
                        case 1:
                            warriorguardar = 0;
                            break;
                        case 2:
                            warriorguardar = 1;
                            break;
                        case 3:
                            warriorguardar = 2;
                            break;
                        case 4:
                            warriorguardar = 3;
                            break;
                    }

                    int dy = 0, dx = 0;
                    if (PosicionOrientacion == 1) { dy = 1; } else { dx = 1; }

                    for (int j = PosicionY; j <= PosicionY + (PosicionTamaño - 1) * dy; j++)
                    {
                        for (int i = PosicionX; i <= PosicionX + (PosicionTamaño - 1) * dx; i++)
                        {
                            VisitanteTablero[j, i] = PosicionTamaño;
                            VisitanteWarrior[warriorguardar].Posiciones[j, i] = PosicionTamaño;
                        }
                    }

                    switch (WarriorActual)
                    {
                        case 1:
                            VisitanteWarrior[0].Posicionado = true;
                            warrior1.Image = VisitanteWarrior[0].LocacionImagenPosicionado;
                            break;
                        case 2:
                            VisitanteWarrior[1].Posicionado = true;
                            warrior2.Image = VisitanteWarrior[1].LocacionImagenPosicionado;
                            break;
                        case 3:
                            VisitanteWarrior[2].Posicionado = true;
                            warrior3.Image = VisitanteWarrior[2].LocacionImagenPosicionado;
                            break;
                        case 4:
                            VisitanteWarrior[3].Posicionado = true;
                            warrior4.Image = VisitanteWarrior[3].LocacionImagenPosicionado;
                            break;
                    }
                    PosicionOrientacion = 0;
                    RotarBoton.Hide();
                    WarriorActual = 0;

                    if (VisitanteWarrior[0].Posicionado && VisitanteWarrior[1].Posicionado && VisitanteWarrior[2].Posicionado && VisitanteWarrior[3].Posicionado)
                    {
                        ComenzarBoton.Show();
                    }

                }
                else
                {
                    switch (WarriorActual)
                    {
                        case 1:
                            VisitanteWarrior[0].Posicionado = false;
                            break;
                        case 2:
                            VisitanteWarrior[1].Posicionado = false;
                            break;
                        case 3:
                            VisitanteWarrior[2].Posicionado = false;
                            break;
                        case 4:
                            VisitanteWarrior[3].Posicionado = false;
                            break;
                    }

                    visitanteImagen.Refresh();
                }
            }
        }
        private void visitanteImagen_MouseMove(object sender, MouseEventArgs e)
        {
            PosicionMostrar = 1;
            if (WarriorActual != 0)
            {
                int x = e.X;
                int y = e.Y;
                if (x >= 0 && y >= 0 && x < 40 * 8 && y < 40 * 8)
                {
                    int posicionY = y / 40;
                    int posicionX = x / 40;
                    if (PosicionX != posicionX || PosicionY != posicionY)
                    {
                        PosicionX = posicionX;
                        PosicionY = posicionY;
                        LimitarWarrior();
                        visitanteImagen.Refresh();
                    }
                }
            }

        }
       
        
        //METODOS PRINCIPALES   
        private void LocalImagen_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = null;
            bool iterador = false;
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (LocalTablero[j, i] > 0 && LocalTableroComprobador[j, i])
                    {

                        bitmap = Metal_Warriors.Properties.Resources.Destruido;

                        for (int k = 0; k < 4; k++)
                        {
                            if (LocalWarrior[k].Posiciones[j, i] == LocalTablero[j, i])
                            {
                                WarriorAtacado(k, false, false);
                                LocalWarrior[k].Posiciones[j, i] = 0;
                                bitmap = Metal_Warriors.Properties.Resources.Dañado;
                                iterador = true;
                                if (LocalWarrior[k].VecesDañado == 4)
                                {
                                    WarriorAtacado(k, true, false);
                                    bitmap = Metal_Warriors.Properties.Resources.Destruido;

                                }

                            }

                        }

                        e.Graphics.DrawImage(bitmap, new Rectangle(j * 40, i * 40, 40, 40));
                        e.Graphics.DrawRectangle(lapiz, i * 40, j * 40, 40, 40);
                    }


                    if (LocalTablero[j, i] == 0 && LocalTableroComprobador[j, i])
                    {

                        bitmap = Metal_Warriors.Properties.Resources.Failure;
                        if (iterador == false) { FailureSound.Play(); }
                        e.Graphics.DrawImage(bitmap, new Rectangle(j * 40, i * 40, 40, 40));
                        e.Graphics.DrawRectangle(lapiz, j * 40, i * 40, 40, 40);
                    }

                    e.Graphics.DrawRectangle(lapiz, i * 40, +j * 40, 40, 40);
                }
            }
            if (Ganador != 0)
            {
                if (Ganador == 1)
                {
                    BattleSound.controls.stop();
                    Perdedor perdedor = new Perdedor();
                    perdedor.Show();
                }
                else
                {
                    BattleSound.controls.stop();
                    Ganador ganador = new Ganador();
                    ganador.Show();
                }
            }
        }
        private void VisitanteImagen_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = null;
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    if (WarriorActual != 0)
                    {
                        if (PosicionMostrar != 0)
                        {
                            int pintarX = 0, pintarY = 0;

                            if (PosicionOrientacion == 1) { pintarY = 1; } else { pintarX = 1; }
                            if (i >= PosicionX && j >= PosicionY && i <= PosicionX + (PosicionTamaño - 1) * pintarX && j <= PosicionY + (PosicionTamaño - 1) * pintarY)
                            {
                                e.Graphics.FillRectangle(pincel, i * 40, j * 40, 40, 40);
                            }
                        }
                    }

                    if (VisitanteTablero[j, i] > 0 && VisitanteTableroComprobador[j, i])
                    {
                        bitmap = Metal_Warriors.Properties.Resources.Destruido;

                        for (int k = 0; k < 4; k++)
                        {
                            if (VisitanteTablero[j, i] == VisitanteWarrior[k].Posiciones[j, i])
                            {
                                WarriorAtacado(k, false, true);
                                VisitanteWarrior[k].Posiciones[j, i] = 0;
                                bitmap = Metal_Warriors.Properties.Resources.Dañado;
                                if (VisitanteWarrior[k].VecesDañado == 4)
                                {
                                    WarriorAtacado(k, true, true);
                                    bitmap = Metal_Warriors.Properties.Resources.Destruido;
                                }

                            }
                        }



                        e.Graphics.DrawImage(bitmap, new Rectangle(i * 40, j * 40, 40, 40));
                        e.Graphics.DrawRectangle(lapiz, i * 40, j * 40, 40, 40);
                    }

                    if (VisitanteTablero[j, i] == 0 && VisitanteTableroComprobador[j, i])
                    {
                        bitmap = Metal_Warriors.Properties.Resources.Failure;
                        e.Graphics.DrawImage(bitmap, new Rectangle(i * 40, j * 40, 40, 40));
                        e.Graphics.DrawRectangle(lapiz, i * 40, j * 40, 40, 40);
                    }


                    if (VisitanteTablero[j, i] > 0 && !VisitanteTableroComprobador[j, i])
                    {

                        for (int k = 0; k < 4; k++)
                        {
                            if (VisitanteTablero[j, i] == VisitanteWarrior[k].Posiciones[j, i])
                            {
                                bitmap = VisitanteWarrior[k].LocacionImagenLucha;
                            }
                        }

                        e.Graphics.DrawImage(bitmap, new Rectangle(i * 40, j * 40, 40, 40));
                        e.Graphics.DrawRectangle(lapiz, i * 40, j * 40, 40, 40);
                    }
                    else
                    {
                        e.Graphics.DrawRectangle(lapiz, i * 40, j * 40, 40, 40);
                    }

                }
            }
        }


        //-----------------------Al inciar Form-------------------------------
        //Carga información de los Warriors Locales y del usuario(visitante)
        public void CargaSeleccionLocal(List<int> warriorSelect)
        {

            for (int i = 0; i < warriorSelect.Count; i++)
            {
                Warriors warrior = new Warriors();
                switch (warriorSelect[i])
                {
                    case 1:
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.NitroPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.NitroDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.NitroDestruido;
                        warrior.VecesDañado = 0;
                        LocalWarrior.Add(warrior);
                        break;
                    case 2:
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.PrometheusPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.PromeheusDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.PrometheusDestruido;
                        warrior.VecesDañado = 0;
                        LocalWarrior.Add(warrior);
                        break;
                    case 3:
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.HavocPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.HavocDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.HavocDestruido;
                        warrior.VecesDañado = 0;
                        LocalWarrior.Add(warrior);
                        break;
                    case 4:
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.BallisticPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.BallisticDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.BallisticDestruido;
                        warrior.VecesDañado = 0;
                        LocalWarrior.Add(warrior);
                        break;
                    case 5:
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.DrachePosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.DracheDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.DracheDestruido;
                        warrior.VecesDañado = 0;
                        LocalWarrior.Add(warrior);
                        break;
                    case 6:
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.SpiderPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.SpiderDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.SpiderDestruido;
                        warrior.VecesDañado = 0;
                        LocalWarrior.Add(warrior);
                        break;
                }
            }
        }
        public void CargaSeleccionVisitante(List<int> warriorSelect)
        {
            for (int i = 0; i < warriorSelect.Count; i++)
            {

                Warriors warrior = new Warriors();
                switch (warriorSelect[i])
                {
                    case 1:
                        warrior.LocacionImagen = Metal_Warriors.Properties.Resources.Nitro;
                        warrior.LocacionImagenSeleccionado = Metal_Warriors.Properties.Resources.NitroSelect;
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.NitroPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.NitroDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.NitroDestruido;
                        warrior.LocacionImagenLucha = Metal_Warriors.Properties.Resources.NitroLuchaVisitante;
                        warrior.VecesDañado = 0;
                        warrior.Posicionado = false;
                        VisitanteWarrior.Add(warrior);
                        break;
                    case 2:
                        warrior.LocacionImagen = Metal_Warriors.Properties.Resources.Prometheus;
                        warrior.LocacionImagenSeleccionado = Metal_Warriors.Properties.Resources.PrometheusSelect;
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.PrometheusPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.PromeheusDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.PrometheusDestruido;
                        warrior.LocacionImagenLucha = Metal_Warriors.Properties.Resources.PrometheusVisitante;
                        warrior.VecesDañado = 0;
                        warrior.Posicionado = false;
                        VisitanteWarrior.Add(warrior);
                        break;
                    case 3:
                        warrior.LocacionImagen = Metal_Warriors.Properties.Resources.Havoc;
                        warrior.LocacionImagenSeleccionado = Metal_Warriors.Properties.Resources.HavocSelect;
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.HavocPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.HavocDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.HavocDestruido;
                        warrior.LocacionImagenLucha = Metal_Warriors.Properties.Resources.HavocVisitante;
                        warrior.VecesDañado = 0;
                        warrior.Posicionado = false;
                        VisitanteWarrior.Add(warrior);
                        break;
                    case 4:
                        warrior.LocacionImagen = Metal_Warriors.Properties.Resources.Ballistic;
                        warrior.LocacionImagenSeleccionado = Metal_Warriors.Properties.Resources.BallisticSelect;
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.BallisticPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.BallisticDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.BallisticDestruido;
                        warrior.LocacionImagenLucha = Metal_Warriors.Properties.Resources.BallisticVisitante;
                        warrior.VecesDañado = 0;
                        warrior.Posicionado = false;
                        VisitanteWarrior.Add(warrior);
                        break;
                    case 5:
                        warrior.LocacionImagen = Metal_Warriors.Properties.Resources.Drache;
                        warrior.LocacionImagenSeleccionado = Metal_Warriors.Properties.Resources.DracheSelect;
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.DrachePosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.DracheDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.DracheDestruido;
                        warrior.LocacionImagenLucha = Metal_Warriors.Properties.Resources.DracheVisitatne;
                        warrior.VecesDañado = 0;
                        warrior.Posicionado = false;
                        VisitanteWarrior.Add(warrior);
                        break;
                    case 6:
                        warrior.LocacionImagen = Metal_Warriors.Properties.Resources.Spider;
                        warrior.LocacionImagenSeleccionado = Metal_Warriors.Properties.Resources.SpiderSelect;
                        warrior.LocacionImagenPosicionado = Metal_Warriors.Properties.Resources.SpiderPosicionado;
                        warrior.LocacionImagenDañado = Metal_Warriors.Properties.Resources.SpiderDañado;
                        warrior.LocacionImagenDestruido = Metal_Warriors.Properties.Resources.SpiderDestruido;
                        warrior.LocacionImagenLucha = Metal_Warriors.Properties.Resources.SpiderVisitante;
                        warrior.VecesDañado = 0;
                        warrior.Posicionado = false;
                        VisitanteWarrior.Add(warrior);
                        break;
                }
            }

        }

        //Carga imagenes desde el método cargar partida
        private void Posicionar_Load(object sender, EventArgs e)
        {
            
            warrior1.Image = VisitanteWarrior[0].LocacionImagen;
            warrior2.Image = VisitanteWarrior[1].LocacionImagen;
            warrior3.Image = VisitanteWarrior[2].LocacionImagen;
            warrior4.Image = VisitanteWarrior[3].LocacionImagen;
            Localwarrior1.Image = LocalWarrior[0].LocacionImagenPosicionado;
            Localwarrior2.Image = LocalWarrior[1].LocacionImagenPosicionado;
            Localwarrior3.Image = LocalWarrior[2].LocacionImagenPosicionado;
            Localwarrior4.Image = LocalWarrior[3].LocacionImagenPosicionado;

            ComenzarBoton.Hide();
            RotarBoton.Hide();
        }
        
        //constructor
        public Posicionar()
        {
            InitializeComponent();

        }

        //prepara todo antes de que cargue el form
        public void CargaPartida()
        {
           
            
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < 8; i++)
                {
                    VisitanteTablero[j, i] = 0;
                    VisitanteTableroComprobador[j, i] = false;
                    LocalTablero[j, i] = 0;
                    LocalTableroComprobador[j, i] = false;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                ColocarWarrior(LocalTablero);
            }

            //Poner imagen warrior local
            

        }
    }

}

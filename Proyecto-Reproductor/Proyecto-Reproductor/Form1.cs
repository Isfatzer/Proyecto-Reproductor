using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Reproductor
{
    public partial class Form1 : Form
    {
        List<Lectura_Canciones> lectura = new List<Lectura_Canciones>();
        List<Play_Stop> reproduccion = new List<Play_Stop>();

        //lectura temporal
        Lectura_Canciones lec = new Lectura_Canciones();
        //repruduccion temporal 
        Play_Stop rep = new Play_Stop();
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Cancion_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscaCancion = new OpenFileDialog();
            BuscaCancion.Multiselect = true;
            if (BuscaCancion.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                lec.Canciones = BuscaCancion.SafeFileNames;
                lec.RutaCanciones = BuscaCancion.FileNames;
                foreach (var Canciones in lec.Canciones)
                {
                    ListaCanciones.Items.Add(Canciones);
                }
                Reproductor.URL = lec.RutaCanciones[0];
                ListaCanciones.SelectedIndex = 0;
                Play.Image = Properties.Resources.pausasss;
            }
        }

        private void ListaCanciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = lec.RutaCanciones[ListaCanciones.SelectedIndex];
        }

        private void Play_Click(object sender, EventArgs e)
        {
            switch (rep.Play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    Play.Image = Properties.Resources.boton_de_reproduccion1;
                    rep.Play = false;
                    break;
                case false:
                    Reproductor.Ctlcontrols.play();
                    Play.Image = Properties.Resources.pausasss;
                    rep.Play = true;
                    break;
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            Play.Image = Properties.Resources.boton_de_reproduccion1;
            rep.Play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ActualizaMacTrack();
            DuracionCancion.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            Volumen.Value = Reproductor.settings.volume;

        }
        public void ActualizaMacTrack()
        {
            if (Reproductor.playState==WMPLib.WMPPlayState.wmppsPlaying)
            {
                DuracionCancion.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop(); 
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                DuracionCancion.Value = 0;
            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            ActualizaMacTrack();
        }

        private void Volumen_ValueChanged(object sender, decimal value)
        {
            Reproductor.settings.volume = Volumen.Value;
        }
    }
}

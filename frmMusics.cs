using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adoradores_5
{
    public partial class frmMusics : Form
    {
        private string[] Music;
        private string[] URL;

        // Construtor para inicializar com nome e URL individuais
        public frmMusics(string nome, string url)
        {
            InitializeComponent();
            this.Music = new string[] { nome }; // Armazena o nome da música em um array
            this.URL = new string[] { url }; // Armazena a URL em um array
        }

        // Construtor para inicializar com arrays de músicas e URLs
        public frmMusics(string[] musicArray, string[] urlArray)
        {
            InitializeComponent();
            this.Music = musicArray;
            this.URL = urlArray;
        }

        private void frmMusics_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                axWindowsMediaPlayer1.fullScreen = true;
            }
        }

        private void frmMusics_FormClosed(object sender, FormClosedEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void axWindowsMediaPlayer1_EndOfStream(object sender, AxWMPLib._WMPOCXEvents_EndOfStreamEvent e)
        {
            this.Close();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {            
            if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.fullScreen = true; // Coloca em tela cheia quando começa a tocar
            }
            else if ((WMPLib.WMPPlayState)e.newState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer1.fullScreen = false; // Sai da tela cheia quando para de tocar
                this.Close(); // Fecha o formulário quando a música termina
            }

        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close(); // Fecha o formulário ao pressionar Esc
                return true; // Indica que o pressionamento de tecla foi processado
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }


        private void frmMusics_Load(object sender, EventArgs e)
        {
            if (Music.Length == 1)
            {
                axWindowsMediaPlayer1.URL = this.URL[0];
                this.Text += this.Music[0];

                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                for (int i = 0; i < 12; i++)
                {

                    axWindowsMediaPlayer1.URL = this.URL[i];
                    this.Text += this.Music[i];

                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    
                }
            }
            
        }
    }
}

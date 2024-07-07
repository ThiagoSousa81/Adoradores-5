using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Adoradores_5
{
    public partial class frmPrincipal : Form
    {
        frmMusics frm;
        string[] Music = new string[13];
        string[] URL = new string[13];

        public frmPrincipal()
        {
            InitializeComponent();
            LoadMusicFromXML(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), @"Adoradores 5\musics.xml"));
        }

        private void LoadMusicFromXML(string caminhoXML)
        {
            try
            {
                XDocument doc = XDocument.Load(caminhoXML);
                try
                {
                    for (int i = 0; i <= 12; i++)
                    {
                        // Use ElementAt(i) para acessar o elemento específico no índice i
                        XElement elementoMusica = doc.Descendants("musica").ElementAt(i);

                        string titulo = elementoMusica.Element("titulo").Value;
                        string caminho = elementoMusica.Element("caminho").Value;

                        Music[i] = titulo;
                        URL[i] = caminho;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar as músicas: " + ex.Message, "Adoradores 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar lista de músicas: " + ex.Message, "Adoradores 5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == Convert.ToChar(Keys.Escape))
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://thiagosousa81.wordpress.com/");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pbDigno_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[12], this.URL[12]);
            frm.ShowDialog();
        }

        private void pbPraTeuLouvor_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[1], this.URL[1]);
            frm.ShowDialog();
        }

        private void pbGraca_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[2], this.URL[2]);
            frm.ShowDialog();
        }

        private void pbUsame_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[3], this.URL[3]);
            frm.ShowDialog();
        }

        private void pbVitoria_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[4], this.URL[4]);
            frm.ShowDialog();
        }

        private void pbCartaDeAmor_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[5], this.URL[5]);
            frm.ShowDialog();
        }

        private void pbEsOArQueEuRespiro_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[6], this.URL[6]);
            frm.ShowDialog();
        }

        private void pbIntensamente_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[7], this.URL[7]);
            frm.ShowDialog();
        }

        private void pbNossaMissao_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[8], this.URL[8]);
            frm.ShowDialog();
        }

        private void pbEleVaiAgir_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[9], this.URL[9]);
            frm.ShowDialog();
        }

        private void pbCaminho_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[10], this.URL[10]);
            frm.ShowDialog();
        }

        private void pbSantoEspirito_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[11], this.URL[11]);
            frm.ShowDialog();
        }

        private void pbJesus_Click(object sender, EventArgs e)
        {
            frm = new frmMusics(this.Music[0], this.URL[0]);
            frm.ShowDialog();
        }       

        private void pbLogo_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/thiagosousa81");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pbJesus_MouseEnter(object sender, EventArgs e)
        {
            pbJesus.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbJesus_MouseLeave(object sender, EventArgs e)
        {
            pbJesus.BorderStyle= BorderStyle.Fixed3D;
        }

        private void pbPraTeuLouvor_MouseEnter(object sender, EventArgs e)
        {
            pbPraTeuLouvor.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbGraca_MouseEnter(object sender, EventArgs e)
        {
            pbGraca.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbUsame_MouseEnter(object sender, EventArgs e)
        {
            pbUsame.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbVitoria_MouseEnter(object sender, EventArgs e)
        {
            pbVitoria.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbCartaDeAmor_MouseEnter(object sender, EventArgs e)
        {
            pbCartaDeAmor.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbEsOArQueEuRespiro_MouseEnter(object sender, EventArgs e)
        {
            pbEsOArQueEuRespiro.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbIntensamente_MouseEnter(object sender, EventArgs e)
        {
            pbIntensamente.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbNossaMissao_MouseEnter(object sender, EventArgs e)
        {
            pbNossaMissao.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbEleVaiAgir_MouseEnter(object sender, EventArgs e)
        {
            pbEleVaiAgir.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbCaminho_MouseEnter(object sender, EventArgs e)
        {
            pbCaminho.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbSantoEspirito_MouseEnter(object sender, EventArgs e)
        {
            pbSantoEspirito.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbDigno_MouseEnter(object sender, EventArgs e)
        {
            pbDigno.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pbPraTeuLouvor_MouseLeave(object sender, EventArgs e)
        {
            pbPraTeuLouvor.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbGraca_MouseLeave(object sender, EventArgs e)
        {
            pbGraca.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbUsame_MouseLeave(object sender, EventArgs e)
        {
            pbUsame.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbVitoria_MouseLeave(object sender, EventArgs e)
        {
            pbVitoria.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbCartaDeAmor_MouseLeave(object sender, EventArgs e)
        {
            pbCartaDeAmor.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbEsOArQueEuRespiro_MouseLeave(object sender, EventArgs e)
        {
            pbEsOArQueEuRespiro.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbIntensamente_MouseLeave(object sender, EventArgs e)
        {
            pbIntensamente.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbNossaMissao_MouseLeave(object sender, EventArgs e)
        {
            pbNossaMissao.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbEleVaiAgir_MouseLeave(object sender, EventArgs e)
        {
            pbEleVaiAgir.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbCaminho_MouseLeave(object sender, EventArgs e)
        {
            pbCaminho.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pbSantoEspirito_MouseLeave(object sender, EventArgs e)
        {
            pbSantoEspirito.BorderStyle = BorderStyle.Fixed3D;
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

        private void pbDigno_MouseLeave(object sender, EventArgs e)
        {
            pbDigno.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnALL_Click(object sender, EventArgs e)
        {            
            frm = new frmMusics(this.Music, this.URL);
            frm.ShowDialog();
        }
    }
}

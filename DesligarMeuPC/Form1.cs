using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesligarMeuPC
{
    public partial class Form1 : Form
    {
        int hora, min, seg;
        public Form1()
        {
            InitializeComponent();
        }
        private void arrowdownHora_MouseClick(object sender, MouseEventArgs e)
        {
            string texto = lbHora.Text;
            hora = Convert.ToInt32(texto);
            hora = hora - 1;
            lbHora.Text = hora.ToString();

            if (hora <= 0)
            {
                hora = 0;
                lbHora.Text = hora.ToString();
            }
        }

        private void arrowupHora_MouseClick(object sender, MouseEventArgs e)
        {
            string texto = lbHora.Text;
            hora = Convert.ToInt32(texto);
            hora = hora + 1;
            lbHora.Text = hora.ToString();

            if (hora == 24)
            {
                hora = 24;
                lbHora.Text = hora.ToString();
            }
        }

        private void arrowupMinuto_MouseClick(object sender, MouseEventArgs e)
        {
            string texto = lbMinuto.Text;
            min = Convert.ToInt32(texto);
            min = min + 1;
            lbMinuto.Text = min.ToString();         
        }

        private void arrowdownMinuto_MouseClick(object sender, MouseEventArgs e)
        {
            string texto = lbMinuto.Text;
            min = Convert.ToInt32(texto);
            min = min - 1;
            lbMinuto.Text = min.ToString();
           
            if (min <= 0)
            {
                min = 0;
                lbMinuto.Text = min.ToString();
            }
        }

        private void arrowupSegundo_MouseClick(object sender, MouseEventArgs e)
        {
            string texto = lbSegundo.Text;
            seg = Convert.ToInt32(texto);
            seg = seg + 1;
            lbSegundo.Text = seg.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var processo = new ProcessStartInfo("shutdown", "-a");
            processo.CreateNoWindow = true;
            processo.UseShellExecute = false;
            Process.Start(processo);
            seg = 0;
            min = 0;
            hora = 0;
            lbHora.Text = "0";
            lbMinuto.Text = "0";
            lbSegundo.Text = "0";
        }
        private void lbfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbrefreshhora_Click(object sender, EventArgs e)
        {
            lbHora.Text = "0";
        }

        private void lbrefreshminuto_Click(object sender, EventArgs e)
        {
            lbMinuto.Text = "0";
        }

        private void lbrefreshsegundo_Click(object sender, EventArgs e)
        {
            lbSegundo.Text = "0";
        }

        private void arrowupHora_Click(object sender, EventArgs e)
        {

        }

        private void arrowdownSegundo_MouseClick(object sender, MouseEventArgs e)
        {
            string texto = lbSegundo.Text;
            seg = Convert.ToInt32(texto);
            seg = seg - 1;
            lbSegundo.Text = seg.ToString();
         
            if (seg <= 0)
            {
                seg = 0;
                lbSegundo.Text = seg.ToString();
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int tempoDefault = 0;
            tempoDefault = seg + (min * 60) + (hora * 3600);

            var processo = new ProcessStartInfo("shutdown", "/s /t " + tempoDefault);
            processo.CreateNoWindow = true;
            processo.UseShellExecute = false;
            Process.Start(processo);

        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Fantasy_App
{
    public partial class frmUno : Form
    {
        public frmUno()
        {
            InitializeComponent();
        }

        // Atributos
        private bool cambiarTema;

        public bool CambiarTema
        {
            get { return cambiarTema; }
            set { cambiarTema = value; }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                pboxJuego1.Load("C:\\ffapp\\FFI.jpg");
                pboxJuego2.Load("C:\\ffapp\\FFII.jpg");
                pboxJuego3.Load("C:\\ffapp\\FFIII.png");
                pboxJuego4.Load("C:\\ffapp\\FFIV.jpg");
                pboxJuego5.Load("C:\\ffapp\\FFV.jpg");
                pboxJuego6.Load("C:\\ffapp\\FFVI.jpg");
                pboxJuego7.Load("C:\\ffapp\\FFVII.jpg");
                pboxJuego8.Load("C:\\ffapp\\FFVIII.jpg");
                pboxJuego9.Load("C:\\ffapp\\FFIX.jpg");
                pboxJuego10.Load("C:\\ffapp\\FFX.jpg");
                pboxJuego11.Load("C:\\ffapp\\FFXI.jpg");
                pboxJuego12.Load("C:\\ffapp\\FFXII.jpg");
                pboxJuego13.Load("C:\\ffapp\\FFXIII.jpg");
                pboxJuego14.Load("C:\\ffapp\\FFXIV.jpg");
                pboxJuego15.Load("C:\\ffapp\\FFXV.jpg");
            }
            catch (Exception ex)
            {
                throw ex;
            }


        
        }

        private void pboxJuego1_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy I", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego2_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy II", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego3_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy III", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego4_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy IV", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego5_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy V", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego6_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy VI", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego7_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy VII", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego8_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy VIII", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego9_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy IX", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego10_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy X", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego11_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy XI", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego12_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy XII", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego13_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy XIII", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego14_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy XIV", cambiarTema);
            ventana.ShowDialog();
        }

        private void pboxJuego15_Click(object sender, EventArgs e)
        {
            Form2 ventana = new Form2("Personajes Final Fantasy XV", cambiarTema);
            ventana.ShowDialog();
        }

        private void btnCambiarModo_Click(object sender, EventArgs e)
        {
  
            if (lblCambiarModo.Text == "Modo claro:")
            {
                BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                btnCambiarModo.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                lblCambiarModo.ForeColor = Color.Black;
                lblFinalFantasy.ForeColor = Color.Black;
                lblCambiarModo.Text = "Modo oscuro:";
                CambiarTema = true;

            }
            else if (lblCambiarModo.Text == "Modo oscuro:")
            {
                BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                btnCambiarModo.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                lblCambiarModo.ForeColor = Color.White;
                lblFinalFantasy.ForeColor = Color.White;
                lblCambiarModo.Text = "Modo claro:";
                CambiarTema = false;
            }
            
          
        }
    }
}

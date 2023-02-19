using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Service;

namespace Final_Fantasy_App
{
    public partial class Form4 : Form
    {
        public Form4(string value, bool val)
        {
            InitializeComponent();
            lblPapelera.Text = value;
            cambiarTemaF4 = val;
        }

        private List<PersonajeFF> listaPapelera;
        public bool cambiarTemaF4;
        

        private void cargarFormPapelera()
        {
            PersonajeService service = new PersonajeService();
            if(lblPapelera.Text == "Papelera Final Fantasy I")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 1 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy II")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 2 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy III")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 3 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy IV")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 4 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy V")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 5 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy VI")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 6 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy VII")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 7 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy VIII")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 8 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy IX")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 9 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy X")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 10 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy XI")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 11 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy XII")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 12 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy XIII")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 13 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy XIV")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 14 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }
            if (lblPapelera.Text == "Papelera Final Fantasy XV")
            {
                listaPapelera = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 15 AND activo = 0");
                dgvPapelera.DataSource = listaPapelera;

            }

            dgvPapelera.Columns["IdPers"].Visible = false;

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if(cambiarTemaF4 == true)
            {
                BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                lblPapelera.ForeColor = Color.Black;
                lblPapelera.BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            }
            else
            {
                BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }
            cargarFormPapelera();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            PersonajeFF seleccionado;
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if(dgvPapelera.Rows.Count != 0)
                {
                    seleccionado = (PersonajeFF)dgvPapelera.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro? Estás restaurando a " + seleccionado.Nombre + "", "Restaurando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        datos.SetConsulta("update personajes set activo = 1 where id_pers = @id");
                        datos.SetParametro("@id", seleccionado.IdPers);
                        datos.EjecutarAccion();
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber algún personaje en la papelera para restaurarlo");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
            cargarFormPapelera();
        }

        private void btnEliminarPapelera_Click(object sender, EventArgs e)
        {
            PersonajeFF seleccionado;
            PersonajeService service = new PersonajeService();

            try
            {
                if(dgvPapelera.Rows.Count != 0)
                {
                    seleccionado = (PersonajeFF)dgvPapelera.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro? Estás eliminando a " + seleccionado.Nombre + "", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {

                        service.EliminarPersonaje(seleccionado);
                        cargarFormPapelera();
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber algún personaje en la papelera para eliminarlo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    
    }
}

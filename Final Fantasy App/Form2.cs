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
    public partial class Form2 : Form
    {
        // Constructor sobrecargado
        public Form2(string value, bool val)
        {
            InitializeComponent();
            lblPersonajes.Text = value;
            tipoTema = val;
        }

        // Atributos

        private List<PersonajeFF> listaPersonajes;
        public bool tipoTema;

        // Metodos
        private void Form2_Load(object sender, EventArgs e)
        {
            if(tipoTema == true)
            {
                BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                lblPersonajes.ForeColor = Color.Black;
                lblNombre.ForeColor = Color.Black;
                lblFiltroRap.ForeColor = Color.Black;
                lblDescripcion.ForeColor = Color.Black;
                lblTextoAgregar.ForeColor = Color.Black;
                lblDeleteTemp.ForeColor = Color.Black;
                lblDeletePers.ForeColor = Color.Black;
                lblModificarPers.ForeColor = Color.Black;
            }
            else
            {
                BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            }
            
            cargarForm2();
        }

        private void dgvPersonajes_SelectionChanged(object sender, EventArgs e)
        {
            PersonajeFF seleccionado = (PersonajeFF)dgvPersonajes.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.UrlImagen);
            lblNombre.Text = seleccionado.Nombre;

            lblDescripcion.Text = seleccionado.Descripcion;
        }

        private void btnAgregarPersVentana_Click(object sender, EventArgs e)
        {
            if(lblPersonajes.Text == "Personajes Final Fantasy I")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy I", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy II")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy II", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy III")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy III", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy IV")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy IV", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy V")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy V", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy VI")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy VI", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy VII")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy VII", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy VIII")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy VIII", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy IX")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy IX", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy X")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy X", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XI")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy XI", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XII")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy XII", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XIII")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy XIII", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XIV")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy XIV", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XV")
            {
                frmAgregar ventana = new frmAgregar("Final Fantasy XV", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
        }

        private void cargarForm2()
        {
            PersonajeService service = new PersonajeService();
            lblDescripcion.MaximumSize = new Size(700, 0);
            pboxPapelera.Load("https://img.icons8.com/color/480/recycle-bin.png");
            if (lblPersonajes.Text == "Personajes Final Fantasy I")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 1 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy II")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 2 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy III")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 3 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy IV")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 4 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy V")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 5 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy VI")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 6 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy VII")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 7 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy VIII")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 8 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);
            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy IX")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 9 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy X")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 10 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XI")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 11 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XII")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 12 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XIII")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 13 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XIV")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 14 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            else if (lblPersonajes.Text == "Personajes Final Fantasy XV")
            {
                listaPersonajes = service.Listar("SELECT p.id_pers, p.nombre_pers, p.descripcion_pers, p.imagen_pers, p.activo, j.nombre_juego FROM juegos j, personajes p WHERE numero_juegos = id_juegos AND numero_juegos = 15 AND activo = 1");
                dgvPersonajes.DataSource = listaPersonajes;
                CargarImagen(listaPersonajes[0].UrlImagen);

            }
            dgvPersonajes.Columns["UrlImagen"].Visible = false;
            dgvPersonajes.Columns["Descripcion"].Visible = false;
            dgvPersonajes.Columns["IdPers"].Visible = false;
          
           
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pboxPersonajes.Load(imagen);
            }
            catch (Exception)
            {
                pboxPersonajes.Load("https://static.videezy.com/system/resources/thumbnails/000/037/474/original/circle-loading.jpg");
            }
        }

        private void btnDeletePers_Click(object sender, EventArgs e)
        {
            PersonajeFF seleccionado;
            PersonajeService service = new PersonajeService();
    
            try
            {
                if(dgvPersonajes.Rows.Count != 0)
                {
                    seleccionado = (PersonajeFF)dgvPersonajes.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro? Estás eliminando a " + seleccionado.Nombre + "", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {

                        service.EliminarPersonaje(seleccionado);
                        cargarForm2();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tiene que haber algún personaje seleccionado para eliminarlo");
                }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btnDeleteTemp_Click(object sender, EventArgs e)
        {
            PersonajeFF seleccionado;
            PersonajeService service = new PersonajeService();

            try
            {
                if(dgvPersonajes.Rows.Count != 0)
                {
                    seleccionado = (PersonajeFF)dgvPersonajes.CurrentRow.DataBoundItem;
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro? Estás enviando a la papelera de reciclaje a " + seleccionado.Nombre + "", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (respuesta == DialogResult.Yes)
                    {
                        service.EliminarTemporal(seleccionado);
                        cargarForm2();
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que haber algún personaje seleccionado para eliminarlo");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnModificarPers_Click(object sender, EventArgs e)
        {
            PersonajeFF seleccionado;
            try
            {

                if (dgvPersonajes.Rows.Count != 0)
                {
                    seleccionado = (PersonajeFF)dgvPersonajes.CurrentRow.DataBoundItem;
                    if (lblPersonajes.Text == "Personajes Final Fantasy I")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy I", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy II")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy II", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy III")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy III", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy IV")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy IV", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy V")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy V", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy VI")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy VI", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy VII")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy VII", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy VIII")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy VIII", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy IX")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy IX", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy X")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy X", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy XI")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy XI", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy XII")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy XII", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy XIII")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy XIII", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy XIV")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy XIV", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                    else if (lblPersonajes.Text == "Personajes Final Fantasy XV")
                    {
                        frmAgregar ventana = new frmAgregar("Final Fantasy XV", seleccionado, tipoTema);
                        ventana.ShowDialog();
                        cargarForm2();
                    }
                }
                else
                {
                    MessageBox.Show("Tiene que haber algún personaje seleccionado para modificarlo");
                }
                
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        // Botones eventos Hover y Leave

        private void btnAgregarPersVentana_MouseHover(object sender, EventArgs e)
        {
            btnAgregarPersVentana.BackColor = Color.Gray;
        }

        private void btnAgregarPersVentana_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarPersVentana.BackColor = Color.DimGray;
        }

        private void btnDeletePers_MouseHover(object sender, EventArgs e)
        {
            btnDeletePers.BackColor = Color.Gray;
        }

        private void btnDeletePers_MouseLeave(object sender, EventArgs e)
        {
            btnDeletePers.BackColor = Color.DimGray;
        }

        private void btnDeleteTemp_MouseHover(object sender, EventArgs e)
        {
            btnDeleteTemp.BackColor = Color.Gray;
        }

        private void btnDeleteTemp_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteTemp.BackColor = Color.DimGray;
        }

        private void btnModificarPers_MouseHover(object sender, EventArgs e)
        {
            btnModificarPers.BackColor = Color.Gray;
        }

        private void btnModificarPers_MouseLeave(object sender, EventArgs e)
        {
            btnModificarPers.BackColor = Color.DimGray;
        }

        // Metodos filtros
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<PersonajeFF> listaFitrada;
            string filtro = txtBuscar.Text;
            if (filtro != "")
            {
                listaFitrada = listaPersonajes.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                // En el curso pone el Data Grid View en null
                dgvPersonajes.DataSource = listaFitrada;
            }
            else
            {
                dgvPersonajes.DataSource = listaPersonajes; 
            }
        }


        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<PersonajeFF> listaFitrada;
            string filtro = txtBuscar.Text;
            if (filtro != "" && filtro.Length >= 3)
            {
                listaFitrada = listaPersonajes.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
                dgvPersonajes.DataSource = listaFitrada;
            }
            else
            {
                dgvPersonajes.DataSource = listaPersonajes;
            }
        }

        private void pboxPapelera_Click(object sender, EventArgs e)
        {
            if(lblPersonajes.Text == "Personajes Final Fantasy I")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy I", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy II")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy II", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy III")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy III", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy IV")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy IV", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy V")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy V", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy VI")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy VI", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy VII")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy VII", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy VIII")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy VIII", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy IX")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy IX", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy X")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy X", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy XI")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy XI", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy XII")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy XII", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy XIII")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy XIII", tipoTema);
                ventana.ShowDialog();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy XIV")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy XIV", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }
            if (lblPersonajes.Text == "Personajes Final Fantasy XV")
            {
                Form4 ventana = new Form4("Papelera Final Fantasy XV", tipoTema);
                ventana.ShowDialog();
                cargarForm2();
            }

        }
    }
}

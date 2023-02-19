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
using System.Configuration;
using System.IO;

namespace Final_Fantasy_App
{
    public partial class frmAgregar : Form
    {
        // Constructor sobrecargado
        public frmAgregar(string value, bool val)
        {

            InitializeComponent();
            lblFFNum.Text = value;
            cambiarTemaF3 = val;
        }

        public frmAgregar(string value, PersonajeFF seleccionado, bool val)
        {
            InitializeComponent();
            lblFFNum.Text = value;
            cambiarTemaF3 = val;
            txtAgrNombre.Text = seleccionado.Nombre;
            txtAgrDescripcion.Text = seleccionado.Descripcion;
            txtAgrImagen.Text = seleccionado.UrlImagen;
            CargarImagen(seleccionado.UrlImagen);
            btnAgregarPers.Text = "Modificar";
            modificado = seleccionado;
            
         
        }

        // Atributos

        private PersonajeFF modificado = new PersonajeFF();
        private OpenFileDialog archivo = null;
        public bool cambiarTemaF3;

        // Propiedades

        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarPers_Click(object sender, EventArgs e)
        {
            PersonajeFF personaje = new PersonajeFF();
            PersonajeService service = new PersonajeService();

            try
            {
                personaje.Nombre = txtAgrNombre.Text;
                personaje.Descripcion = txtAgrDescripcion.Text;
                personaje.UrlImagen = txtAgrImagen.Text;

                modificado.Nombre = txtAgrNombre.Text;
                modificado.Descripcion = txtAgrDescripcion.Text;
                modificado.UrlImagen = txtAgrImagen.Text;

                if (txtAgrNombre.Text != "" && txtAgrDescripcion.Text != "" && txtAgrImagen.Text != "")
                {
                    if (lblFFNum.Text == "Final Fantasy I")
                    {
                        if(btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 1);
                        }
                        if(btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }                    
                    }
                    else if (lblFFNum.Text == "Final Fantasy II")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 2);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy III")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 3);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy IV")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 4);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy V")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 5);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy VI")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 6);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy VII")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 7);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy VIII")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 8);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy IX")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 9);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy X")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 10);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy XI")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 11);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy XII")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 12);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy XIII")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 13);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy XIV")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 14);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    else if (lblFFNum.Text == "Final Fantasy XV")
                    {
                        if (btnAgregarPers.Text == "Agregar")
                        {
                            service.AgregarPersonaje(personaje, 15);
                        }
                        if (btnAgregarPers.Text == "Modificar")
                        {
                            service.ModificarPersonaje(modificado);
                        }
                    }
                    // Copiar imagen levantada
                    if(archivo != null && !(txtAgrImagen.Text.ToUpper().Contains("HTTP")))
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["ffapp-folder"] + archivo.SafeFileName);

                    if (btnAgregarPers.Text == "Agregar")
                    {
                        MessageBox.Show("Agregado exitosamente");
                    }
                    else if(btnAgregarPers.Text == "Modificar")
                    {
                        MessageBox.Show("Modificado exitosamente");
                    }
                }
                else if(txtAgrNombre.Text == "" || txtAgrDescripcion.Text == "" || txtAgrImagen.Text == "")
                {
                    MessageBox.Show("Falta completar algún campo");
                }
                
                Close();             

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void CargarImagen(string imagen)
        {
            try
            {
                pboxAgrImagen.Load(imagen);
            }
            catch (Exception)
            {
                pboxAgrImagen.Load("https://static.videezy.com/system/resources/thumbnails/000/037/474/original/circle-loading.jpg");
            }
        }

        private void txtAgrImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtAgrImagen.Text);
        }

        // Botones eventos Hover y Leave
        private void btnAgregarPers_MouseHover(object sender, EventArgs e)
        {
            btnAgregarPers.BackColor = Color.Gray;
        }

        private void btnAgregarPers_MouseLeave(object sender, EventArgs e)
        {
            btnAgregarPers.BackColor = Color.DimGray;
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.Gray;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            btnCancelar.BackColor = Color.DimGray;
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtAgrImagen.Text = archivo.FileName;
                CargarImagen(archivo.FileName);

                // Guardar la imagen copiando archivo en carpeta creada

                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["ffapp-folder"] + archivo.SafeFileName);

            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            if(cambiarTemaF3 == true)
            {
                BackColor = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                lblFFNum.ForeColor = Color.Black;
                lblAgrNombre.ForeColor = Color.Black;
                lblAgrDescripcion.ForeColor = Color.Black;
                lblAgrImagen.ForeColor = Color.Black;

            }
            else
            {
                BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

            }
        }
    }
}

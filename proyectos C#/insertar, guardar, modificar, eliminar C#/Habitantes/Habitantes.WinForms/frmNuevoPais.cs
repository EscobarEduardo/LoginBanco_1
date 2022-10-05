using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Habitantes.Entities;
using Habitantes.BusinessLogic;

namespace Habitantes.WinForms
{
    public partial class frmNuevoPais : Form
    {
        int id=0;
        //Se ejecuta cuando llaman al form, desde nuevo
        public frmNuevoPais()
        {
            InitializeComponent();
        }

        //Se debe ejecutar cuando llamen al form desde editar
        //Debe pasar una entidad
        public frmNuevoPais(Pais entity)
        {
            InitializeComponent();
            id = entity.PaisId;
            labelTitulo.Text = "Modificar Pais";
            textBoxId.Text = entity.PaisId.ToString() ;
            textBoxNombre.Text = entity.Nombre;
            textBoxCantidad.Text = entity.Cantidad.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComprobarCampos()
        {
            errorProvider1.Clear();
            if (textBoxNombre.Text == "")
            {
                errorProvider1.SetError(textBoxNombre, "Campo obligatorio!");
            }

            if (textBoxCantidad.Text == "")
            {
                errorProvider1.SetError(textBoxCantidad, "Debe escribir la cantidad");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComprobarCampos();

            Pais entity = new Pais()
            {
                Nombre = textBoxNombre.Text.Trim(),
                Cantidad = int.Parse(textBoxCantidad.Text)
            };

            //
            if (id > 0) //Editar
            {
                entity.PaisId = id;

                if (PaisBL.Instance.Update(entity))
                {
                    MessageBox.Show("Registro se edito con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("Error al editar el registro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {                
                if (PaisBL.Instance.Insert(entity))
                {
                    MessageBox.Show("Registro se agrego con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();

            //*Cargar los datos a la entidad
            //LLamar al metodo insert de la clase trabajada en BL
            //Insert BL se encarga de llamar al metodo insert de la capa DAL
            //Insert en la capa DAL realiza las operacione en la bd

        }

        private void frmNuevoPais_Load(object sender, EventArgs e)
        {

        }
    }
}

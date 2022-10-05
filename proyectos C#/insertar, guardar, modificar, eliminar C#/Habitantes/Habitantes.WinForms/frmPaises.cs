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
    public partial class frmPaises : Form
    {
        List<Pais> _listado;
        public frmPaises()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGrid();

            
        }

        private void UpdateGrid()
        {
            _listado = PaisBL.Instance.SelectAll();
            dataGridView1.DataSource = _listado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNuevoPais frm = new frmNuevoPais();
            frm.ShowDialog();
            UpdateGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["Editar"].Selected)
            {
                int id = (int) dataGridView1.Rows[e.RowIndex].Cells["PaisId"].Value;
                string nombre = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
                int cantidad = (int)dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value;

                Pais entity = new Pais()
                {
                    PaisId = id,
                    Nombre = nombre,
                    Cantidad = cantidad
                };

                frmNuevoPais frm = new frmNuevoPais(entity);
                frm.ShowDialog();                

            }
            if (dataGridView1.CurrentRow.Cells["Eliminar"].Selected)
            {
                int id = (int) dataGridView1.Rows[e.RowIndex].Cells["PaisId"].Value;

                DialogResult dr = MessageBox.Show("Realmente desea eliminar el registro seleccionado?", "Confirmacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if(dr == DialogResult.Yes)
                {
                    if (PaisBL.Instance.Delete(id))
                    {
                        MessageBox.Show("El registro se elimino con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            UpdateGrid();
        }
    }
}

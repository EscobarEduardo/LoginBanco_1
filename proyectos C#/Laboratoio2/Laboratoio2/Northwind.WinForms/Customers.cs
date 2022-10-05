using Laboratoio2.Northwind.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratoio2.Northwind.WinForms
{
   private List<Customers> _listado;
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            ShowDialog();
        }

        private void UpdateGrid()
        {
            _listado = CustomersBL.Instance.SelectAll();
            dataGridView1.DataSource = _listado;
        }

       

        /*
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (dataGridView1.CurrentRow.Cells["Editar"].Selected)
                {
                    int CustomerID = (int)dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value;
                    string CompanyName = dataGridView1.Rows[e.RowIndex].Cells["CompanyName"].Value.ToString();
                string ContactName = dataGridView1.Rows[e.RowIndex].Cells["ContactName"].Value.ToString();
                string ContactTitle = dataGridView1.Rows[e.RowIndex].Cells["ContactTitle"].Value.ToString();
                string Address = dataGridView1.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                string City = dataGridView1.Rows[e.RowIndex].Cells["City"].Value.ToString();
                string Region = dataGridView1.Rows[e.RowIndex].Cells["Region"].Value.ToString();
                string PostalCode = dataGridView1.Rows[e.RowIndex].Cells["PostalCode"].Value.ToString();
                string Country = dataGridView1.Rows[e.RowIndex].Cells["Country"].Value.ToString();
                string Phone = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                string Fax = dataGridView1.Rows[e.RowIndex].Cells["Fax"].Value.ToString();


                Pais entity = new Pais()
                    {
                        PaisId = id,
                        Nombre = nombre,
                        Cantidad = cantidad
                    };



                }
        */
            }
        
}

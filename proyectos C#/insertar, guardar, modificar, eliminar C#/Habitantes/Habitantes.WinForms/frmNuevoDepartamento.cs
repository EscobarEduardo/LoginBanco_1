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
    public partial class frmNuevoDepartamento : Form
    {
        List<Pais> _listadoPais;
        public frmNuevoDepartamento()
        {
            InitializeComponent();
        }

        private void frmNuevoDepartamento_Load(object sender, EventArgs e)
        {
            UpdateCombo();
        }

        private void UpdateCombo()
        {
            _listadoPais = PaisBL.Instance.SelectAll();
            comboBoxPaises.DataSource = _listadoPais;
            comboBoxPaises.DisplayMember = "Nombre";
            comboBoxPaises.ValueMember = "PaisId";
        }

        private void comboBoxPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(" ID " + comboBoxPaises.SelectedValue.ToString());
        }
    }
}

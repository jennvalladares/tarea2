using BLClintes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BLClintes.MantenimientoBL;

namespace Win.Rentas
{
    public partial class FormClientes : Form
    {
        MantenimientoBL _cliente;

        public FormClientes()
        {
            InitializeComponent();
            _cliente = new MantenimientoBL();
            mantenimientoBL_ClienteBindingSource1.DataSource = _cliente.VerCliente();


        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void identidadLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientoBL_ClienteBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
        var cliente = (Cliente)mantenimientoBL_ClienteBindingSource.Current;
        }
        //cliente.Activo();
        //MessageBox.Show(cliente);
    }
 }


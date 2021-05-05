using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void factura_printBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.factura_printBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Factura_print' table. You can move, or remove it, as needed.
            this.factura_printTableAdapter.Fill(this.dataSet1.Factura_print);


        }
        

        private void factura_printDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            factura_printDataGridView.Update();
            factura_printDataGridView.Refresh();
        }
    }
}

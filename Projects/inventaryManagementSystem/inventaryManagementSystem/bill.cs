using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventaryManagementSystem
{
    public partial class bill : Form
    {
        public bill()
        {
            InitializeComponent();
        }

        private void bill_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet2.order_item1' table. You can move, or remove it, as needed.
            this.order_item1TableAdapter.Fill(this.DataSet2.order_item1);

            this.reportViewer1.RefreshReport();
        }
    }
}

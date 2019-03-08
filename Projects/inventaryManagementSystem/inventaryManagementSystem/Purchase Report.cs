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
    public partial class Purchase_Report : Form
    {
        public Purchase_Report()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Report_Load(object sender, EventArgs e)
        {
        //    // TODO: This line of code loads data into the 'Custompurchase.Purchase' table. You can move, or remove it, as needed.
        //    this.PurchaseTableAdapter.Fill(this.Custompurchase.Purchase);
        //    // TODO: This line of code loads data into the 'DataSet2.order_item1' table. You can move, or remove it, as needed.
        //    this.order_item1TableAdapter.Fill(this.DataSet2.order_item1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        //    string from = Convert.ToString(dateTimePicker1);
        //    string to = Convert.ToString(dateTimePicker2);
        //     TODO: This line of code loads data into the 'Custompurchase.Purchase' table. You can move, or remove it, as needed.
        //    this.PurchaseTableAdapter.Fill(this.Custompurchase.Purchase,from,to);
        //    this.reportViewer1.RefreshReport();
        }
    }
}

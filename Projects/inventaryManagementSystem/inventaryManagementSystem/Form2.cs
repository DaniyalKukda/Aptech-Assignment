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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string from = Convert.ToString(dateTimePicker1);
                string to = Convert.ToString(dateTimePicker2);
                // TODO: This line of code loads data into the 'Custompurchase.Purchase' table. You can move, or remove it, as needed.
                this.PurchaseTableAdapter.Fill(this.Custompurchase.Purchase,from,to);
                this.reportViewer1.RefreshReport();

        }
    }
}

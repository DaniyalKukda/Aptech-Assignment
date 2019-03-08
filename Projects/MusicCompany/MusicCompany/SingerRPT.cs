using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicCompany
{
    public partial class SingerRPT : Form
    {
        public SingerRPT()
        {
            InitializeComponent();
        }

        private void SingerRPT_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'musicCompanyDataSet.singer' table. You can move, or remove it, as needed.
            this.singerTableAdapter.Fill(this.musicCompanyDataSet.singer);

            this.reportViewer1.RefreshReport();
        }
    }
}

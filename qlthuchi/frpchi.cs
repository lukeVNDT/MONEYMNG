using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlthuchi
{
    public partial class frpchi : Form
    {
        public frpchi()
        {
            InitializeComponent();
        }

        private void frpchi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qlthuchiDataSet2.USP_chiinforp' table. You can move, or remove it, as needed.
            this.USP_chiinforpTableAdapter.Fill(this.qlthuchiDataSet2.USP_chiinforp);

            this.reportViewer1.RefreshReport();
        }
    }
}

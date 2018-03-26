using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MainForm
{
    public partial class Tables : Form
    {
        public Tables()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Visible = true;
        }
    }
}

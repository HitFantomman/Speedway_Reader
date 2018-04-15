using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class AccessBD : Form
    {
        public AccessBD()
        {
            InitializeComponent();
        }

        private void BtnAccess_Click(object sender, EventArgs e)
        {
            if (BoxPassword.Text == "Admin")
            {
                this.Hide();
                Tables BDform = new Tables();
                BDform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не правильный пароль!");
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

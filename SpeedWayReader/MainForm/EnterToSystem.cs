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
    public partial class EnterToSystem : Form
    {
        public EnterToSystem()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (BoxPassword.Text == "user")
            {
                this.Hide();
                Main mainform = new Main();
                mainform.ShowDialog();
            }
            else
            {
                MessageBox.Show("Не правильный пароль!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.POS_GUI
{
    public partial class FormPOS : Form
    {
        public FormPOS()
        {
            InitializeComponent();
            icon_exit.Click += Icon_exit_Click;
        }

        private void Icon_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_de_las_FFFFFFF
{
    public partial class spcreditros : Form
    {
        public spcreditros()
        {
            InitializeComponent();
        }

        private void Spcreditros_Load(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
